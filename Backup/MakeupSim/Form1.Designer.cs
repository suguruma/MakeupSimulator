namespace MakeupSim
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRead = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnDatabase = new System.Windows.Forms.Button();
            this.rbtnImpre1 = new System.Windows.Forms.RadioButton();
            this.rbtnImpre3 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.FileRead = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FileDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.FilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.FilePreview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpContents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.HelpVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gbMorphingLevel = new System.Windows.Forms.GroupBox();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtbValue = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbTextureAnalysis = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnImpre8 = new System.Windows.Forms.RadioButton();
            this.rbtnImpre6 = new System.Windows.Forms.RadioButton();
            this.rbtnImpre4 = new System.Windows.Forms.RadioButton();
            this.rbtnImpre2 = new System.Windows.Forms.RadioButton();
            this.rbtnImpre7 = new System.Windows.Forms.RadioButton();
            this.rbtnImpre5 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatus2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.gbMorphingLevel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gbTextureAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(108, 18);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(96, 23);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Feature Points";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 18);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(96, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Imagefile";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(11, 18);
            this.hScrollBar1.Maximum = 10;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(116, 23);
            this.hScrollBar1.TabIndex = 2;
            this.hScrollBar1.Value = 5;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(6, 18);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(96, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnDatabase
            // 
            this.btnDatabase.Location = new System.Drawing.Point(6, 18);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Size = new System.Drawing.Size(91, 23);
            this.btnDatabase.TabIndex = 2;
            this.btnDatabase.Text = "Database";
            this.btnDatabase.UseVisualStyleBackColor = true;
            this.btnDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // rbtnImpre1
            // 
            this.rbtnImpre1.AutoSize = true;
            this.rbtnImpre1.Checked = true;
            this.rbtnImpre1.Location = new System.Drawing.Point(11, 47);
            this.rbtnImpre1.Name = "rbtnImpre1";
            this.rbtnImpre1.Size = new System.Drawing.Size(60, 16);
            this.rbtnImpre1.TabIndex = 1;
            this.rbtnImpre1.TabStop = true;
            this.rbtnImpre1.Text = "シャープ";
            this.rbtnImpre1.UseVisualStyleBackColor = true;
            // 
            // rbtnImpre3
            // 
            this.rbtnImpre3.AutoSize = true;
            this.rbtnImpre3.Location = new System.Drawing.Point(11, 69);
            this.rbtnImpre3.Name = "rbtnImpre3";
            this.rbtnImpre3.Size = new System.Drawing.Size(53, 16);
            this.rbtnImpre3.TabIndex = 0;
            this.rbtnImpre3.Text = "柔らか";
            this.rbtnImpre3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(6, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(756, 690);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.DisplayMenu,
            this.HelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1016, 26);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileOpen,
            this.FileRead,
            this.toolStripSeparator1,
            this.FileDatabase,
            this.toolStripSeparator2,
            this.FileSave,
            this.toolStripSeparator3,
            this.FilePrint,
            this.FilePreview,
            this.toolStripSeparator4,
            this.FileExit});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(57, 22);
            this.FileMenu.Text = "File(&F)";
            // 
            // FileOpen
            // 
            this.FileOpen.Image = ((System.Drawing.Image)(resources.GetObject("FileOpen.Image")));
            this.FileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileOpen.Name = "FileOpen";
            this.FileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.FileOpen.Size = new System.Drawing.Size(173, 22);
            this.FileOpen.Text = "Open(&O)";
            this.FileOpen.Click += new System.EventHandler(this.FileOpen_Click);
            // 
            // FileRead
            // 
            this.FileRead.Name = "FileRead";
            this.FileRead.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.FileRead.Size = new System.Drawing.Size(173, 22);
            this.FileRead.Text = "Read(&R)";
            this.FileRead.Click += new System.EventHandler(this.FileRead_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // FileDatabase
            // 
            this.FileDatabase.Name = "FileDatabase";
            this.FileDatabase.Size = new System.Drawing.Size(173, 22);
            this.FileDatabase.Text = "Database";
            this.FileDatabase.Click += new System.EventHandler(this.FileDatabase_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // FileSave
            // 
            this.FileSave.Image = ((System.Drawing.Image)(resources.GetObject("FileSave.Image")));
            this.FileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileSave.Name = "FileSave";
            this.FileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.FileSave.Size = new System.Drawing.Size(173, 22);
            this.FileSave.Text = "Save(&S)";
            this.FileSave.Click += new System.EventHandler(this.FileSave_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(170, 6);
            // 
            // FilePrint
            // 
            this.FilePrint.Image = ((System.Drawing.Image)(resources.GetObject("FilePrint.Image")));
            this.FilePrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilePrint.Name = "FilePrint";
            this.FilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.FilePrint.Size = new System.Drawing.Size(173, 22);
            this.FilePrint.Text = "Print(&P)";
            // 
            // FilePreview
            // 
            this.FilePreview.Image = ((System.Drawing.Image)(resources.GetObject("FilePreview.Image")));
            this.FilePreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilePreview.Name = "FilePreview";
            this.FilePreview.Size = new System.Drawing.Size(173, 22);
            this.FilePreview.Text = "Preview";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(170, 6);
            // 
            // FileExit
            // 
            this.FileExit.Name = "FileExit";
            this.FileExit.Size = new System.Drawing.Size(173, 22);
            this.FileExit.Text = "Exit(&E)";
            this.FileExit.Click += new System.EventHandler(this.FileExit_Click);
            // 
            // DisplayMenu
            // 
            this.DisplayMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DisplayCenter});
            this.DisplayMenu.Name = "DisplayMenu";
            this.DisplayMenu.Size = new System.Drawing.Size(80, 22);
            this.DisplayMenu.Text = "Display(&V)";
            // 
            // DisplayCenter
            // 
            this.DisplayCenter.Name = "DisplayCenter";
            this.DisplayCenter.Size = new System.Drawing.Size(165, 22);
            this.DisplayCenter.Text = "Center Window";
            this.DisplayCenter.Click += new System.EventHandler(this.DisplayCenter_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpContents,
            this.toolStripSeparator7,
            this.HelpVersion});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(65, 22);
            this.HelpMenu.Text = "Help(&H)";
            // 
            // HelpContents
            // 
            this.HelpContents.Name = "HelpContents";
            this.HelpContents.Size = new System.Drawing.Size(130, 22);
            this.HelpContents.Text = "Contents";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(127, 6);
            // 
            // HelpVersion
            // 
            this.HelpVersion.Name = "HelpVersion";
            this.HelpVersion.Size = new System.Drawing.Size(130, 22);
            this.HelpVersion.Text = "Version...";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Location = new System.Drawing.Point(2, 27);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 694);
            this.panel6.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.gbMorphingLevel);
            this.panel5.Location = new System.Drawing.Point(15, 590);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 90);
            this.panel5.TabIndex = 3;
            // 
            // gbMorphingLevel
            // 
            this.gbMorphingLevel.BackColor = System.Drawing.SystemColors.Control;
            this.gbMorphingLevel.Controls.Add(this.btnAuto);
            this.gbMorphingLevel.Controls.Add(this.btnSave);
            this.gbMorphingLevel.Controls.Add(this.hScrollBar1);
            this.gbMorphingLevel.Controls.Add(this.txtbValue);
            this.gbMorphingLevel.Enabled = false;
            this.gbMorphingLevel.Location = new System.Drawing.Point(5, 5);
            this.gbMorphingLevel.Name = "gbMorphingLevel";
            this.gbMorphingLevel.Size = new System.Drawing.Size(210, 80);
            this.gbMorphingLevel.TabIndex = 1;
            this.gbMorphingLevel.TabStop = false;
            this.gbMorphingLevel.Text = "Morphing Level";
            // 
            // btnAuto
            // 
            this.btnAuto.Enabled = false;
            this.btnAuto.Location = new System.Drawing.Point(27, 47);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(86, 23);
            this.btnAuto.TabIndex = 5;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(136, 47);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtbValue
            // 
            this.txtbValue.Location = new System.Drawing.Point(136, 22);
            this.txtbValue.Name = "txtbValue";
            this.txtbValue.Size = new System.Drawing.Size(62, 19);
            this.txtbValue.TabIndex = 3;
            this.txtbValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.gbTextureAnalysis);
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Location = new System.Drawing.Point(15, 230);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 346);
            this.panel4.TabIndex = 1;
            // 
            // gbTextureAnalysis
            // 
            this.gbTextureAnalysis.Controls.Add(this.btnCancel);
            this.gbTextureAnalysis.Controls.Add(this.pictureBox3);
            this.gbTextureAnalysis.Controls.Add(this.btnRun);
            this.gbTextureAnalysis.Enabled = false;
            this.gbTextureAnalysis.Location = new System.Drawing.Point(5, 158);
            this.gbTextureAnalysis.Name = "gbTextureAnalysis";
            this.gbTextureAnalysis.Size = new System.Drawing.Size(210, 184);
            this.gbTextureAnalysis.TabIndex = 1;
            this.gbTextureAnalysis.TabStop = false;
            this.gbTextureAnalysis.Text = "Texture Analysis";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(108, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(6, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 133);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnImpre8);
            this.groupBox3.Controls.Add(this.rbtnImpre6);
            this.groupBox3.Controls.Add(this.rbtnImpre4);
            this.groupBox3.Controls.Add(this.rbtnImpre2);
            this.groupBox3.Controls.Add(this.rbtnImpre7);
            this.groupBox3.Controls.Add(this.rbtnImpre5);
            this.groupBox3.Controls.Add(this.btnDatabase);
            this.groupBox3.Controls.Add(this.rbtnImpre3);
            this.groupBox3.Controls.Add(this.rbtnImpre1);
            this.groupBox3.Location = new System.Drawing.Point(5, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 147);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Impression";
            // 
            // rbtnImpre8
            // 
            this.rbtnImpre8.AutoSize = true;
            this.rbtnImpre8.Location = new System.Drawing.Point(110, 113);
            this.rbtnImpre8.Name = "rbtnImpre8";
            this.rbtnImpre8.Size = new System.Drawing.Size(55, 16);
            this.rbtnImpre8.TabIndex = 8;
            this.rbtnImpre8.TabStop = true;
            this.rbtnImpre8.Text = "艶やか";
            this.rbtnImpre8.UseVisualStyleBackColor = true;
            // 
            // rbtnImpre6
            // 
            this.rbtnImpre6.AutoSize = true;
            this.rbtnImpre6.Location = new System.Drawing.Point(110, 91);
            this.rbtnImpre6.Name = "rbtnImpre6";
            this.rbtnImpre6.Size = new System.Drawing.Size(57, 16);
            this.rbtnImpre6.TabIndex = 7;
            this.rbtnImpre6.TabStop = true;
            this.rbtnImpre6.Text = "自然な";
            this.rbtnImpre6.UseVisualStyleBackColor = true;
            // 
            // rbtnImpre4
            // 
            this.rbtnImpre4.AutoSize = true;
            this.rbtnImpre4.Location = new System.Drawing.Point(110, 69);
            this.rbtnImpre4.Name = "rbtnImpre4";
            this.rbtnImpre4.Size = new System.Drawing.Size(66, 16);
            this.rbtnImpre4.TabIndex = 6;
            this.rbtnImpre4.TabStop = true;
            this.rbtnImpre4.Text = "重々しい";
            this.rbtnImpre4.UseVisualStyleBackColor = true;
            // 
            // rbtnImpre2
            // 
            this.rbtnImpre2.AutoSize = true;
            this.rbtnImpre2.Location = new System.Drawing.Point(110, 47);
            this.rbtnImpre2.Name = "rbtnImpre2";
            this.rbtnImpre2.Size = new System.Drawing.Size(59, 16);
            this.rbtnImpre2.TabIndex = 5;
            this.rbtnImpre2.TabStop = true;
            this.rbtnImpre2.Text = "のっぺり";
            this.rbtnImpre2.UseVisualStyleBackColor = true;
            // 
            // rbtnImpre7
            // 
            this.rbtnImpre7.AutoSize = true;
            this.rbtnImpre7.Location = new System.Drawing.Point(11, 113);
            this.rbtnImpre7.Name = "rbtnImpre7";
            this.rbtnImpre7.Size = new System.Drawing.Size(55, 16);
            this.rbtnImpre7.TabIndex = 4;
            this.rbtnImpre7.TabStop = true;
            this.rbtnImpre7.Text = "爽やか";
            this.rbtnImpre7.UseVisualStyleBackColor = true;
            // 
            // rbtnImpre5
            // 
            this.rbtnImpre5.AutoSize = true;
            this.rbtnImpre5.Location = new System.Drawing.Point(11, 91);
            this.rbtnImpre5.Name = "rbtnImpre5";
            this.rbtnImpre5.Size = new System.Drawing.Size(66, 16);
            this.rbtnImpre5.TabIndex = 3;
            this.rbtnImpre5.Text = "瑞々しい";
            this.rbtnImpre5.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(15, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 200);
            this.panel3.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.btnRead);
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Data";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(256, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 694);
            this.panel1.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus1,
            this.StatusProgressBar,
            this.lblStatus2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 723);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1016, 23);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus1
            // 
            this.lblStatus1.Name = "lblStatus1";
            this.lblStatus1.Size = new System.Drawing.Size(46, 18);
            this.lblStatus1.Text = "Status";
            // 
            // StatusProgressBar
            // 
            this.StatusProgressBar.Name = "StatusProgressBar";
            this.StatusProgressBar.Size = new System.Drawing.Size(100, 17);
            // 
            // lblStatus2
            // 
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(0, 18);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 746);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AFIM Make-up Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.gbMorphingLevel.ResumeLayout(false);
            this.gbMorphingLevel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.gbTextureAnalysis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.RadioButton rbtnImpre1;
        private System.Windows.Forms.RadioButton rbtnImpre3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btnDatabase;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem FileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem FileSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem FilePrint;
        private System.Windows.Forms.ToolStripMenuItem FilePreview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem FileExit;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpContents;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem HelpVersion;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbtnImpre5;
        private System.Windows.Forms.TextBox txtbValue;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox gbMorphingLevel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem FileRead;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem FileDatabase;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbTextureAnalysis;
        private System.Windows.Forms.ToolStripMenuItem DisplayMenu;
        private System.Windows.Forms.ToolStripMenuItem DisplayCenter;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar StatusProgressBar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus2;
        private System.Windows.Forms.RadioButton rbtnImpre7;
        private System.Windows.Forms.RadioButton rbtnImpre8;
        private System.Windows.Forms.RadioButton rbtnImpre6;
        private System.Windows.Forms.RadioButton rbtnImpre4;
        private System.Windows.Forms.RadioButton rbtnImpre2;
    }
}

