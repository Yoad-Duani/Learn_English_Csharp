using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
//using Microsoft.Win32;

namespace MyDictionaryV2
{
    public partial class Form1 : Form
    {
        //fildes
        private IconButton currentBtn; // design for buttons in menu
        private Panel leftBorderBtn; // variable for create a choice effect, left side in buttons in menu
        private Color color1 = Color.PaleGoldenrod;  // color for buttons in menu when click
        private Form currentChildForm; //represents the current form that open
        public FormPractice formPractice;
        string textMessage;
        MyMessageBox myMessageBox;
        //string textMessage; 
        bool panelMnueBool = true; //variable that helps to design the slide menu 

        //public static bool withoutType4 = false;
        public static bool withoutType4 = false;
       
        //Form1.withoutType4 = false;

        DataTable dt = new DataTable();
        //DAL_SQL_Queries dsq = new DAL_SQL_Queries();
        //FormPractice formPractice = new FormPractice();

        //public FormPractice TheFormPractice { get; set; }

        public Form1()
        {
            //withoutType4 = false;
            //TheFormPractice = formPractice;
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //this.FormBorderStyle = FormBorderStyle.None;

        }
        //public Form1()
        //{
        //    TheFormPractice = formPractice;
        //    InitializeComponent();
        //    leftBorderBtn = new Panel();
        //    leftBorderBtn.Size = new Size(7, 60);
        //    panelMenu.Controls.Add(leftBorderBtn);

        //    this.Text = string.Empty;
        //    this.ControlBox = false;
        //    this.DoubleBuffered = true;
        //    this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        //    //this.FormBorderStyle = FormBorderStyle.None;

        //}

        // when I click on button in the main menu , 
        private void ActivateButton(Object senderBtn , Color color)
        {
            // when I click on button in the main menu , 
            //
            DisableButton(); // cancels the previous selection
            if (senderBtn !=null)
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                //currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconPictureBoxCurrentPageIcon.IconChar = currentBtn.IconChar;
                labelCurrentPageName.Text = currentBtn.Text.ToString().Remove(0,5); // I use remove because i put 5 space in lable text for the design
            }
        }

        // cancels the previous selection
        private void DisableButton()
        {
            if(currentBtn !=null)
            {
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.BackColor = Color.RoyalBlue;
                currentBtn.ForeColor = Color.White;
                //currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.IconColor = Color.White;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // defines the availability status of the learning buttons , only in practice mode
            iconButtonSimplePractice.Enabled = false;
            iconButtonAdvancedPractice.Enabled = false;
            iconButtonMemorization.Enabled = false;
            //

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //choice of learning mode
        private void iconButtonPracticePage_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color1);
            openChildFormPrac(new FormPractice()); // open the child form in the center
            iconButtonSimplePractice.Visible = true; // types of learning are available
            iconButtonAdvancedPractice.Visible = true;
            iconButtonMemorization.Visible = true;
            iconButtonSimplePractice.Enabled = true; // types of learning are available
            iconButtonAdvancedPractice.Enabled = true;
            iconButtonMemorization.Enabled = true;
            iconButtonAdvancedPractice.Cursor = System.Windows.Forms.Cursors.Hand;
            iconButtonMemorization.Cursor = System.Windows.Forms.Cursors.Hand;
            iconButtonSimplePractice.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        //choice of about mode
        private void iconButtonAbout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color1);
            openChildForm(new AboutBoxForm());
            iconButtonSimplePractice.Visible = false;
            iconButtonAdvancedPractice.Visible = false;
            iconButtonMemorization.Visible = false;

            iconButtonAdvancedPractice.Cursor = System.Windows.Forms.Cursors.Default;
            iconButtonMemorization.Cursor = System.Windows.Forms.Cursors.Default;
            iconButtonSimplePractice.Cursor = System.Windows.Forms.Cursors.Default;

