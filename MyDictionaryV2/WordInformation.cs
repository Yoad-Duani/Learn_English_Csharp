using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace MyDictionaryV2
{
    public partial class WordInformation : Form
    {
        public WordInformation(int idword1)
        {
            InitializeComponent();
            idword = idword1;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //this.StartPosition = FormStartPosition.CenterParent;
        }
        SpeechSynthesizer ss = new SpeechSynthesizer();
        public int idword;
        DataTable dt = new DataTable();
        DAL_SQL_Queries dsq = new DAL_SQL_Queries();
        bool ChangeTypeBool = false;
        int heightButton = 503;
        public int itemCheckColor;
        private void WordInformation_Load(object sender, EventArgs e)
        {
            //this.StartPosition = FormStartPosition.CenterParent;
            dt = dsq.dataSourceWordRow(idword);
            labelWordInEnglish.Text = dt.Rows[0].ItemArray[2].ToString();
            labelWordInHebrew.Text = dt.Rows[0].ItemArray[1].ToString();

            if(dt.Rows[0].ItemArray[5].ToString() != "")
                labelExampleSentences.Text = dt.Rows[0].ItemArray[5].ToString();

            if (dt.Rows[0].ItemArray[4].ToString() != "")
                labelExampleWords.Text = dt.Rows[0].ItemArray[4].ToString(); //

            //labelWordHebrew.Text = dt.Rows[0].ItemArray[1].ToString();
        }

        private void iconButtonChangeType_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ChangeTypeBool == true)
            {
                if (panelChangeType.Height > 0)
                {
                    panelChangeType.Height -= 20;
                    panelWordInformation.Height += 20;
                    heightButton += 20;
                    iconButtonChangeType.Top = heightButton;
                    

                }
                else
                {
                    timer1.Stop();
                    ChangeTypeBool = false;
                }
            }
            else
            {
                if (panelChangeType.Height < 100)
                {
                    panelChangeType.Height += 20;
                    panelWordInformation.Height -= 20;
                    heightButton -= 20;
                    iconButtonChangeType.Top = heightButton;
                }
                else
                {
                    timer1.Stop();
                    ChangeTypeBool = true;
                }
            }
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButtonSpeaker_Click(object sender, EventArgs e)
        {
            ss.Rate = -3;
            ss.Volume = 100;
            ss.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            //ss.SelectVoice("Microsoft Zira Desktop");

            PromptBuilder builder = new PromptBuilder();
            builder.AppendText(labelWordInEnglish.Text.ToString());
            ss.SpeakAsync(builder);
        }

        private void iconButtonKnowing_Click(object sender, EventArgs e)
        {
            int ok; 
            int colorID;
            colorID = int.Parse(dt.Rows[0].ItemArray[6].ToString());
            if (colorID != 1)
            {
                itemCheckColor = 1;
                ok = dsq.updateTypeWord((int.Parse(dt.Rows[0].ItemArray[0].ToString())), itemCheckColor);
                //dalAcss.updateWordType(itemCheck, id);
                if(ok == 0) // Failed to update
                {
                    MessageBox.Show("בעיה לא מוכרת בנסיון העדכון");
                }

                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void iconButtonHalfKnowing_Click(object sender, EventArgs e)
        {
            int ok;
            int colorID;
            colorID = int.Parse(dt.Rows[0].ItemArray[6].ToString());
            if (colorID != 2)
            {
                itemCheckColor = 2;
                ok = dsq.updateTypeWord((int.Parse(dt.Rows[0].ItemArray[0].ToString())), itemCheckColor);
                //dalAcss.updateWordType(itemCheck, id);
                if (ok == 0) // Failed to update
                {
                    MessageBox.Show("בעיה לא מוכרת בנסיון העדכון");
                }

                this.Close();
            }
            else
            {
                this.Close();
            }

        }

        private void iconButtonNoKnowing_Click(object sender, EventArgs e)
        {
            int ok;
            int colorID;
            colorID = int.Parse(dt.Rows[0].ItemArray[6].ToString());
            if (colorID != 3)
            {
                itemCheckColor = 3;
                ok = dsq.updateTypeWord((int.Parse(dt.Rows[0].ItemArray[0].ToString())), itemCheckColor);
                //dalAcss.updateWordType(itemCheck, id);
                if (ok == 0) // Failed to update
                {
                    MessageBox.Show("בעיה לא מוכרת בנסיון העדכון");
                }

                this.Close();
            }
            else
            {
                this.Close();
            }

        }


        
    }
}
