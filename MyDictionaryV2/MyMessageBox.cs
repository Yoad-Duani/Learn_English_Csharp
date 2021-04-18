using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDictionaryV2
{
    public partial class MyMessageBox : Form
    {
        string messageText;
        public MyMessageBox(string messageText1)
        {
            InitializeComponent();
            messageText = messageText1;
        }

        

        private void MyMessageBox_Load(object sender, EventArgs e)
        {
            if(messageText == "סיימת את התרגול מיד תעבור חזרה לדף הראשי")
            {
                labelTitle.Text = "כל הכבוד";
                iconPictureBoxError.Visible = false;
            }
            this.StartPosition = FormStartPosition.CenterScreen;
            //iconButtonOK.ForeColor = Color.White;
            //button1.ForeColor = Color.FromArgb(76, 5, 255, 1);
            button1.BackColor = Color.FromArgb(72, 236, 60);
            labelText.Text = messageText;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
