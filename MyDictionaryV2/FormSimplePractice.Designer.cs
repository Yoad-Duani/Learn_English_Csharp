namespace MyDictionaryV2
{
    partial class FormSimplePractice
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("מכיר", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("חצי מכיר", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("לא מכיר", 2);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSimplePractice));
            this.labelTheWord = new System.Windows.Forms.Label();
            this.buttonKnow = new System.Windows.Forms.Button();
            this.buttonDontKnow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUnfilter = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.listViewFilterType = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelTitle2 = new System.Windows.Forms.Label();
            this.labelWordsLeft = new System.Windows.Forms.Label();
            this.labelTitle1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonNextWord = new System.Windows.Forms.Button();
            this.panelTranslating = new System.Windows.Forms.Panel();
            this.labelWordHebrew = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTitleQ = new System.Windows.Forms.Label();
            this.iconButtonNoKnowing = new FontAwesome.Sharp.IconButton();
            this.iconButtonHalfKnowing = new FontAwesome.Sharp.IconButton();
            this.iconButtonKnowing = new FontAwesome.Sharp.IconButton();
            this.iconButtonSpeaker = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTranslating.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTheWord
            // 
            this.labelTheWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTheWord.Font = new System.Drawing.Font("Modern No. 20", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTheWord.Location = new System.Drawing.Point(350, 109);
            this.labelTheWord.Name = "labelTheWord";
            this.labelTheWord.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTheWord.Size = new System.Drawing.Size(419, 129);
            this.labelTheWord.TabIndex = 0;
            this.labelTheWord.Text = "word";
            this.labelTheWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKnow
            // 
            this.buttonKnow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonKnow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(189)))), ((int)(((byte)(221)))));
            this.buttonKnow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKnow.FlatAppearance.BorderSize = 0;
            this.buttonKnow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKnow.Font = new System.Drawing.Font("Aharoni", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonKnow.ForeColor = System.Drawing.Color.White;
            this.buttonKnow.Location = new System.Drawing.Point(580, 487);
            this.buttonKnow.Name = "buttonKnow";
            this.buttonKnow.Size = new System.Drawing.Size(170, 50);
            this.buttonKnow.TabIndex = 1;
            this.buttonKnow.Text = "מכיר";
            this.buttonKnow.UseVisualStyleBackColor = false;
            this.buttonKnow.Click += new System.EventHandler(this.buttonKnow_Click);
            // 
            // buttonDontKnow
            // 
            this.buttonDontKnow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDontKnow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(189)))), ((int)(((byte)(221)))));
            this.buttonDontKnow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDontKnow.FlatAppearance.BorderSize = 0;
            this.buttonDontKnow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDontKnow.Font = new System.Drawing.Font("Aharoni", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonDontKnow.ForeColor = System.Drawing.Color.White;
            this.buttonDontKnow.Location = new System.Drawing.Point(310, 487);
            this.buttonDontKnow.Name = "buttonDontKnow";
            this.buttonDontKnow.Size = new System.Drawing.Size(170, 50);
            this.buttonDontKnow.TabIndex = 2;
            this.buttonDontKnow.Text = "לא מכיר";
            this.buttonDontKnow.UseVisualStyleBackColor = false;
            this.buttonDontKnow.Click += new System.EventHandler(this.buttonDontKnow_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(189)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.buttonUnfilter);
            this.panel1.Controls.Add(this.buttonFilter);
            this.panel1.Controls.Add(this.listViewFilterType);
            this.panel1.Controls.Add(this.labelTitle2);
            this.panel1.Controls.Add(this.labelWordsLeft);
            this.panel1.Controls.Add(this.labelTitle1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1119, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 637);
            this.panel1.TabIndex = 3;
            // 
            // buttonUnfilter
            // 
            this.buttonUnfilter.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonUnfilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUnfilter.Enabled = false;
            this.buttonUnfilter.FlatAppearance.BorderSize = 0;
            this.buttonUnfilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnfilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonUnfilter.ForeColor = System.Drawing.Color.Lavender;
            this.buttonUnfilter.Location = new System.Drawing.Point(58, 235);
            this.buttonUnfilter.Name = "buttonUnfilter";
            this.buttonUnfilter.Size = new System.Drawing.Size(94, 40);
            this.buttonUnfilter.TabIndex = 7;
            this.buttonUnfilter.Text = "בטל סינון";
            this.buttonUnfilter.UseVisualStyleBackColor = false;
            this.buttonUnfilter.Click += new System.EventHandler(this.buttonUnfilter_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilter.FlatAppearance.BorderSize = 0;
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFilter.ForeColor = System.Drawing.Color.Lavender;
            this.buttonFilter.Location = new System.Drawing.Point(58, 189);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(94, 40);
            this.buttonFilter.TabIndex = 6;
            this.buttonFilter.Text = "החל סינון";
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
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
            this.listViewFilterType.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listViewFilterType.Location = new System.Drawing.Point(31, 63);
            this.listViewFilterType.Name = "listViewFilterType";
            this.listViewFilterType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listViewFilterType.RightToLeftLayout = true;
            this.listViewFilterType.Scrollable = false;
            this.listViewFilterType.Size = new System.Drawing.Size(157, 107);
            this.listViewFilterType.SmallImageList = this.imageList1;
            this.listViewFilterType.TabIndex = 3;
            this.listViewFilterType.UseCompatibleStateImageBehavior = false;
            this.listViewFilterType.View = System.Windows.Forms.View.SmallIcon;
            this.listViewFilterType.SelectedIndexChanged += new System.EventHandler(this.listViewFilterType_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "smile green.png");
            this.imageList1.Images.SetKeyName(1, "neutral_50px yyyyy.png");
            this.imageList1.Images.SetKeyName(2, "sad_48px.png");
            // 
            // labelTitle2
            // 
            this.labelTitle2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle2.AutoSize = true;
            this.labelTitle2.Font = new System.Drawing.Font("Aharoni", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTitle2.Location = new System.Drawing.Point(5, 538);
            this.labelTitle2.Name = "labelTitle2";
            this.labelTitle2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTitle2.Size = new System.Drawing.Size(67, 28);
            this.labelTitle2.TabIndex = 2;
            this.labelTitle2.Text = "מילים";
            // 
            // labelWordsLeft
            // 
            this.labelWordsLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWordsLeft.Font = new System.Drawing.Font("Aharoni", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelWordsLeft.Location = new System.Drawing.Point(68, 538);
            this.labelWordsLeft.Name = "labelWordsLeft";
            this.labelWordsLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelWordsLeft.Size = new System.Drawing.Size(62, 28);
            this.labelWordsLeft.TabIndex = 1;
            this.labelWordsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle1
            // 
            this.labelTitle1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle1.AutoSize = true;
            this.labelTitle1.Font = new System.Drawing.Font("Aharoni", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTitle1.Location = new System.Drawing.Point(125, 538);
            this.labelTitle1.Name = "labelTitle1";
            this.labelTitle1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTitle1.Size = new System.Drawing.Size(69, 28);
            this.labelTitle1.TabIndex = 0;
            this.labelTitle1.Text = "נותרו:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonNextWord);
            this.panel2.Controls.Add(this.panelTranslating);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.labelTheWord);
            this.panel2.Controls.Add(this.buttonKnow);
            this.panel2.Controls.Add(this.buttonDontKnow);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 637);
            this.panel2.TabIndex = 5;
            // 
            // buttonNextWord
            // 
            this.buttonNextWord.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNextWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(189)))), ((int)(((byte)(221)))));
            this.buttonNextWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNextWord.FlatAppearance.BorderSize = 0;
            this.buttonNextWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextWord.Font = new System.Drawing.Font("Aharoni", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonNextWord.ForeColor = System.Drawing.Color.White;
            this.buttonNextWord.Location = new System.Drawing.Point(449, 565);
            this.buttonNextWord.Name = "buttonNextWord";
            this.buttonNextWord.Size = new System.Drawing.Size(170, 50);
            this.buttonNextWord.TabIndex = 7;
            this.buttonNextWord.Text = "מילה הבאה";
            this.buttonNextWord.UseVisualStyleBackColor = false;
            this.buttonNextWord.Click += new System.EventHandler(this.buttonNextWord_Click);
            // 
            // panelTranslating
            // 
            this.panelTranslating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTranslating.BackColor = System.Drawing.Color.Lavender;
            this.panelTranslating.Controls.Add(this.iconButtonNoKnowing);
            this.panelTranslating.Controls.Add(this.iconButtonHalfKnowing);
            this.panelTranslating.Controls.Add(this.iconButtonKnowing);
            this.panelTranslating.Controls.Add(this.labelWordHebrew);
            this.panelTranslating.Location = new System.Drawing.Point(150, 253);
            this.panelTranslating.Name = "panelTranslating";
            this.panelTranslating.Size = new System.Drawing.Size(819, 120);
            this.panelTranslating.TabIndex = 6;
            // 
            // labelWordHebrew
            // 
            this.labelWordHebrew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWordHebrew.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWordHebrew.Location = new System.Drawing.Point(150, 37);
            this.labelWordHebrew.Name = "labelWordHebrew";
            this.labelWordHebrew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelWordHebrew.Size = new System.Drawing.Size(519, 37);
            this.labelWordHebrew.TabIndex = 1;
            this.labelWordHebrew.Text = "המילה בעברית";
            this.labelWordHebrew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Controls.Add(this.labelTitleQ);
            this.panel3.Controls.Add(this.iconButtonSpeaker);
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1099, 54);
            this.panel3.TabIndex = 5;
            // 
            // labelTitleQ
            // 
            this.labelTitleQ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitleQ.AutoSize = true;
            this.labelTitleQ.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleQ.ForeColor = System.Drawing.Color.Navy;
            this.labelTitleQ.Location = new System.Drawing.Point(362, 10);
            this.labelTitleQ.Name = "labelTitleQ";
            this.labelTitleQ.Size = new System.Drawing.Size(324, 34);
            this.labelTitleQ.TabIndex = 5;
            this.labelTitleQ.Text = "? האם אתה מכיר את המילה";
            // 
            // iconButtonNoKnowing
            // 
            this.iconButtonNoKnowing.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconButtonNoKnowing.BackColor = System.Drawing.Color.Lavender;
            this.iconButtonNoKnowing.FlatAppearance.BorderSize = 0;
            this.iconButtonNoKnowing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.iconButtonNoKnowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonNoKnowing.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonNoKnowing.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonNoKnowing.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonNoKnowing.IconColor = System.Drawing.Color.Black;
            this.iconButtonNoKnowing.IconSize = 32;
            this.iconButtonNoKnowing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonNoKnowing.ImageIndex = 2;
            this.iconButtonNoKnowing.ImageList = this.imageList1;
            this.iconButtonNoKnowing.Location = new System.Drawing.Point(684, 77);
            this.iconButtonNoKnowing.Name = "iconButtonNoKnowing";
            this.iconButtonNoKnowing.Rotation = 0D;
            this.iconButtonNoKnowing.Size = new System.Drawing.Size(40, 40);
            this.iconButtonNoKnowing.TabIndex = 15;
            this.iconButtonNoKnowing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonNoKnowing.UseVisualStyleBackColor = false;
            this.iconButtonNoKnowing.Click += new System.EventHandler(this.iconButtonNoKnowing_Click);
            // 
            // iconButtonHalfKnowing
            // 
            this.iconButtonHalfKnowing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonHalfKnowing.BackColor = System.Drawing.Color.Lavender;
            this.iconButtonHalfKnowing.FlatAppearance.BorderSize = 0;
            this.iconButtonHalfKnowing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.iconButtonHalfKnowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHalfKnowing.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonHalfKnowing.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonHalfKnowing.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonHalfKnowing.IconColor = System.Drawing.Color.Black;
            this.iconButtonHalfKnowing.IconSize = 32;
            this.iconButtonHalfKnowing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHalfKnowing.ImageIndex = 1;
            this.iconButtonHalfKnowing.ImageList = this.imageList1;
            this.iconButtonHalfKnowing.Location = new System.Drawing.Point(730, 77);
            this.iconButtonHalfKnowing.Name = "iconButtonHalfKnowing";
            this.iconButtonHalfKnowing.Rotation = 0D;
            this.iconButtonHalfKnowing.Size = new System.Drawing.Size(40, 40);
            this.iconButtonHalfKnowing.TabIndex = 14;
            this.iconButtonHalfKnowing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonHalfKnowing.UseVisualStyleBackColor = false;
            this.iconButtonHalfKnowing.Click += new System.EventHandler(this.iconButtonHalfKnowing_Click);
            // 
            // iconButtonKnowing
            // 
            this.iconButtonKnowing.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconButtonKnowing.BackColor = System.Drawing.Color.Lavender;
            this.iconButtonKnowing.FlatAppearance.BorderSize = 0;
            this.iconButtonKnowing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.iconButtonKnowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonKnowing.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonKnowing.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonKnowing.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonKnowing.IconColor = System.Drawing.Color.Green;
            this.iconButtonKnowing.IconSize = 32;
            this.iconButtonKnowing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonKnowing.ImageIndex = 0;
            this.iconButtonKnowing.ImageList = this.imageList1;
            this.iconButtonKnowing.Location = new System.Drawing.Point(776, 77);
            this.iconButtonKnowing.Name = "iconButtonKnowing";
            this.iconButtonKnowing.Rotation = 0D;
            this.iconButtonKnowing.Size = new System.Drawing.Size(40, 40);
            this.iconButtonKnowing.TabIndex = 13;
            this.iconButtonKnowing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonKnowing.UseVisualStyleBackColor = false;
            this.iconButtonKnowing.Click += new System.EventHandler(this.iconButtonKnowing_Click);
            // 
            // iconButtonSpeaker
            // 
            this.iconButtonSpeaker.FlatAppearance.BorderSize = 0;
            this.iconButtonSpeaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSpeaker.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSpeaker.IconChar = FontAwesome.Sharp.IconChar.VolumeUp;
            this.iconButtonSpeaker.IconColor = System.Drawing.Color.Navy;
            this.iconButtonSpeaker.IconSize = 56;
            this.iconButtonSpeaker.Location = new System.Drawing.Point(3, 3);
            this.iconButtonSpeaker.Name = "iconButtonSpeaker";
            this.iconButtonSpeaker.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.iconButtonSpeaker.Rotation = 0D;
            this.iconButtonSpeaker.Size = new System.Drawing.Size(56, 48);
            this.iconButtonSpeaker.TabIndex = 4;
            this.iconButtonSpeaker.UseVisualStyleBackColor = false;
            this.iconButtonSpeaker.Click += new System.EventHandler(this.iconButtonSpeaker_Click);
            // 
            // FormSimplePractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1319, 637);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSimplePractice";
            this.Text = "FormSimplePractice";
            this.Load += new System.EventHandler(this.FormSimplePractice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelTranslating.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTheWord;
        private System.Windows.Forms.Button buttonKnow;
        private System.Windows.Forms.Button buttonDontKnow;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonSpeaker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTitleQ;
        private System.Windows.Forms.Panel panelTranslating;
        private System.Windows.Forms.Label labelWordHebrew;
        private System.Windows.Forms.Button buttonNextWord;
        private System.Windows.Forms.Label labelTitle2;
        private System.Windows.Forms.Label labelWordsLeft;
        private System.Windows.Forms.Label labelTitle1;
        private FontAwesome.Sharp.IconButton iconButtonNoKnowing;
        private System.Windows.Forms.ImageList imageList1;
        private FontAwesome.Sharp.IconButton iconButtonHalfKnowing;
        private FontAwesome.Sharp.IconButton iconButtonKnowing;
        private System.Windows.Forms.ListView listViewFilterType;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonUnfilter;
    }
}