namespace MyDictionaryV2
{
    partial class WordInformation
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
            this.panelChangeType = new System.Windows.Forms.Panel();
            this.labelNoKnowing = new System.Windows.Forms.Label();
            this.labelHalfKnowing = new System.Windows.Forms.Label();
            this.labelKnowing = new System.Windows.Forms.Label();
            this.iconButtonNoKnowing = new FontAwesome.Sharp.IconButton();
            this.iconButtonHalfKnowing = new FontAwesome.Sharp.IconButton();
            this.iconButtonKnowing = new FontAwesome.Sharp.IconButton();
            this.panelWordInformation = new System.Windows.Forms.Panel();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.panelExampleWordsAndSentences = new System.Windows.Forms.Panel();
            this.labelExampleSentences = new System.Windows.Forms.Label();
            this.labelExampleWords = new System.Windows.Forms.Label();
            this.labelExampleSentencesTitle = new System.Windows.Forms.Label();
            this.labelExampleWordsTitle = new System.Windows.Forms.Label();
            this.panelShowWord = new System.Windows.Forms.Panel();
            this.labelWordInEnglish = new System.Windows.Forms.Label();
            this.labelWordInHebrew = new System.Windows.Forms.Label();
            this.iconButtonSpeaker = new FontAwesome.Sharp.IconButton();
            this.iconButtonChangeType = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelWordInformation.SuspendLayout();
            this.panelExampleWordsAndSentences.SuspendLayout();
            this.panelShowWord.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChangeType
            // 
            this.panelChangeType.BackColor = System.Drawing.Color.Lavender;
            this.panelChangeType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChangeType.Location = new System.Drawing.Point(0, 395);
            this.panelChangeType.Name = "panelChangeType";
            this.panelChangeType.Size = new System.Drawing.Size(800, 0);
            this.panelChangeType.TabIndex = 0;
            // 
            // labelNoKnowing
            // 
            this.labelNoKnowing.AutoSize = true;
            this.labelNoKnowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNoKnowing.ForeColor = System.Drawing.Color.Lavender;
            this.labelNoKnowing.Location = new System.Drawing.Point(230, 310);
            this.labelNoKnowing.Name = "labelNoKnowing";
            this.labelNoKnowing.Size = new System.Drawing.Size(80, 25);
            this.labelNoKnowing.TabIndex = 15;
            this.labelNoKnowing.Text = "לא מכיר";
            // 
            // labelHalfKnowing
            // 
            this.labelHalfKnowing.AutoSize = true;
            this.labelHalfKnowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHalfKnowing.ForeColor = System.Drawing.Color.Lavender;
            this.labelHalfKnowing.Location = new System.Drawing.Point(340, 310);
            this.labelHalfKnowing.Name = "labelHalfKnowing";
            this.labelHalfKnowing.Size = new System.Drawing.Size(90, 25);
            this.labelHalfKnowing.TabIndex = 14;
            this.labelHalfKnowing.Text = "חצי מכיר";
            // 
            // labelKnowing
            // 
            this.labelKnowing.AutoSize = true;
            this.labelKnowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelKnowing.ForeColor = System.Drawing.Color.Lavender;
            this.labelKnowing.Location = new System.Drawing.Point(472, 310);
            this.labelKnowing.Name = "labelKnowing";
            this.labelKnowing.Size = new System.Drawing.Size(52, 25);
            this.labelKnowing.TabIndex = 13;
            this.labelKnowing.Text = "מכיר";
            // 
            // iconButtonNoKnowing
            // 
            this.iconButtonNoKnowing.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.iconButtonNoKnowing.Location = new System.Drawing.Point(243, 340);
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
            this.iconButtonHalfKnowing.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.iconButtonHalfKnowing.Location = new System.Drawing.Point(360, 340);
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
            // iconButtonKnowing
            // 
            this.iconButtonKnowing.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.iconButtonKnowing.Location = new System.Drawing.Point(474, 340);
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
            // panelWordInformation
            // 
            this.panelWordInformation.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelWordInformation.Controls.Add(this.labelNoKnowing);
            this.panelWordInformation.Controls.Add(this.iconButtonExit);
            this.panelWordInformation.Controls.Add(this.panelExampleWordsAndSentences);
            this.panelWordInformation.Controls.Add(this.labelHalfKnowing);
            this.panelWordInformation.Controls.Add(this.panelShowWord);
            this.panelWordInformation.Controls.Add(this.iconButtonSpeaker);
            this.panelWordInformation.Controls.Add(this.labelKnowing);
            this.panelWordInformation.Controls.Add(this.iconButtonChangeType);
            this.panelWordInformation.Controls.Add(this.iconButtonKnowing);
            this.panelWordInformation.Controls.Add(this.iconButtonNoKnowing);
            this.panelWordInformation.Controls.Add(this.iconButtonHalfKnowing);
            this.panelWordInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWordInformation.Location = new System.Drawing.Point(0, 0);
            this.panelWordInformation.Name = "panelWordInformation";
            this.panelWordInformation.Size = new System.Drawing.Size(800, 395);
            this.panelWordInformation.TabIndex = 1;
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonExit.Enabled = false;
            this.iconButtonExit.FlatAppearance.BorderSize = 0;
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButtonExit.IconColor = System.Drawing.Color.Lavender;
            this.iconButtonExit.IconSize = 40;
            this.iconButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExit.Location = new System.Drawing.Point(746, 5);
            this.iconButtonExit.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.iconButtonExit.Rotation = 0D;
            this.iconButtonExit.Size = new System.Drawing.Size(47, 32);
            this.iconButtonExit.TabIndex = 15;
            this.iconButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExit.UseVisualStyleBackColor = true;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // panelExampleWordsAndSentences
            // 
            this.panelExampleWordsAndSentences.BackColor = System.Drawing.Color.Lavender;
            this.panelExampleWordsAndSentences.Controls.Add(this.labelExampleSentences);
            this.panelExampleWordsAndSentences.Controls.Add(this.labelExampleWords);
            this.panelExampleWordsAndSentences.Controls.Add(this.labelExampleSentencesTitle);
            this.panelExampleWordsAndSentences.Controls.Add(this.labelExampleWordsTitle);
            this.panelExampleWordsAndSentences.Location = new System.Drawing.Point(3, 140);
            this.panelExampleWordsAndSentences.Name = "panelExampleWordsAndSentences";
            this.panelExampleWordsAndSentences.Size = new System.Drawing.Size(776, 170);
            this.panelExampleWordsAndSentences.TabIndex = 14;
            // 
            // labelExampleSentences
            // 
            this.labelExampleSentences.AutoSize = true;
            this.labelExampleSentences.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExampleSentences.Location = new System.Drawing.Point(51, 77);
            this.labelExampleSentences.MaximumSize = new System.Drawing.Size(360, 0);
            this.labelExampleSentences.Name = "labelExampleSentences";
            this.labelExampleSentences.Size = new System.Drawing.Size(145, 19);
            this.labelExampleSentences.TabIndex = 15;
            this.labelExampleSentences.Text = "אין משפטים לדוגמא";
            // 
            // labelExampleWords
            // 
            this.labelExampleWords.AutoSize = true;
            this.labelExampleWords.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExampleWords.Location = new System.Drawing.Point(51, 15);
            this.labelExampleWords.Name = "labelExampleWords";
            this.labelExampleWords.Size = new System.Drawing.Size(124, 19);
            this.labelExampleWords.TabIndex = 14;
            this.labelExampleWords.Text = "אין מילים קשורות";
            // 
            // labelExampleSentencesTitle
            // 
            this.labelExampleSentencesTitle.AutoSize = true;
            this.labelExampleSentencesTitle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExampleSentencesTitle.Location = new System.Drawing.Point(561, 77);
            this.labelExampleSentencesTitle.Name = "labelExampleSentencesTitle";
            this.labelExampleSentencesTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelExampleSentencesTitle.Size = new System.Drawing.Size(133, 19);
            this.labelExampleSentencesTitle.TabIndex = 13;
            this.labelExampleSentencesTitle.Text = "משפטים לדוגמא :";
            // 
            // labelExampleWordsTitle
            // 
            this.labelExampleWordsTitle.AutoSize = true;
            this.labelExampleWordsTitle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExampleWordsTitle.Location = new System.Drawing.Point(588, 15);
            this.labelExampleWordsTitle.Name = "labelExampleWordsTitle";
            this.labelExampleWordsTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelExampleWordsTitle.Size = new System.Drawing.Size(112, 19);
            this.labelExampleWordsTitle.TabIndex = 12;
            this.labelExampleWordsTitle.Text = "מילים קשורות :";
            // 
            // panelShowWord
            // 
            this.panelShowWord.BackColor = System.Drawing.Color.Lavender;
            this.panelShowWord.Controls.Add(this.labelWordInEnglish);
            this.panelShowWord.Controls.Add(this.labelWordInHebrew);
            this.panelShowWord.Location = new System.Drawing.Point(3, 68);
            this.panelShowWord.Name = "panelShowWord";
            this.panelShowWord.Size = new System.Drawing.Size(776, 44);
            this.panelShowWord.TabIndex = 13;
            // 
            // labelWordInEnglish
            // 
            this.labelWordInEnglish.AutoSize = true;
            this.labelWordInEnglish.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWordInEnglish.Location = new System.Drawing.Point(47, 9);
            this.labelWordInEnglish.Name = "labelWordInEnglish";
            this.labelWordInEnglish.Size = new System.Drawing.Size(81, 29);
            this.labelWordInEnglish.TabIndex = 11;
            this.labelWordInEnglish.Text = "label1";
            // 
            // labelWordInHebrew
            // 
            this.labelWordInHebrew.AutoSize = true;
            this.labelWordInHebrew.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelWordInHebrew.Location = new System.Drawing.Point(325, 9);
            this.labelWordInHebrew.MaximumSize = new System.Drawing.Size(460, 0);
            this.labelWordInHebrew.Name = "labelWordInHebrew";
            this.labelWordInHebrew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelWordInHebrew.Size = new System.Drawing.Size(81, 29);
            this.labelWordInHebrew.TabIndex = 12;
            this.labelWordInHebrew.Text = "label2";
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
            this.iconButtonSpeaker.Location = new System.Drawing.Point(3, 3);
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
            // iconButtonChangeType
            // 
            this.iconButtonChangeType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonChangeType.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonChangeType.FlatAppearance.BorderSize = 0;
            this.iconButtonChangeType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonChangeType.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonChangeType.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonChangeType.IconChar = FontAwesome.Sharp.IconChar.Smile;
            this.iconButtonChangeType.IconColor = System.Drawing.Color.Lavender;
            this.iconButtonChangeType.IconSize = 48;
            this.iconButtonChangeType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonChangeType.Location = new System.Drawing.Point(735, 424);
            this.iconButtonChangeType.Name = "iconButtonChangeType";
            this.iconButtonChangeType.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconButtonChangeType.Rotation = 0D;
            this.iconButtonChangeType.Size = new System.Drawing.Size(53, 47);
            this.iconButtonChangeType.TabIndex = 9;
            this.iconButtonChangeType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonChangeType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonChangeType.UseVisualStyleBackColor = false;
            this.iconButtonChangeType.Click += new System.EventHandler(this.iconButtonChangeType_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WordInformation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.ControlBox = false;
            this.Controls.Add(this.panelWordInformation);
            this.Controls.Add(this.panelChangeType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WordInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WordInformation";
            this.Load += new System.EventHandler(this.WordInformation_Load);
            this.panelWordInformation.ResumeLayout(false);
            this.panelWordInformation.PerformLayout();
            this.panelExampleWordsAndSentences.ResumeLayout(false);
            this.panelExampleWordsAndSentences.PerformLayout();
            this.panelShowWord.ResumeLayout(false);
            this.panelShowWord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChangeType;
        private FontAwesome.Sharp.IconButton iconButtonChangeType;
        private System.Windows.Forms.Panel panelWordInformation;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelNoKnowing;
        private System.Windows.Forms.Label labelHalfKnowing;
        private System.Windows.Forms.Label labelKnowing;
        private FontAwesome.Sharp.IconButton iconButtonNoKnowing;
        private FontAwesome.Sharp.IconButton iconButtonHalfKnowing;
        private FontAwesome.Sharp.IconButton iconButtonKnowing;
        private FontAwesome.Sharp.IconButton iconButtonSpeaker;
        private System.Windows.Forms.Label labelWordInHebrew;
        private System.Windows.Forms.Label labelWordInEnglish;
        private System.Windows.Forms.Panel panelShowWord;
        private System.Windows.Forms.Panel panelExampleWordsAndSentences;
        private System.Windows.Forms.Label labelExampleSentences;
        private System.Windows.Forms.Label labelExampleWords;
        private System.Windows.Forms.Label labelExampleSentencesTitle;
        private System.Windows.Forms.Label labelExampleWordsTitle;
        private FontAwesome.Sharp.IconButton iconButtonExit;
    }
}