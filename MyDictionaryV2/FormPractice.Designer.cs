namespace MyDictionaryV2
{
    partial class FormPractice
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
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem("   יחידה 1   ");
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem("   יחידה 2   ");
            System.Windows.Forms.ListViewItem listViewItem27 = new System.Windows.Forms.ListViewItem("   יחידה 3   ");
            System.Windows.Forms.ListViewItem listViewItem28 = new System.Windows.Forms.ListViewItem("   יחידה 4   ");
            System.Windows.Forms.ListViewItem listViewItem29 = new System.Windows.Forms.ListViewItem("   יחידה 5   ");
            System.Windows.Forms.ListViewItem listViewItem30 = new System.Windows.Forms.ListViewItem("   יחידה 6   ");
            System.Windows.Forms.ListViewItem listViewItem31 = new System.Windows.Forms.ListViewItem("   יחידה 7   ");
            System.Windows.Forms.ListViewItem listViewItem32 = new System.Windows.Forms.ListViewItem("   יחידה 8   ");
            System.Windows.Forms.ListViewItem listViewItem33 = new System.Windows.Forms.ListViewItem("   יחידה 9   ");
            System.Windows.Forms.ListViewItem listViewItem34 = new System.Windows.Forms.ListViewItem("   יחידה 10 ");
            System.Windows.Forms.ListViewItem listViewItem35 = new System.Windows.Forms.ListViewItem("      A      ");
            System.Windows.Forms.ListViewItem listViewItem36 = new System.Windows.Forms.ListViewItem("      B      ");
            this.panelSelectUnit = new System.Windows.Forms.Panel();
            this.listViewSelectUnit = new System.Windows.Forms.ListView();
            this.panel14 = new System.Windows.Forms.Panel();
            this.labelSelectUnit = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewSelectAB = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelSelectAB = new System.Windows.Forms.Label();
            this.panelSelectUnit.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSelectUnit
            // 
            this.panelSelectUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSelectUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(170)))));
            this.panelSelectUnit.Controls.Add(this.listViewSelectUnit);
            this.panelSelectUnit.Controls.Add(this.panel14);
            this.panelSelectUnit.Location = new System.Drawing.Point(760, 88);
            this.panelSelectUnit.Name = "panelSelectUnit";
            this.panelSelectUnit.Size = new System.Drawing.Size(210, 465);
            this.panelSelectUnit.TabIndex = 9;
            // 
            // listViewSelectUnit
            // 
            this.listViewSelectUnit.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewSelectUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(170)))));
            this.listViewSelectUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewSelectUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listViewSelectUnit.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewSelectUnit.HideSelection = false;
            listViewItem25.StateImageIndex = 0;
            listViewItem26.StateImageIndex = 0;
            listViewItem27.StateImageIndex = 0;
            listViewItem28.StateImageIndex = 0;
            listViewItem29.StateImageIndex = 0;
            listViewItem30.StateImageIndex = 0;
            listViewItem31.StateImageIndex = 0;
            listViewItem32.StateImageIndex = 0;
            listViewItem33.StateImageIndex = 0;
            listViewItem34.StateImageIndex = 0;
            this.listViewSelectUnit.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem25,
            listViewItem26,
            listViewItem27,
            listViewItem28,
            listViewItem29,
            listViewItem30,
            listViewItem31,
            listViewItem32,
            listViewItem33,
            listViewItem34});
            this.listViewSelectUnit.Location = new System.Drawing.Point(0, 50);
            this.listViewSelectUnit.MultiSelect = false;
            this.listViewSelectUnit.Name = "listViewSelectUnit";
            this.listViewSelectUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listViewSelectUnit.RightToLeftLayout = true;
            this.listViewSelectUnit.Scrollable = false;
            this.listViewSelectUnit.Size = new System.Drawing.Size(188, 415);
            this.listViewSelectUnit.TabIndex = 10;
            this.listViewSelectUnit.TileSize = new System.Drawing.Size(210, 50);
            this.listViewSelectUnit.UseCompatibleStateImageBehavior = false;
            this.listViewSelectUnit.View = System.Windows.Forms.View.List;
            this.listViewSelectUnit.SelectedIndexChanged += new System.EventHandler(this.listViewSelectUnit_SelectedIndexChanged);
            this.listViewSelectUnit.MouseLeave += new System.EventHandler(this.listViewSelectUnit_MouseLeave);
            this.listViewSelectUnit.MouseHover += new System.EventHandler(this.listViewSelectUnit_MouseHover);
            this.listViewSelectUnit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listViewSelectUnit_MouseMove);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel14.Controls.Add(this.labelSelectUnit);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(210, 50);
            this.panel14.TabIndex = 9;
            // 
            // labelSelectUnit
            // 
            this.labelSelectUnit.AutoSize = true;
            this.labelSelectUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSelectUnit.Location = new System.Drawing.Point(15, 10);
            this.labelSelectUnit.Name = "labelSelectUnit";
            this.labelSelectUnit.Size = new System.Drawing.Size(183, 32);
            this.labelSelectUnit.TabIndex = 9;
            this.labelSelectUnit.Text = "בחירת יחידות";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(10, 30);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(170)))));
            this.panel1.Controls.Add(this.listViewSelectAB);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(390, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 155);
            this.panel1.TabIndex = 13;
            // 
            // listViewSelectAB
            // 
            this.listViewSelectAB.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewSelectAB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(170)))));
            this.listViewSelectAB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewSelectAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listViewSelectAB.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewSelectAB.HideSelection = false;
            listViewItem35.StateImageIndex = 0;
            listViewItem36.StateImageIndex = 0;
            this.listViewSelectAB.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem35,
            listViewItem36});
            this.listViewSelectAB.Location = new System.Drawing.Point(0, 50);
            this.listViewSelectAB.MultiSelect = false;
            this.listViewSelectAB.Name = "listViewSelectAB";
            this.listViewSelectAB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listViewSelectAB.RightToLeftLayout = true;
            this.listViewSelectAB.Scrollable = false;
            this.listViewSelectAB.Size = new System.Drawing.Size(178, 105);
            this.listViewSelectAB.TabIndex = 10;
            this.listViewSelectAB.TileSize = new System.Drawing.Size(210, 50);
            this.listViewSelectAB.UseCompatibleStateImageBehavior = false;
            this.listViewSelectAB.View = System.Windows.Forms.View.List;
            this.listViewSelectAB.SelectedIndexChanged += new System.EventHandler(this.listViewSelectAB_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.labelSelectAB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 50);
            this.panel2.TabIndex = 9;
            // 
            // labelSelectAB
            // 
            this.labelSelectAB.AutoSize = true;
            this.labelSelectAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSelectAB.Location = new System.Drawing.Point(3, 10);
            this.labelSelectAB.Name = "labelSelectAB";
            this.labelSelectAB.Size = new System.Drawing.Size(217, 32);
            this.labelSelectAB.TabIndex = 9;
            this.labelSelectAB.Text = "בחירת רמת קושי";
            // 
            // FormPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1319, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSelectUnit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPractice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Practice";
            this.Load += new System.EventHandler(this.FormPractice_Load);
            this.panelSelectUnit.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSelectUnit;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label labelSelectUnit;
        private System.Windows.Forms.ListView listViewSelectUnit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewSelectAB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelSelectAB;
    }
}