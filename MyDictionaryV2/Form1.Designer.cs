namespace MyDictionaryV2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCurrentPageName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelChilfFormDesktop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButtonAdvancedPractice = new FontAwesome.Sharp.IconButton();
            this.iconButtonSimplePractice = new FontAwesome.Sharp.IconButton();
            this.iconButtonMemorization = new FontAwesome.Sharp.IconButton();
            this.iconButtonMinimized = new FontAwesome.Sharp.IconButton();
            this.iconButtonMaxsimumSize = new FontAwesome.Sharp.IconButton();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.iconPictureBoxCurrentPageIcon = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.iconButtonMyWords = new FontAwesome.Sharp.IconButton();
            this.iconButtonMenu = new FontAwesome.Sharp.IconButton();
            this.iconButtonMyProgress = new FontAwesome.Sharp.IconButton();
            this.iconButtonAbout = new FontAwesome.Sharp.IconButton();
            this.iconButtonPracticePage = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelChilfFormDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCurrentPageIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMenu.Controls.Add(this.iconButtonMyWords);
            this.panelMenu.Controls.Add(this.iconButtonMenu);
            this.panelMenu.Controls.Add(this.iconButtonMyProgress);
            this.panelMenu.Controls.Add(this.iconButtonAbout);
            this.panelMenu.Controls.Add(this.iconButtonPracticePage);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 833);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Lavender;
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(250, 80);
            this.panelLogo.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.iconButtonMinimized);
            this.panel1.Controls.Add(this.iconButtonMaxsimumSize);
            this.panel1.Controls.Add(this.iconButtonExit);
            this.panel1.Controls.Add(this.labelCurrentPageName);
            this.panel1.Controls.Add(this.iconPictureBoxCurrentPageIcon);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 80);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // labelCurrentPageName
            // 
            this.labelCurrentPageName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCurrentPageName.AutoSize = true;
            this.labelCurrentPageName.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPageName.ForeColor = System.Drawing.Color.White;
            this.labelCurrentPageName.Location = new System.Drawing.Point(645, 30);
            this.labelCurrentPageName.Name = "labelCurrentPageName";
            this.labelCurrentPageName.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelCurrentPageName.Size = new System.Drawing.Size(169, 51);
            this.labelCurrentPageName.TabIndex = 6;
            this.labelCurrentPageName.Text = "Practice";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.iconButtonAdvancedPractice);
            this.panel2.Controls.Add(this.iconButtonSimplePractice);
            this.panel2.Controls.Add(this.iconButtonMemorization);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(250, 717);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1319, 116);
            this.panel2.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelChilfFormDesktop
            // 
            this.panelChilfFormDesktop.BackColor = System.Drawing.Color.Gainsboro;
            this.panelChilfFormDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChilfFormDesktop.Controls.Add(this.label2);
            this.panelChilfFormDesktop.Controls.Add(this.label1);
            this.panelChilfFormDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChilfFormDesktop.Location = new System.Drawing.Point(250, 80);
            this.panelChilfFormDesktop.Name = "panelChilfFormDesktop";
            this.panelChilfFormDesktop.Size = new System.Drawing.Size(1319, 637);
            this.panelChilfFormDesktop.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(446, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "-הדרך שלך ללמוד אנגלית- ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(271, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(707, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Dictionary";
            // 
            // iconButtonAdvancedPractice
            // 
            this.iconButtonAdvancedPractice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonAdvancedPractice.BackColor = System.Drawing.Color.LightSteelBlue;
            this.iconButtonAdvancedPractice.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconButtonAdvancedPractice.FlatAppearance.BorderSize = 0;
            this.iconButtonAdvancedPractice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.iconButtonAdvancedPractice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAdvancedPractice.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonAdvancedPractice.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAdvancedPractice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iconButtonAdvancedPractice.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.iconButtonAdvancedPractice.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconButtonAdvancedPractice.IconSize = 48;
            this.iconButtonAdvancedPractice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAdvancedPractice.Location = new System.Drawing.Point(830, 6);
            this.iconButtonAdvancedPractice.Name = "iconButtonAdvancedPractice";
            this.iconButtonAdvancedPractice.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.iconButtonAdvancedPractice.Rotation = 0D;
            this.iconButtonAdvancedPractice.Size = new System.Drawing.Size(280, 100);
            this.iconButtonAdvancedPractice.TabIndex = 11;
            this.iconButtonAdvancedPractice.Tag = "";
            this.iconButtonAdvancedPractice.Text = "Advanced Practice";
            this.iconButtonAdvancedPractice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAdvancedPractice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAdvancedPractice.UseVisualStyleBackColor = false;
            this.iconButtonAdvancedPractice.Click += new System.EventHandler(this.iconButtonAdvancedPractice_Click);
            // 
            // iconButtonSimplePractice
            // 
            this.iconButtonSimplePractice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonSimplePractice.BackColor = System.Drawing.Color.LightSteelBlue;
            this.iconButtonSimplePractice.FlatAppearance.BorderSize = 0;
            this.iconButtonSimplePractice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.iconButtonSimplePractice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSimplePractice.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSimplePractice.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSimplePractice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iconButtonSimplePractice.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.iconButtonSimplePractice.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconButtonSimplePractice.IconSize = 48;
            this.iconButtonSimplePractice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSimplePractice.Location = new System.Drawing.Point(530, 6);
            this.iconButtonSimplePractice.Name = "iconButtonSimplePractice";
            this.iconButtonSimplePractice.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.iconButtonSimplePractice.Rotation = 0D;
            this.iconButtonSimplePractice.Size = new System.Drawing.Size(280, 100);
            this.iconButtonSimplePractice.TabIndex = 10;
            this.iconButtonSimplePractice.Text = "Simple Practice";
            this.iconButtonSimplePractice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSimplePractice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSimplePractice.UseVisualStyleBackColor = false;
            this.iconButtonSimplePractice.Click += new System.EventHandler(this.iconButtonSimplePractice_Click);
            // 
            // iconButtonMemorization
            // 
            this.iconButtonMemorization.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonMemorization.BackColor = System.Drawing.Color.LightSteelBlue;
            this.iconButtonMemorization.FlatAppearance.BorderSize = 0;
            this.iconButtonMemorization.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.iconButtonMemorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMemorization.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMemorization.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonMemorization.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iconButtonMemorization.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.iconButtonMemorization.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconButtonMemorization.IconSize = 48;
            this.iconButtonMemorization.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMemorization.Location = new System.Drawing.Point(230, 6);
            this.iconButtonMemorization.Name = "iconButtonMemorization";
            this.iconButtonMemorization.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.iconButtonMemorization.Rotation = 0D;
            this.iconButtonMemorization.Size = new System.Drawing.Size(280, 100);
            this.iconButtonMemorization.TabIndex = 9;
            this.iconButtonMemorization.Text = "Memorization";
            this.iconButtonMemorization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMemorization.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMemorization.UseVisualStyleBackColor = false;
            this.iconButtonMemorization.Click += new System.EventHandler(this.iconButtonMemorization_Click);
            // 
            // iconButtonMinimized
            // 
            this.iconButtonMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMinimized.FlatAppearance.BorderSize = 0;
            this.iconButtonMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMinimized.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMinimized.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonMinimized.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButtonMinimized.IconColor = System.Drawing.Color.White;
            this.iconButtonMinimized.IconSize = 24;
            this.iconButtonMinimized.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMinimized.Location = new System.Drawing.Point(1205, 12);
            this.iconButtonMinimized.Name = "iconButtonMinimized";
            this.iconButtonMinimized.Rotation = 0D;
            this.iconButtonMinimized.Size = new System.Drawing.Size(32, 32);
            this.iconButtonMinimized.TabIndex = 9;
            this.iconButtonMinimized.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMinimized.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMinimized.UseVisualStyleBackColor = true;
            this.iconButtonMinimized.Click += new System.EventHandler(this.iconButtonMinimized_Click);
            // 
            // iconButtonMaxsimumSize
            // 
            this.iconButtonMaxsimumSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMaxsimumSize.FlatAppearance.BorderSize = 0;
            this.iconButtonMaxsimumSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMaxsimumSize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMaxsimumSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonMaxsimumSize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButtonMaxsimumSize.IconColor = System.Drawing.Color.White;
            this.iconButtonMaxsimumSize.IconSize = 24;
            this.iconButtonMaxsimumSize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMaxsimumSize.Location = new System.Drawing.Point(1240, 12);
            this.iconButtonMaxsimumSize.Name = "iconButtonMaxsimumSize";
            this.iconButtonMaxsimumSize.Rotation = 0D;
            this.iconButtonMaxsimumSize.Size = new System.Drawing.Size(32, 32);
            this.iconButtonMaxsimumSize.TabIndex = 8;
            this.iconButtonMaxsimumSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMaxsimumSize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMaxsimumSize.UseVisualStyleBackColor = true;
            this.iconButtonMaxsimumSize.Click += new System.EventHandler(this.iconButtonMaxsimumSize_Click);
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonExit.FlatAppearance.BorderSize = 0;
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButtonExit.IconColor = System.Drawing.Color.White;
            this.iconButtonExit.IconSize = 24;
            this.iconButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExit.Location = new System.Drawing.Point(1275, 12);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Rotation = 0D;
            this.iconButtonExit.Size = new System.Drawing.Size(32, 32);
            this.iconButtonExit.TabIndex = 7;
            this.iconButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExit.UseVisualStyleBackColor = true;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // iconPictureBoxCurrentPageIcon
            // 
            this.iconPictureBoxCurrentPageIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBoxCurrentPageIcon.BackColor = System.Drawing.Color.RoyalBlue;
            this.iconPictureBoxCurrentPageIcon.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconPictureBoxCurrentPageIcon.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxCurrentPageIcon.IconSize = 64;
            this.iconPictureBoxCurrentPageIcon.Location = new System.Drawing.Point(575, 17);
            this.iconPictureBoxCurrentPageIcon.Name = "iconPictureBoxCurrentPageIcon";
            this.iconPictureBoxCurrentPageIcon.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconPictureBoxCurrentPageIcon.Size = new System.Drawing.Size(64, 64);
            this.iconPictureBoxCurrentPageIcon.TabIndex = 5;
            this.iconPictureBoxCurrentPageIcon.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::MyDictionaryV2.Properties.Resources.logoNew;
            this.pictureBox2.Location = new System.Drawing.Point(10, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // iconButtonMyWords
            // 
            this.iconButtonMyWords.FlatAppearance.BorderSize = 0;
            this.iconButtonMyWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMyWords.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMyWords.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonMyWords.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconButtonMyWords.IconColor = System.Drawing.Color.White;
            this.iconButtonMyWords.IconSize = 32;
            this.iconButtonMyWords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMyWords.Location = new System.Drawing.Point(0, 237);
            this.iconButtonMyWords.Name = "iconButtonMyWords";
            this.iconButtonMyWords.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonMyWords.Rotation = 0D;
            this.iconButtonMyWords.Size = new System.Drawing.Size(250, 60);
            this.iconButtonMyWords.TabIndex = 7;
            this.iconButtonMyWords.Text = "     Prvite Words";
            this.iconButtonMyWords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMyWords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMyWords.UseVisualStyleBackColor = true;
            this.iconButtonMyWords.Click += new System.EventHandler(this.iconButtonMyWords_Click);
            // 
            // iconButtonMenu
            // 
            this.iconButtonMenu.FlatAppearance.BorderSize = 0;
            this.iconButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconButtonMenu.IconColor = System.Drawing.Color.White;
            this.iconButtonMenu.IconSize = 48;
            this.iconButtonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMenu.Location = new System.Drawing.Point(0, 0);
            this.iconButtonMenu.Name = "iconButtonMenu";
            this.iconButtonMenu.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.iconButtonMenu.Rotation = 0D;
            this.iconButtonMenu.Size = new System.Drawing.Size(64, 44);
            this.iconButtonMenu.TabIndex = 7;
            this.iconButtonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMenu.UseVisualStyleBackColor = true;
            this.iconButtonMenu.Click += new System.EventHandler(this.iconButtonMenu_Click);
            // 
            // iconButtonMyProgress
            // 
            this.iconButtonMyProgress.FlatAppearance.BorderSize = 0;
            this.iconButtonMyProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMyProgress.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMyProgress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonMyProgress.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.iconButtonMyProgress.IconColor = System.Drawing.Color.White;
            this.iconButtonMyProgress.IconSize = 32;
            this.iconButtonMyProgress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMyProgress.Location = new System.Drawing.Point(0, 167);
            this.iconButtonMyProgress.Name = "iconButtonMyProgress";
            this.iconButtonMyProgress.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonMyProgress.Rotation = 0D;
            this.iconButtonMyProgress.Size = new System.Drawing.Size(250, 60);
            this.iconButtonMyProgress.TabIndex = 8;
            this.iconButtonMyProgress.Text = "     My Progress";
            this.iconButtonMyProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMyProgress.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMyProgress.UseVisualStyleBackColor = true;
            this.iconButtonMyProgress.Click += new System.EventHandler(this.iconButtonMyProgress_Click);
            // 
            // iconButtonAbout
            // 
            this.iconButtonAbout.FlatAppearance.BorderSize = 0;
            this.iconButtonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAbout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonAbout.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.iconButtonAbout.IconColor = System.Drawing.Color.White;
            this.iconButtonAbout.IconSize = 32;
            this.iconButtonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAbout.Location = new System.Drawing.Point(0, 297);
            this.iconButtonAbout.Name = "iconButtonAbout";
            this.iconButtonAbout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonAbout.Rotation = 0D;
            this.iconButtonAbout.Size = new System.Drawing.Size(250, 60);
            this.iconButtonAbout.TabIndex = 9;
            this.iconButtonAbout.Text = "     About ";
            this.iconButtonAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAbout.UseVisualStyleBackColor = true;
            this.iconButtonAbout.Click += new System.EventHandler(this.iconButtonAbout_Click);
            // 
            // iconButtonPracticePage
            // 
            this.iconButtonPracticePage.FlatAppearance.BorderSize = 0;
            this.iconButtonPracticePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPracticePage.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonPracticePage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonPracticePage.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconButtonPracticePage.IconColor = System.Drawing.Color.White;
            this.iconButtonPracticePage.IconSize = 32;
            this.iconButtonPracticePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonPracticePage.Location = new System.Drawing.Point(0, 107);
            this.iconButtonPracticePage.Name = "iconButtonPracticePage";
            this.iconButtonPracticePage.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonPracticePage.Rotation = 0D;
            this.iconButtonPracticePage.Size = new System.Drawing.Size(250, 60);
            this.iconButtonPracticePage.TabIndex = 6;
            this.iconButtonPracticePage.Text = "     Practice";
            this.iconButtonPracticePage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonPracticePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonPracticePage.UseVisualStyleBackColor = true;
            this.iconButtonPracticePage.Click += new System.EventHandler(this.iconButtonPracticePage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1569, 833);
            this.Controls.Add(this.panelChilfFormDesktop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelChilfFormDesktop.ResumeLayout(false);
            this.panelChilfFormDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCurrentPageIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonMyProgress;
        private FontAwesome.Sharp.IconButton iconButtonAbout;
        private FontAwesome.Sharp.IconButton iconButtonPracticePage;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxCurrentPageIcon;
        private System.Windows.Forms.Label labelCurrentPageName;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButtonMemorization;
        private FontAwesome.Sharp.IconButton iconButtonAdvancedPractice;
        private FontAwesome.Sharp.IconButton iconButtonSimplePractice;
        private FontAwesome.Sharp.IconButton iconButtonMenu;
        private System.Windows.Forms.Panel panelChilfFormDesktop;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private FontAwesome.Sharp.IconButton iconButtonMaxsimumSize;
        private FontAwesome.Sharp.IconButton iconButtonMinimized;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton iconButtonMyWords;
    }
}

