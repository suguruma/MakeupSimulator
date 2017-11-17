using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Collections;
using System.Threading;


namespace MakeupSim
{
    public partial class Form1 : Form
    {
        //--- 変数宣言 ---//
        // 画像ファイル
        String CurImageName = ""; // 現在のファイル名
        const string ImageFilter = "Image File (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png|All file (*.*)|*.*";
        const string SaveImageFilter = "BMP (*.bmp)|*.bmp|JPG/JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png";
        // 特徴点ファイル(テキスト)
        String CurFileName = ""; // 現在のファイル名
        const string FileFilter = "Text File (*.txt, *.pts)|*.txt;*.pts|All file (*.*)|*.*";
        // ファイルの位置
        String FolderLocation = "";

        // 特徴点(PTSファイル)
        int pts_property = 12;      // プロパティの行数
        int read_max_point = 103;   // 読み込みの最大点数
        Point[] input_points;       // 点(x,y)の配列宣言
        Point[] database_points;    // 点(x,y)の配列宣言

        string target_pts, target_image;
        string location_pts, location_image;
        string read_extension_str, read_filename_str;   // 読み込み:拡張子/ファイル名
        string save_extension_str, save_filename_str;   // 書き出し:拡張子/ファイル名

        // 三角パッチ
        struct ThreePoints
        {
            public int []px; 	// x座標
            public int []py;	// y座標
            public void Reset()
            {
                px = new int[3];
                py = new int[3];
            }
        }
        ThreePoints[] input_asso = new ThreePoints[137];
        ThreePoints[] database_asso = new ThreePoints[137];
        int asso_counter;

        // 画像情報
        int iWidth, iHeight;
        Bitmap src_img, dst_img, tmp_img, mask_img;
        Bitmap []frame_img = new Bitmap[11];

        // クロスディゾルブ
        int frame_all = 10;

        // スレッド関連
        private Thread thread = null;
        private Boolean bCancel = false;
        int cd_counter;

        // フラグ
        bool btnRun_flag = true;
        bool btnOpen_flag = false;
        bool btnRead_flag = false;

        public Form1()
        {
            InitializeComponent();
        }

        // 初期設定
        private void Form1_Load(object sender, EventArgs e)
        {
            WindowToCenter();
        }

        // ウィンドウ画面を中央に配置
        private void WindowToCenter()
        {
            System.Drawing.Rectangle rect = Screen.PrimaryScreen.Bounds;
            int sx = rect.Width;
            int sy = rect.Height;
            this.Left = (sx - this.Width) / 2;
            this.Top = (sy - this.Height) / 2;
        }

        // 画像を開く
        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = CurImageName;
            openFileDialog1.Filter = ImageFilter;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                btnOpen_flag = true;
                CurImageName = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(CurImageName);

                // 画像情報読み込み
                iWidth = pictureBox1.Image.Width;
                iHeight = pictureBox1.Image.Height;
                src_img = new Bitmap(Image.FromFile(CurImageName));
                dst_img = new Bitmap(Image.FromFile(CurImageName));
                mask_img = new Bitmap(iWidth, iHeight);

                // ファイル名取得
                string[] splitText1;
                string[] splitText2;
                splitText1 = CurImageName.Replace("\\", "/").Split('/');

