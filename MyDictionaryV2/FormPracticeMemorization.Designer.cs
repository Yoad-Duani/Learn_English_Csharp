namespace MyDictionaryV2
{
    partial class FormPracticeMemorization
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("מכיר", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("חצי מכיר", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("לא מכיר", 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("לא סומן", 3);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPracticeMemorization));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPage = new System.Windows.Forms.Panel();
            this.labelAllPages = new System.Windows.Forms.Label();
            this.labelAllPagesTitle = new System.Windows.Forms.Label();
            this.labelTitleCurrentPage = new System.Windows.Forms.Label();
            this.labelTitleGroup = new System.Windows.Forms.Label();
            this.iconButtonpreviousPage = new FontAwesome.Sharp.IconButton();
            this.iconButtonNextPage = new FontAwesome.Sharp.IconButton();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.iconButtonMenuFillter = new FontAwesome.Sharp.IconButton();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            this.checkBoxTitleSizeGruop = new System.Windows.Forms.CheckBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.labelSizeGrop = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelTitelFilter = new System.Windows.Forms.Label();
            this.listViewFilterType = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelWordInformation = new System.Windows.Forms.Panel();
            this.panelExampleWordsAndSentences = new System.Windows.Forms.Panel();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.labelNote = new System.Windows.Forms.Label();
            this.buttonAddNote = new System.Windows.Forms.Button();
            this.labelExampleSentences = new System.Windows.Forms.Label();
            this.labelExampleWords = new System.Windows.Forms.Label();
            this.labelExampleSentencesTitle = new System.Windows.Forms.Label();
            this.labelExampleWordsTitle = new System.Windows.Forms.Label();
            this.panelShowWord = new System.Windows.Forms.Panel();
            this.labelWordInEnglish = new System.Windows.Forms.Label();
            this.labelWordInHebrew = new System.Windows.Forms.Label();
            this.iconButtonSpeaker = new FontAwesome.Sharp.IconButton();
            this.iconButtonKnowing = new FontAwesome.Sharp.IconButton();
            this.iconButtonNoKnowing = new FontAwesome.Sharp.IconButton();
            this.iconButtonHalfKnowing = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDGVandWord = new System.Windows.Forms.Panel();
            this.panelDGV1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelPage.SuspendLayout();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panelWordInformation.SuspendLayout();
            this.panelExampleWordsAndSentences.SuspendLayout();
            this.panelShowWord.SuspendLayout();
            this.panelDGVandWord.SuspendLayout();
            this.panelDGV1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle55.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle55.Font = new System.Drawing.Font("Aharoni", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle55.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle55.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle55.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle55;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle56.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle56.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle56.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle56.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle56;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle57.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle57.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle57;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(296, 542);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panelPage);
            this.panel1.Controls.Add(this.panelFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 542);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 95);
            this.panel1.TabIndex = 1;
            // 
            // panelPage
            // 
            this.panelPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPage.BackColor = System.Drawing.Color.Lavender;
            this.panelPage.Controls.Add(this.labelAllPages);
            this.panelPage.Controls.Add(this.labelAllPagesTitle);
            this.panelPage.Controls.Add(this.labelTitleCurrentPage);
            this.panelPage.Controls.Add(this.labelTitleGroup);
            this.panelPage.Controls.Add(this.iconButtonpreviousPage);
            this.panelPage.Controls.Add(this.iconButtonNextPage);
            this.panelPage.Location = new System.Drawing.Point(875, 3);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(400, 40);
            this.panelPage.TabIndex = 2;
            this.panelPage.Visible = false;
            // 
            // labelAllPages
            // 
            this.labelAllPages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAllPages.AutoSize = true;
            this.labelAllPages.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllPages.Location = new System.Drawing.Point(80, 8);
            this.labelAllPages.Name = "labelAllPages";
            this.labelAllPages.Size = new System.Drawing.Size(21, 24);
            this.labelAllPages.TabIndex = 5;
            this.labelAllPages.Text = "1";
            // 
            // labelAllPagesTitle
            // 
            this.labelAllPagesTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAllPagesTitle.AutoSize = true;
            this.labelAllPagesTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllPagesTitle.Location = new System.Drawing.Point(124, 8);
            this.labelAllPagesTitle.Name = "labelAllPagesTitle";
            this.labelAllPagesTitle.Size = new System.Drawing.Size(51, 24);
            this.labelAllPagesTitle.TabIndex = 4;
            this.labelAllPagesTitle.Text = "מתוך";
            // 
            // labelTitleCurrentPage
            // 
            this.labelTitleCurrentPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitleCurrentPage.AutoSize = true;
            this.labelTitleCurrentPage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleCurrentPage.Location = new System.Drawing.Point(230, 8);
            this.labelTitleCurrentPage.Name = "labelTitleCurrentPage";
            this.labelTitleCurrentPage.Size = new System.Drawing.Size(21, 24);
            this.labelTitleCurrentPage.TabIndex = 3;
            this.labelTitleCurrentPage.Text = "1";
            // 
            // labelTitleGroup
            // 
            this.labelTitleGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitleGroup.AutoSize = true;
            this.labelTitleGroup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTitleGroup.Location = new System.Drawing.Point(268, 8);
            this.labelTitleGroup.Name = "labelTitleGroup";
            this.labelTitleGroup.Size = new System.Drawing.Size(56, 24);
            this.labelTitleGroup.TabIndex = 2;
            this.labelTitleGroup.Text = "מקבץ";
            // 
            // iconButtonpreviousPage
            // 
            this.iconButtonpreviousPage.FlatAppearance.BorderSize = 0;
            this.iconButtonpreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonpreviousPage.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonpreviousPage.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleLeft;
            this.iconButtonpreviousPage.IconColor = System.Drawing.Color.Black;
            this.iconButtonpreviousPage.IconSize = 44;
            this.iconButtonpreviousPage.Location = new System.Drawing.Point(3, 3);
            this.iconButtonpreviousPage.Name = "iconButtonpreviousPage";
            this.iconButtonpreviousPage.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconButtonpreviousPage.Rotation = 0D;
            this.iconButtonpreviousPage.Size = new System.Drawing.Size(45, 34);
            this.iconButtonpreviousPage.TabIndex = 1;
            this.iconButtonpreviousPage.UseVisualStyleBackColor = true;
            this.iconButtonpreviousPage.Click += new System.EventHandler(this.iconButtonpreviousPage_Click);
            // 
            // iconButtonNextPage
            // 
            this.iconButtonNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonNextPage.FlatAppearance.BorderSize = 0;
            this.iconButtonNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonNextPage.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonNextPage.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleRight;
            this.iconButtonNextPage.IconColor = System.Drawing.Color.Black;
            this.iconButtonNextPage.IconSize = 44;
            this.iconButtonNextPage.Location = new System.Drawing.Point(350, 3);
            this.iconButtonNextPage.Name = "iconButtonNextPage";
            this.iconButtonNextPage.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconButtonNextPage.Rotation = 0D;
            this.iconButtonNextPage.Size = new System.Drawing.Size(47, 34);
            this.iconButtonNextPage.TabIndex = 0;
            this.iconButtonNextPage.UseVisualStyleBackColor = true;
            this.iconButtonNextPage.Click += new System.EventHandler(this.iconButtonNextPage_Click);
            // 
            // panelFilter
            // 
            this.panelFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFilter.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilter.Controls.Add(this.iconButtonMenuFillter);
            this.panelFilter.Controls.Add(this.buttonClearFilter);
            this.panelFilter.Controls.Add(this.checkBoxTitleSizeGruop);
            this.panelFilter.Controls.Add(this.buttonFilter);
            this.panelFilter.Controls.Add(this.labelSizeGrop);
            this.panelFilter.Controls.Add(this.trackBar1);
            this.panelFilter.Controls.Add(this.labelTitelFilter);
            this.panelFilter.Controls.Add(this.listViewFilterType);
            this.panelFilter.Location = new System.Drawing.Point(899, 65);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(600, 150);
            this.panelFilter.TabIndex = 1;
            // 
            // iconButtonMenuFillter
            // 
            this.iconButtonMenuFillter.FlatAppearance.BorderSize = 0;
            this.iconButtonMenuFillter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMenuFillter.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMenuFillter.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconButtonMenuFillter.IconColor = System.Drawing.Color.Black;
            this.iconButtonMenuFillter.IconSize = 32;
            this.iconButtonMenuFillter.Location = new System.Drawing.Point(3, 1);
            this.iconButtonMenuFillter.Name = "iconButtonMenuFillter";
            this.iconButtonMenuFillter.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.iconButtonMenuFillter.Rotation = 0D;
            this.iconButtonMenuFillter.Size = new System.Drawing.Size(34, 28);
            this.iconButtonMenuFillter.TabIndex = 8;
            this.iconButtonMenuFillter.UseVisualStyleBackColor = false;
            this.iconButtonMenuFillter.Click += new System.EventHandler(this.iconButtonMenuFillter_Click);
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonClearFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearFilter.FlatAppearance.BorderSize = 0;
            this.buttonClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonClearFilter.ForeColor = System.Drawing.Color.Lavender;
            this.buttonClearFilter.Location = new System.Drawing.Point(3, 100);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(94, 40);
            this.buttonClearFilter.TabIndex = 7;
            this.buttonClearFilter.Text = "בטל סינון";
            this.buttonClearFilter.UseVisualStyleBackColor = false;
            this.buttonClearFilter.Click += new System.EventHandler(this.buttonClearFilter_Click);
            // 
            // checkBoxTitleSizeGruop
            // 
            this.checkBoxTitleSizeGruop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxTitleSizeGruop.AutoSize = true;
            this.checkBoxTitleSizeGruop.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTitleSizeGruop.Location = new System.Drawing.Point(203, 40);
            this.checkBoxTitleSizeGruop.Name = "checkBoxTitleSizeGruop";
            this.checkBoxTitleSizeGruop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxTitleSizeGruop.Size = new System.Drawing.Size(80, 28);
            this.checkBoxTitleSizeGruop.TabIndex = 6;
            this.checkBoxTitleSizeGruop.Text = "מקבץ";
            this.checkBoxTitleSizeGruop.UseVisualStyleBackColor = true;
            this.checkBoxTitleSizeGruop.CheckedChanged += new System.EventHandler(this.checkBoxTitleSizeGruop_CheckedChanged);
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilter.FlatAppearance.BorderSize = 0;
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFilter.ForeColor = System.Drawing.Color.Lavender;
            this.buttonFilter.Location = new System.Drawing.Point(3, 54);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(94, 40);
            this.buttonFilter.TabIndex = 5;
            this.buttonFilter.Text = "החל סינון";
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // labelSizeGrop
            // 
            this.labelSizeGrop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSizeGrop.AutoSize = true;
            this.labelSizeGrop.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSizeGrop.Location = new System.Drawing.Point(232, 116);
            this.labelSizeGrop.Name = "labelSizeGrop";
            this.labelSizeGrop.Size = new System.Drawing.Size(20, 24);
            this.labelSizeGrop.TabIndex = 4;
            this.labelSizeGrop.Text = "7";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trackBar1.Location = new System.Drawing.Point(170, 73);
            this.trackBar1.Maximum = 8;
            this.trackBar1.Minimum = 4;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(154, 40);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 4;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // labelTitelFilter
            // 
            this.labelTitelFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitelFilter.AutoSize = true;
            this.labelTitelFilter.Font = new System.Drawing.Font("Aharoni", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTitelFilter.Location = new System.Drawing.Point(221, 0);
            this.labelTitelFilter.Name = "labelTitelFilter";
            this.labelTitelFilter.Size = new System.Drawing.Size(118, 32);
            this.labelTitelFilter.TabIndex = 1;
            this.labelTitelFilter.Text = "בחר סינון";
            // 
            // listViewFilterType
            // 
            this.listViewFilterType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFilterType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listViewFilterType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewFilterType.CheckBoxes = true;
            this.listViewFilterType.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listViewFilterType.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            this.listViewFilterType.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listViewFilterType.Location = new System.Drawing.Point(430, 3);
            this.listViewFilterType.Name = "listViewFilterType";
            this.listViewFilterType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listViewFilterType.RightToLeftLayout = true;
            this.listViewFilterType.Scrollable = false;
            this.listViewFilterType.Size = new System.Drawing.Size(157, 142);
            this.listViewFilterType.SmallImageList = this.imageList1;
            this.listViewFilterType.TabIndex = 0;
            this.listViewFilterType.UseCompatibleStateImageBehavior = false;
            this.listViewFilterType.View = System.Windows.Forms.View.SmallIcon;
            this.listViewFilterType.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listViewFilterType_ItemCheck);
            this.listViewFilterType.SelectedIndexChanged += new System.EventHandler(this.listViewFilterType_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "smile green.png");
            this.imageList1.Images.SetKeyName(1, "neutral_50px yyyyy.png");
            this.imageList1.Images.SetKeyName(2, "sad_48px.png");
            this.imageList1.Images.SetKeyName(3, "icons8_happy_white_48.png");
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelWordInformation
            // 
            this.panelWordInformation.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelWordInformation.Controls.Add(this.panelExampleWordsAndSentences);
            this.panelWordInformation.Controls.Add(this.panelShowWord);
            this.panelWordInformation.Controls.Add(this.iconButtonSpeaker);
            this.panelWordInformation.Controls.Add(this.iconButtonKnowing);
            this.panelWordInformation.Controls.Add(this.iconButtonNoKnowing);
            this.panelWordInformation.Controls.Add(this.iconButtonHalfKnowing);
            this.panelWordInformation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelWordInformation.Location = new System.Drawing.Point(0, 0);
            this.panelWordInformation.Name = "panelWordInformation";
            this.panelWordInformation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelWordInformation.Size = new System.Drawing.Size(923, 542);
            this.panelWordInformation.TabIndex = 2;
            // 
            // panelExampleWordsAndSentences
            // 
            this.panelExampleWordsAndSentences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExampleWordsAndSentences.BackColor = System.Drawing.Color.Lavender;
            this.panelExampleWordsAndSentences.Controls.Add(this.textBoxNote);
            this.panelExampleWordsAndSentences.Controls.Add(this.labelNote);
            this.panelExampleWordsAndSentences.Controls.Add(this.buttonAddNote);
            this.panelExampleWordsAndSentences.Controls.Add(this.labelExampleSentences);
            this.panelExampleWordsAndSentences.Controls.Add(this.labelExampleWords);
            this.panelExampleWordsAndSentences.Controls.Add(this.labelExampleSentencesTitle);
            this.panelExampleWordsAndSentences.Controls.Add(this.labelExampleWordsTitle);
            this.panelExampleWordsAndSentences.Location = new System.Drawing.Point(12, 150);
            this.panelExampleWordsAndSentences.Name = "panelExampleWordsAndSentences";
            this.panelExampleWordsAndSentences.Size = new System.Drawing.Size(901, 312);
            this.panelExampleWordsAndSentences.TabIndex = 14;
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(598, 193);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(300, 20);
            this.textBoxNote.TabIndex = 18;
            this.textBoxNote.Enter += new System.EventHandler(this.textBoxNote_Enter);
            // 
            // labelNote
            // 
            this.labelNote.Location = new System.Drawing.Point(401, 262);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(500, 50);
            this.labelNote.TabIndex = 17;
            this.labelNote.Text = "אין הערה";
            // 
            // buttonAddNote
            // 
            this.buttonAddNote.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonAddNote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAddNote.FlatAppearance.BorderSize = 0;
            this.buttonAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAddNote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddNote.Location = new System.Drawing.Point(771, 230);
            this.buttonAddNote.Name = "buttonAddNote";
            this.buttonAddNote.Size = new System.Drawing.Size(105, 30);
            this.buttonAddNote.TabIndex = 16;
            this.buttonAddNote.Text = "שמור";
            this.buttonAddNote.UseVisualStyleBackColor = false;
            this.buttonAddNote.Click += new System.EventHandler(this.buttonAddNote_Click);
            // 
            // labelExampleSentences
            // 
            this.labelExampleSentences.AutoSize = true;
            this.labelExampleSentences.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExampleSentences.Location = new System.Drawing.Point(51, 75);
            this.labelExampleSentences.MaximumSize = new System.Drawing.Size(370, 0);
            this.labelExampleSentences.Name = "labelExampleSentences";
            this.labelExampleSentences.Size = new System.Drawing.Size(164, 22);
            this.labelExampleSentences.TabIndex = 15;
            this.labelExampleSentences.Text = "אין משפטים לדוגמא";
            // 
            // labelExampleWords
            // 
            this.labelExampleWords.AutoSize = true;
            this.labelExampleWords.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExampleWords.Location = new System.Drawing.Point(51, 15);
            this.labelExampleWords.Name = "labelExampleWords";
            this.labelExampleWords.Size = new System.Drawing.Size(143, 22);
            this.labelExampleWords.TabIndex = 14;
            this.labelExampleWords.Text = "אין מילים קשורות";
            // 
            // labelExampleSentencesTitle
            // 
            this.labelExampleSentencesTitle.AutoSize = true;
            this.labelExampleSentencesTitle.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExampleSentencesTitle.Location = new System.Drawing.Point(570, 75);
            this.labelExampleSentencesTitle.Name = "labelExampleSentencesTitle";
            this.labelExampleSentencesTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelExampleSentencesTitle.Size = new System.Drawing.Size(150, 22);
            this.labelExampleSentencesTitle.TabIndex = 13;
            this.labelExampleSentencesTitle.Text = "משפטים לדוגמא :";
            // 
            // labelExampleWordsTitle
            // 
            this.labelExampleWordsTitle.AutoSize = true;
            this.labelExampleWordsTitle.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExampleWordsTitle.Location = new System.Drawing.Point(591, 15);
            this.labelExampleWordsTitle.Name = "labelExampleWordsTitle";
            this.labelExampleWordsTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelExampleWordsTitle.Size = new System.Drawing.Size(129, 22);
            this.labelExampleWordsTitle.TabIndex = 12;
            this.labelExampleWordsTitle.Text = "מילים קשורות :";
            // 
            // panelShowWord
            // 
            this.panelShowWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelShowWord.BackColor = System.Drawing.Color.Lavender;
            this.panelShowWord.Controls.Add(this.labelWordInEnglish);
            this.panelShowWord.Controls.Add(this.labelWordInHebrew);
            this.panelShowWord.Location = new System.Drawing.Point(12, 62);
            this.panelShowWord.Name = "panelShowWord";
            this.panelShowWord.Size = new System.Drawing.Size(901, 54);
            this.panelShowWord.TabIndex = 13;
            // 
            // labelWordInEnglish
            // 
            this.labelWordInEnglish.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWordInEnglish.Location = new System.Drawing.Point(3, 4);
            this.labelWordInEnglish.Name = "labelWordInEnglish";
            this.labelWordInEnglish.Size = new System.Drawing.Size(335, 46);
            this.labelWordInEnglish.TabIndex = 11;
            this.labelWordInEnglish.Text = "label1";
            this.labelWordInEnglish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWordInHebrew
            // 
            this.labelWordInHebrew.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelWordInHebrew.Location = new System.Drawing.Point(344, 4);
            this.labelWordInHebrew.MaximumSize = new System.Drawing.Size(530, 46);
            this.labelWordInHebrew.Name = "labelWordInHebrew";
            this.labelWordInHebrew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelWordInHebrew.Size = new System.Drawing.Size(530, 46);
            this.labelWordInHebrew.TabIndex = 12;
            this.labelWordInHebrew.Text = "label2";
            this.labelWordInHebrew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelWordInHebrew.Click += new System.EventHandler(this.labelWordInHebrew_Click);
            // 
            // iconButtonSpeaker
            // 
            this.iconButtonSpeaker.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonSpeaker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonSpeaker.FlatAppearance.BorderSize = 0;
            this.iconButtonSpeaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSpeaker.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSpeaker.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonSpeaker.IconChar = FontAwesome.Sharp.IconChar.VolumeUp;
            this.iconButtonSpeaker.IconColor = System.Drawing.Color.Lavender;
            this.iconButtonSpeaker.IconSize = 48;
            this.iconButtonSpeaker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSpeaker.Location = new System.Drawing.Point(12, 3);
            this.iconButtonSpeaker.Name = "iconButtonSpeaker";
            this.iconButtonSpeaker.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconButtonSpeaker.Rotation = 0D;
            this.iconButtonSpeaker.Size = new System.Drawing.Size(53, 47);
            this.iconButtonSpeaker.TabIndex = 10;
            this.iconButtonSpeaker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSpeaker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSpeaker.UseVisualStyleBackColor = false;
            this.iconButtonSpeaker.Click += new System.EventHandler(this.iconButtonSpeaker_Click);
            // 
            // iconButtonKnowing
            // 
            this.iconButtonKnowing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonKnowing.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonKnowing.BackgroundImage = global::MyDictionaryV2.Properties.Resources.smile_green;
            this.iconButtonKnowing.FlatAppearance.BorderSize = 0;
            this.iconButtonKnowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonKnowing.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonKnowing.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonKnowing.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonKnowing.IconColor = System.Drawing.Color.Green;
            this.iconButtonKnowing.IconSize = 48;
            this.iconButtonKnowing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonKnowing.Location = new System.Drawing.Point(526, 475);
            this.iconButtonKnowing.Name = "iconButtonKnowing";
            this.iconButtonKnowing.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconButtonKnowing.Rotation = 0D;
            this.iconButtonKnowing.Size = new System.Drawing.Size(50, 47);
            this.iconButtonKnowing.TabIndex = 10;
            this.iconButtonKnowing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonKnowing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonKnowing.UseVisualStyleBackColor = false;
            this.iconButtonKnowing.Click += new System.EventHandler(this.iconButtonKnowing_Click);
            // 
            // iconButtonNoKnowing
            // 
            this.iconButtonNoKnowing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonNoKnowing.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonNoKnowing.BackgroundImage = global::MyDictionaryV2.Properties.Resources.sad_48px;
            this.iconButtonNoKnowing.FlatAppearance.BorderSize = 0;
            this.iconButtonNoKnowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonNoKnowing.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonNoKnowing.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonNoKnowing.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonNoKnowing.IconColor = System.Drawing.Color.Black;
            this.iconButtonNoKnowing.IconSize = 48;
            this.iconButtonNoKnowing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonNoKnowing.Location = new System.Drawing.Point(300, 475);
            this.iconButtonNoKnowing.Name = "iconButtonNoKnowing";
            this.iconButtonNoKnowing.Rotation = 0D;
            this.iconButtonNoKnowing.Size = new System.Drawing.Size(50, 47);
            this.iconButtonNoKnowing.TabIndex = 12;
            this.iconButtonNoKnowing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonNoKnowing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonNoKnowing.UseVisualStyleBackColor = false;
            this.iconButtonNoKnowing.Click += new System.EventHandler(this.iconButtonNoKnowing_Click);
            // 
            // iconButtonHalfKnowing
            // 
            this.iconButtonHalfKnowing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonHalfKnowing.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonHalfKnowing.BackgroundImage = global::MyDictionaryV2.Properties.Resources.neutral_50px_yyyyy;
            this.iconButtonHalfKnowing.FlatAppearance.BorderSize = 0;
            this.iconButtonHalfKnowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHalfKnowing.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonHalfKnowing.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonHalfKnowing.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonHalfKnowing.IconColor = System.Drawing.Color.Black;
            this.iconButtonHalfKnowing.IconSize = 48;
            this.iconButtonHalfKnowing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHalfKnowing.Location = new System.Drawing.Point(418, 475);
            this.iconButtonHalfKnowing.Name = "iconButtonHalfKnowing";
            this.iconButtonHalfKnowing.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconButtonHalfKnowing.Rotation = 0D;
            this.iconButtonHalfKnowing.Size = new System.Drawing.Size(50, 47);
            this.iconButtonHalfKnowing.TabIndex = 11;
            this.iconButtonHalfKnowing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHalfKnowing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonHalfKnowing.UseVisualStyleBackColor = false;
            this.iconButtonHalfKnowing.Click += new System.EventHandler(this.iconButtonHalfKnowing_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1269, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(50, 542);
            this.panel2.TabIndex = 4;
            // 
            // panelDGVandWord
            // 
            this.panelDGVandWord.Controls.Add(this.panelDGV1);
            this.panelDGVandWord.Controls.Add(this.panel4);
            this.panelDGVandWord.Controls.Add(this.panelWordInformation);
            this.panelDGVandWord.Controls.Add(this.panel2);
            this.panelDGVandWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDGVandWord.Location = new System.Drawing.Point(0, 0);
            this.panelDGVandWord.Name = "panelDGVandWord";
            this.panelDGVandWord.Size = new System.Drawing.Size(1319, 542);
            this.panelDGVandWord.TabIndex = 4;
            // 
            // panelDGV1
            // 
            this.panelDGV1.Controls.Add(this.dataGridView1);
            this.panelDGV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDGV1.Location = new System.Drawing.Point(973, 0);
            this.panelDGV1.Name = "panelDGV1";
            this.panelDGV1.Size = new System.Drawing.Size(296, 542);
            this.panelDGV1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(923, 0);
            this.panel4.Name = "panel4";
            this.panel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel4.Size = new System.Drawing.Size(50, 542);
            this.panel4.TabIndex = 5;
            // 
            // FormPracticeMemorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1319, 637);
            this.Controls.Add(this.panelDGVandWord);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPracticeMemorization";
            this.Text = "FormPracticeMemorization";
            this.Load += new System.EventHandler(this.FormPracticeMemorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelPage.ResumeLayout(false);
            this.panelPage.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panelWordInformation.ResumeLayout(false);
            this.panelExampleWordsAndSentences.ResumeLayout(false);
            this.panelExampleWordsAndSentences.PerformLayout();
            this.panelShowWord.ResumeLayout(false);
            this.panelDGVandWord.ResumeLayout(false);
            this.panelDGV1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listViewFilterType;
        private System.Windows.Forms.Label labelTitelFilter;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelSizeGrop;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.CheckBox checkBoxTitleSizeGruop;
        private System.Windows.Forms.Button buttonClearFilter;
        private System.Windows.Forms.Panel panelPage;
        private FontAwesome.Sharp.IconButton iconButtonpreviousPage;
        private FontAwesome.Sharp.IconButton iconButtonNextPage;
        private System.Windows.Forms.Label labelAllPages;
        private System.Windows.Forms.Label labelAllPagesTitle;
        private System.Windows.Forms.Label labelTitleCurrentPage;
        private System.Windows.Forms.Label labelTitleGroup;
        private FontAwesome.Sharp.IconButton iconButtonMenuFillter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelDGVandWord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelWordInformation;
        private System.Windows.Forms.Panel panelExampleWordsAndSentences;
        private System.Windows.Forms.Label labelExampleSentences;
        private System.Windows.Forms.Label labelExampleWords;
        private System.Windows.Forms.Label labelExampleSentencesTitle;
        private System.Windows.Forms.Label labelExampleWordsTitle;
        private System.Windows.Forms.Panel panelShowWord;
        private System.Windows.Forms.Label labelWordInEnglish;
        private System.Windows.Forms.Label labelWordInHebrew;
        private FontAwesome.Sharp.IconButton iconButtonSpeaker;
        private FontAwesome.Sharp.IconButton iconButtonKnowing;
        private FontAwesome.Sharp.IconButton iconButtonNoKnowing;
        private FontAwesome.Sharp.IconButton iconButtonHalfKnowing;
        private System.Windows.Forms.Panel panelDGV1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Button buttonAddNote;
    }
}