            //System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            //ToolTip1.SetToolTip(this.iconButtonAdvancedPractice, "Button Info");
        }


        //choice of my progress mode
        private void iconButtonMyProgress_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color1);
            openChildForm(new formMyProgress());
            iconButtonSimplePractice.Visible = false;
            iconButtonAdvancedPractice.Visible = false;
            iconButtonMemorization.Visible = false;

            //iconButtonAdvancedPractice.Cursor = System.Windows.Forms.Cursors.Default;
            //iconButtonMemorization.Cursor = System.Windows.Forms.Cursors.Default;
            //iconButtonSimplePractice.Cursor = System.Windows.Forms.Cursors.Default;
        }

        //for the resize the form with the mouse
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        //

        //design the slide main menu , using timer
        private void iconButtonMenu_Click(object sender, EventArgs e)
        {
            //    if (panelMenu.Width == 250)
            //    {
            //panelMenu.Width = 70;
            timer1.Start();
               
            //}
            //else
            //{
            //    //panelMenu.Width = 250;
            //    timer1.Start();
                
            //}
        }

        // open the child form that user choice 
        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChilfFormDesktop.Controls.Add(childForm);
            panelChilfFormDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void openChildFormPrac(FormPractice childForm)
        {
            //for spesific formPractice
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChilfFormDesktop.Controls.Add(childForm);
            panelChilfFormDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            formPractice = childForm;

        }


        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonMaxsimumSize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconButtonMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //open memorization mode
        private void iconButtonMemorization_Click(object sender, EventArgs e)
        {
            //ListView lst = new ListView();
            //formPractice.Memorization_();

            //FormPractice formPractice = new FormPractice();
            //formPractice = FormPractice(currentChildForm);
            //formPractice = currentChildForm;
            ////currentChildForm.
            ////FormPractice formPractice = currentChildForm;

            dt = formPractice.Memorization_();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    this.iconButtonMemorization.Visible = false;
                    iconButtonSimplePractice.Visible = false;
                    iconButtonAdvancedPractice.Visible = false;
                    openChildForm(new FormPracticeMemorization(dt));
                    timer1.Interval = 1;  // need update****
                                          //this.iconButtonMemorization.Enabled = false;
                }
                else
                {
                    textMessage = "אין מילים ביחידה זו";
                    myMessageBox = new MyMessageBox(textMessage);
                    myMessageBox.ShowDialog();
                }
            }
            else
            {
                if (formPractice.messagBoxCheak != true)
                {
                    textMessage = "בעיה לא מוכרת בטעינת המילים";
                    myMessageBox = new MyMessageBox(textMessage);
                    myMessageBox.ShowDialog();
                }
                //string = 
                //MyMessageBox myMessageBox = new MyMessageBox()
            }
            
        }

        //open advanced practice mode
        private void iconButtonAdvancedPractice_Click(object sender, EventArgs e)
        {
            textMessage = "אין תרגול מתקדם בשלב זה";
            myMessageBox = new MyMessageBox(textMessage);
            myMessageBox.ShowDialog();
        }

        //closes the pages, returns to the starting page
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                iconButtonSimplePractice.Enabled = false;
                iconButtonAdvancedPractice.Enabled = false;
                iconButtonMemorization.Enabled = false;
            }
        }

        // using this timer for the slide the main menu
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panelMnueBool == true)
            {
                if (panelMenu.Width > 70)
                {
                    panelMenu.Width -= 60;
                }
                else
                {
                    timer1.Stop();
                    panelMnueBool = false;
                }
            }
            else
            {
                if (panelMenu.Width < 250)
                {
                    panelMenu.Width += 60;
                }
                else
                {
                    timer1.Stop();
                    panelMnueBool = true;
                }


            }
        }

        private void iconButtonSimplePractice_Click(object sender, EventArgs e)
        {
            withoutType4 = true;
            dt = formPractice.Memorization_();
            if (dt != null )
            {
                if (dt.Rows.Count > 0)
                {
                    openChildForm(new FormSimplePractice(dt));
                    iconButtonSimplePractice.Visible = false;
                    iconButtonAdvancedPractice.Visible = false;
                    iconButtonMemorization.Visible = false;
                    
                }
                else
                {
                    textMessage = "אין מילים לתרגול , רק מילים עם צבע אפשר לתרגל";
                    myMessageBox = new MyMessageBox(textMessage);
                    myMessageBox.ShowDialog();
                }
            }
            else
            {
                if (formPractice.messagBoxCheak != true)
                {
                    textMessage = "בעיה לא מוכרת בטעינת המילים";
                    myMessageBox = new MyMessageBox(textMessage);
                    myMessageBox.ShowDialog();
                }
            }
            //iconButtonSimplePractice.Enabled = false;
            //iconButtonAdvancedPractice.Enabled = false;
            //iconButtonMemorization.Enabled = false;
            //withoutType4 = true;

        }

        private void iconButtonMyWords_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, color1);
            openChildForm(new FormprivateWordscs());
            iconButtonSimplePractice.Enabled = Visible;
            iconButtonAdvancedPractice.Enabled = Visible;
            iconButtonMemorization.Enabled = Visible;
        }
    }
}