                // 拡張子前後の取得
                splitText2 = splitText1[splitText1.Count() - 1].Split('.');
                read_extension_str = splitText2[splitText2.Count() - 1];
                read_filename_str = splitText2[splitText2.Count() - 2];
                if (read_filename_str.Length <= 0)
                {
                    read_filename_str = "ReadFilename";
                }
            }
        }

        // 特徴点読み込み
        private void btnRead_Click(object sender, EventArgs e)
        {
            openFileDialog2.FileName = CurFileName;
            openFileDialog2.Filter = FileFilter;
            Array.Resize<Point>(ref input_points, 114);

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                btnRead_flag = true;
                CurFileName = openFileDialog2.FileName;
                string strText = "";
                using (StreamReader sr = new StreamReader(@CurFileName))
                {
                    strText = sr.ReadToEnd();
                }

                // string.Splitで分割
                string[] splitText1;
                splitText1 = strText.Replace("\r\n", "\n").Split('\n');

                for (int i = 0; i < read_max_point; i++)
                {
                    string[] splitText2;
                    splitText2 = splitText1[i + pts_property].Split(' ');

                    // 値をセット
                    input_points[i].X = int.Parse(splitText2[5]);
                    input_points[i].Y = int.Parse(splitText2[6]);
                }
            }
        }

        // 処理
        private void btnRun_Click(object sender, EventArgs e)
        {
            // 初期化
            asso_counter = 0;
            btnRun.Enabled = false;
            btnRun_flag = false;
            StatusProgressBar.Value = 0;
            lblStatus1.Text = "Run   ";
            lblStatus2.Text = "";
            gbMorphingLevel.Enabled = false;

            // 化粧顔の選択
            Select_Impression();

            // 形状の変形
            Transformation_Shape();
            pictureBox3.Image = mask_img; // マスク画像の表示
            pictureBox3.Refresh();

            // クロスディゾルブのスレッドを作成
            thread = new Thread(new ThreadStart(Cross_dissolving_thread));
            bCancel = false;
            timer1.Enabled = true;

            // スレッドを開始する
            cd_counter = 0;
            thread.Start();
        }

        // スレッド途中の処理
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 実行ボタンの表示
            if (btnRun_flag == true)
                btnRun.Enabled = true;
            else
                btnRun.Enabled = false;

            if (cd_counter == 9) // 1,2,3,4,5,6,7,8,9 (0,10を除く)
            {
                // 化粧モーフィング出力
                pictureBox2.Image = frame_img[5]; // 中間画像(50%)を最初に表示
                pictureBox2.Refresh();
                txtbValue.Text = (hScrollBar1.Value * 10).ToString() + "%";

                // スレッド終了後
                gbMorphingLevel.Enabled = true;
                timer1.Enabled = false;
                btnRun.Enabled = true;
                btnRun_flag = true;
                lblStatus1.Text = "Status";
            }
            StatusProgressBar.Value = (int)(((double)cd_counter / 9) * StatusProgressBar.Maximum + 0.5);
            lblStatus2.Text = StatusProgressBar.Value.ToString() + "%";
        }

        // クロスディゾルブスレッド
        private void Cross_dissolving_thread()
        {
            // クロスディゾルブ (処理時間：長)
            for (int i = 1; i < 10; i++)
            {
                if (bCancel == false)
                {
                    Cross_dissolving(i);
                }
                else
                {
                    btnRun_flag = true; // 実行中の処理が終わってからボタンを押せるようにする
                    break;
                }
                cd_counter = i;
            }
            frame_img[0] = src_img;
            frame_img[10] = dst_img;
            thread.Abort();
        }

        // 実行キャンセル
        private void btnCancel_Click(object sender, EventArgs e)
        {
            bCancel = true;
            StatusProgressBar.Value = 0;
            lblStatus1.Text = "Stop  ";
            lblStatus2.Text = "";
            gbMorphingLevel.Enabled = false;
        }

        // 画像の保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = SaveImageFilter;
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.Title = "Select Save";

            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                // 書き出しファイル位置
                CurImageName = saveFileDialog1.FileName;

                // ピクチャーボックスの画像を保存
                pictureBox2.Image.Save(CurImageName);
 
                // ファイル名取得
                string[] splitText1;
                splitText1 = CurImageName.Replace("\\", "/").Split('/');

                // 保存ディレクトリの取得
                string directory_path = "";
                for (int i = 0; i < splitText1.Count() - 1; i++)
                {
                    directory_path = directory_path + splitText1[i] + "\\";
                }

                // 保存ファイル名の取得
                string save_filename = splitText1[splitText1.Count() - 1];
                string[] splitText2;
                splitText2 = save_filename.Split('.');
                save_extension_str = splitText2[splitText2.Count() - 1];
                save_filename_str = splitText2[splitText2.Count() - 2];
                if (save_filename_str.Length <= 0)
                {
                    save_filename_str = "SaveFilename";
                }

                // ディレクトリの作成
                //string read_filename = read_filename_str + "." + read_extension_str; // 読み込みファイル名
                Directory.CreateDirectory(directory_path + read_filename_str);
                for (int i = 0; i < 11; i++)
                {
                    frame_img[i].Save(directory_path + read_filename_str + "\\" + save_filename_str 
                        + "_" + i.ToString() + "." + save_extension_str);
                }
            }
        }

        // データベースフォルダの選択("Database"を選ぶ)
        private void btnDatabase_Click(object sender, EventArgs e)
        {
            if (btnOpen_flag == true && btnRead_flag == true)
            {
                if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    FolderLocation = folderBrowserDialog1.SelectedPath;

                    // テクスチャ解析ボックスの表示
                    gbTextureAnalysis.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("画像と特徴点を先に入力してください", "入力データの未選択");
            }
        }
        // 化粧顔ベースを自動選択
        private void Select_Person()
        {

        }

        // 印象から化粧顔を選ぶ
        private void Select_Impression()
        {
            if (rbtnImpre1.Checked == true)
            {
                target_image = "sharp.bmp";
                target_pts = "sharp.pts";
            }
            else if (rbtnImpre2.Checked == true)
            {
                target_image = "nopperi.bmp";
                target_pts = "nopperi.pts";
            }
            else if (rbtnImpre3.Checked == true)
            {
                target_image = "hunwari.bmp";
                target_pts = "hunwari.pts";
            }
            else if (rbtnImpre4.Checked == true)
            {
                target_image = "heavy.bmp";
                target_pts = "heavy.txt";
            }
            else if (rbtnImpre5.Checked == true)
            {
                //target_image = "wet.bmp";
                //target_pts = "wet.pts";
                target_image = "mean.jpg";
                target_pts = "mean.pts";
            }
            else if (rbtnImpre6.Checked == true)
            {
                //target_image = "shisaku.bmp";
                //target_pts = "shisaku.pts";
                target_image = "70.jpg";
                target_pts = "70.pts";
            }
            else if (rbtnImpre7.Checked == true)
            {
                target_image = "90.jpg";
                target_pts = "90.pts";
            }
            else if (rbtnImpre8.Checked == true)
            {
                target_image = "100.jpg";
                target_pts = "100.pts";
            }
            else
            {
                MessageBox.Show("印象の内容を選択して下さい", "印象の選択");
            }
            location_image = FolderLocation + "/foundation/"
                + "base" + "/" + target_image;
            location_pts = FolderLocation + "/foundation/"
                + "base" + "/" + target_pts;
            tmp_img = new Bitmap(Image.FromFile(location_image));
        }

        //=== 形状の変形 ===//
        // 変数宣言 //
        private void Transformation_Shape()
        {
            //--- 特徴点取得 ---//
            Array.Resize<Point>(ref database_points, 114);
            string strText = "";
            using (StreamReader sr = new StreamReader(@location_pts))
            {
                strText = sr.ReadToEnd();
            }

            // string.Splitで分割
            string[] splitText1;
            splitText1 = strText.Replace("\r\n", "\n").Split('\n');

            for (int i = 0; i < read_max_point; i++)
            {
                string[] splitText2;
                splitText2 = splitText1[i + pts_property].Split(' ');

                // 値をセット
                database_points[i].X = int.Parse(splitText2[5]);
                database_points[i].Y = int.Parse(splitText2[6]);
            }

            //--- 関連付け ---//
            for (int i = 0; i < 137; i++)
            {
                input_asso[i].Reset();
                database_asso[i].Reset();
            }
            Association();

            //--- アフィン変換 ---//
            for (asso_counter = 0; asso_counter < 137; asso_counter++)
            {
                StartEndPoint();
                AffineTransformation();
            }
        }

        //-- モーフィング処理位置の取得 --//
        // 変数宣言
        int startX, startY;
        int endX, endY;

        private void StartEndPoint()
        {
            startX = iWidth;		// スキャン開始位置:x
            startY = iHeight;		// スキャン開始位置:y
            endX = 0;				// スキャン終了位置:x
            endY = 0;				// スキャン終了位置:y
            for (int i = 0; i < 3; i++)
            {
                if (startX > input_asso[asso_counter].px[i]) startX = input_asso[asso_counter].px[i];
                if (startY > input_asso[asso_counter].py[i]) startY = input_asso[asso_counter].py[i];
                if (endX < input_asso[asso_counter].px[i]) endX = input_asso[asso_counter].px[i];
                if (endY < input_asso[asso_counter].py[i]) endY = input_asso[asso_counter].py[i];
            }
        }

        //-- 入力点の代入 --//
        private void AffineTransformation()
        {
            double x, y;
            double alpha, beta, gamma;	// ベクトルの係数
            double denominator;			// β,γの分母

            // β,γの分母の計算
            denominator = -input_asso[asso_counter].px[1] * input_asso[asso_counter].py[2] +
                input_asso[asso_counter].px[1] * input_asso[asso_counter].py[0] +
                input_asso[asso_counter].px[0] * input_asso[asso_counter].py[2] +
                input_asso[asso_counter].px[2] * input_asso[asso_counter].py[1] -
                input_asso[asso_counter].px[2] * input_asso[asso_counter].py[0] -
                input_asso[asso_counter].px[0] * input_asso[asso_counter].py[1];

            // 画像左上(startX,startY)からスキャン
            for (int j = startY; j < endY; j++)
            {		// for(;iHeight;)
                for (int i = startX; i < endX; i++)
                {	// for(;iWidth;)
                    // ベクトルの各係数を求める Eq:X = ax1 + bx2 + gx3
                    beta = j * input_asso[asso_counter].px[2] - input_asso[asso_counter].px[0] * j -
                        input_asso[asso_counter].px[2] * input_asso[asso_counter].py[0] - input_asso[asso_counter].py[2] * i +
                        input_asso[asso_counter].px[0] * input_asso[asso_counter].py[2] + i * input_asso[asso_counter].py[0];
                    beta = beta / denominator;
                    gamma = i * input_asso[asso_counter].py[1] - i * input_asso[asso_counter].py[0] -
                        input_asso[asso_counter].px[0] * input_asso[asso_counter].py[1] - input_asso[asso_counter].px[1] * j +
                        input_asso[asso_counter].px[1] * input_asso[asso_counter].py[0] + input_asso[asso_counter].px[0] * j;
                    gamma = gamma / denominator;
                    alpha = 1 - (beta + gamma);
                    // 指定した3点内を処理する	[0 <= a,b,g <= 1]
                    if (alpha >= 0 && alpha <= 1 && beta >= 0 && beta <= 1 && gamma >= 0 && gamma <= 1)
                    {
                        // 式の適応
                        x = alpha * database_asso[asso_counter].px[0] + beta * database_asso[asso_counter].px[1] + gamma * database_asso[asso_counter].px[2];
                        y = alpha * database_asso[asso_counter].py[0] + beta * database_asso[asso_counter].py[1] + gamma * database_asso[asso_counter].py[2];

                        // ニアレストネイバー補間
                        if ((int)(x + 0.5) >= 0 && (int)(x + 0.5) < iWidth && (int)(y + 0.5) >= 0 && (int)(y + 0.5) < iHeight)
                        {
                            dst_img.SetPixel(i, j, tmp_img.GetPixel((int)(x + 0.5), (int)(y + 0.5)));
                            mask_img.SetPixel(i, j, tmp_img.GetPixel((int)(x + 0.5), (int)(y + 0.5)));
                        }
                        else
                        {
                            mask_img.SetPixel(i, j, Color.Black);
                        }
                        //}
                        //else
                        //{
                        // バイリニア補間
                        //if (x >= 0 && x < iWidth && y >= 0 && y < iHeight)
                        //      BilinearInterpolation(x, y, i, j);
                        //else
                        //dst_img->SetPixel(i,j, Color::Black);
                        //}
                    }
                }
            }
        }

        //-- 入力点の代入 --//
        private void Substitution(int p1, int p2, int p3)
        {
            // 入力画像の座標
            input_asso[asso_counter].px[0] = input_points[p1].X;
            input_asso[asso_counter].py[0] = input_points[p1].Y;
            input_asso[asso_counter].px[1] = input_points[p2].X;
            input_asso[asso_counter].py[1] = input_points[p2].Y;
            input_asso[asso_counter].px[2] = input_points[p3].X;
            input_asso[asso_counter].py[2] = input_points[p3].Y;

            // データベースの座標
            database_asso[asso_counter].px[0] = database_points[p1].X;
            database_asso[asso_counter].py[0] = database_points[p1].Y;
            database_asso[asso_counter].px[1] = database_points[p2].X;
            database_asso[asso_counter].py[1] = database_points[p2].Y;
            database_asso[asso_counter].px[2] = database_points[p3].X;
            database_asso[asso_counter].py[2] = database_points[p3].Y;

            asso_counter++;
        }

        // 関連付け
        private void Association()
        {
            Substitution(35, 45, 44);
            Substitution(45, 46, 44);
            Substitution(46, 47, 44);
            Substitution(47, 51, 44);
            Substitution(47, 50, 51);
            Substitution(47, 48, 50);
            Substitution(48, 49, 50);
            Substitution(50, 49, 53);
            Substitution(51, 50, 53);
            Substitution(52, 51, 53);
            Substitution(49, 71, 53);
            Substitution(54, 52, 53);
            Substitution(53, 71, 54);
            Substitution(54, 71, 70);
            Substitution(56, 58, 57);
            Substitution(56, 55, 58);
            Substitution(44, 51, 52);
            Substitution(54, 44, 52);
            Substitution(55, 44, 54);
            Substitution(58, 55, 54);
            Substitution(58, 54, 69);
            Substitution(59, 58, 69);
            Substitution(54, 70, 69);
            Substitution(57, 58, 59);
            Substitution(59, 60, 57);
            Substitution(63, 35, 44);
            Substitution(62, 63, 44);
            Substitution(61, 62, 44);
            Substitution(56, 61, 44);
            Substitution(56, 44, 55);
            Substitution(65, 98, 99);
            Substitution(65, 99, 100);
            Substitution(74, 65, 100);
            Substitution(74, 100, 101);
            Substitution(74, 101, 75);
            Substitution(75, 101, 102);
            Substitution(76, 75, 102);
            Substitution(77, 76, 102);
            Substitution(77, 102, 103);
            Substitution(104, 77, 103);
            Substitution(78, 77, 104);
            Substitution(79, 78, 104);
            Substitution(66, 79, 105);
            Substitution(79, 104, 105);
            Substitution(106, 66, 105);
            Substitution(107, 64, 106);
            Substitution(64, 66, 106);
            Substitution(108, 27, 64);
            Substitution(107, 108, 64);
            Substitution(109, 27, 108);
            Substitution(0, 27, 109);
            Substitution(110, 0, 109);
            Substitution(111, 0, 110);
            Substitution(111, 112, 1);
            Substitution(111, 1, 0);
            Substitution(112, 2, 1);
            Substitution(112, 3, 2);
            Substitution(112, 113, 3);
            Substitution(113, 4, 3);
            Substitution(113, 5, 4);
            Substitution(113, 92, 5);
            Substitution(5, 92, 6);
            Substitution(92, 26, 6);
            Substitution(92, 13, 26);
            Substitution(92, 14, 13);
            Substitution(92, 93, 14);
            Substitution(93, 15, 14);
            Substitution(93, 16, 15);
            Substitution(93, 94, 16);
            Substitution(94, 17, 16);
            Substitution(94, 18, 17);
            Substitution(94, 95, 18);
            Substitution(95, 19, 18);
            Substitution(95, 96, 19);
            Substitution(96, 97, 19);
            Substitution(40, 19, 97);
            Substitution(40, 97, 98);
            Substitution(40, 98, 65);
            Substitution(26, 13, 25);
            Substitution(6, 26, 7);
            Substitution(26, 25, 35);
            Substitution(7, 26, 35);
            Substitution(31, 7, 35);
            Substitution(25, 36, 35);
            Substitution(25, 37, 36);
            Substitution(25, 24, 37);
            Substitution(24, 23, 37);
            Substitution(23, 38, 37);
            Substitution(23, 22, 38);
            Substitution(22, 21, 38);
            Substitution(21, 39, 38);
            Substitution(21, 20, 39);
            Substitution(19, 39, 20);
            Substitution(19, 40, 39);
            Substitution(65, 41, 40);
            Substitution(35, 36, 45);
            Substitution(31, 35, 63);
            Substitution(7, 31, 30);
            Substitution(8, 7, 30);
            Substitution(9, 8, 30);
            Substitution(10, 9, 29);
            Substitution(9, 30, 29);
            Substitution(11, 10, 29);
            Substitution(12, 11, 28);
            Substitution(11, 29, 28);
            Substitution(0, 12, 28);
            Substitution(0, 28, 27);
            Substitution(36, 46, 45);
            Substitution(31, 63, 62);
            Substitution(32, 31, 64);
            Substitution(33, 32, 64);
            Substitution(34, 33, 64);
            Substitution(27, 34, 64);
            Substitution(36, 43, 65);
            Substitution(43, 42, 65);
            Substitution(42, 41, 65);
            Substitution(48, 47, 65);
            Substitution(64, 61, 60);
            Substitution(60, 66, 64);
            Substitution(48, 65, 74);
            Substitution(48, 74, 73);
            Substitution(48, 73, 49);
            Substitution(49, 73, 72);
            Substitution(49, 72, 71);
            Substitution(60, 67, 66);
            Substitution(60, 59, 67);
            Substitution(59, 68, 67);
            Substitution(59, 69, 68);
            Substitution(31, 62, 61);
            Substitution(31, 61, 64);
            Substitution(36, 47, 46);
            Substitution(36, 65, 47);
            Substitution(61, 56, 57);
            Substitution(60, 61, 57);
        }

        // クロスディゾルブ
        private void Cross_dissolving(int frame)
        {
            double fraction = (double)frame / (double)frame_all;
            double not_fraction = 1 - fraction;
            
            frame_img[frame] = new Bitmap(iWidth, iHeight);

            for (int j = 0; j < iHeight; j++)
            {
                for (int i = 0; i < iWidth; i++)
                {
                    Color c1 = dst_img.GetPixel(i, j);
                    Color c2 = src_img.GetPixel(i, j);
                    frame_img[frame].SetPixel(i, j, Color.FromArgb(
                        (int)(c1.R * fraction) + (int)(c2.R * not_fraction),
                        (int)(c1.G * fraction) + (int)(c2.G * not_fraction),
                        (int)(c1.B * fraction) + (int)(c2.B * not_fraction)));
                }
            }
        }
        // 表示(0～100%)
        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            txtbValue.Text = (hScrollBar1.Value * 10).ToString() + "%";
            pictureBox2.Image = frame_img[(int)hScrollBar1.Value];
            pictureBox2.Refresh();
        }

        // メニューバー関数
        // File
        private void FileOpen_Click(object sender, EventArgs e)
        {
            btnOpen_Click(sender, e);
        }

        private void FileRead_Click(object sender, EventArgs e)
        {
            btnRead_Click(sender, e);
        }

        private void FileDatabase_Click(object sender, EventArgs e)
        {
            btnDatabase_Click(sender, e);
        }

        private void FileSave_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
        }

        private void FileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayCenter_Click(object sender, EventArgs e)
        {
            WindowToCenter();
        }

    }
}
