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
    public partial class FormSimplePractice : Form
    {
        public FormSimplePractice(DataTable dt2)
        {
            dtOrginal = dt2;
            dtRunTime = dt2;
            InitializeComponent();
        }
        DataTable dtOrginal;
        DataTable dtRunTime;
        DataRow drDelete;
        DataRow drDeleteOrginal;
        DataRow drDontKnow;
        MyMessageBox myMessageBox;


        DAL_SQL_Queries dsq = new DAL_SQL_Queries();

        int idWord;
        int colorID;
        int itemCheckColor;
        bool userKnowsTheWord = false;
        bool checkSelectedType;
        string textForMeesageBox;
        string FilterText = "";



        SpeechSynthesizer ss = new SpeechSynthesizer();
        //PromptBuilder builder = new PromptBuilder();


        private void buttonKnow_Click(object sender, EventArgs e)
        {
            int k = 0;
            userKnowsTheWord = true;
            buttonKnow.Enabled = false;
            buttonDontKnow.Enabled = false;
            //buttonNextWord.Visible = true;
            panelTranslating.Visible = true;

            drDeleteOrginal = dtOrginal.Rows[k];
            drDelete = dtRunTime.Rows[0];
            //int k = 0;
            while(int.Parse(drDelete.ItemArray[3].ToString()) != int.Parse(drDeleteOrginal.ItemArray[3].ToString()))
            {
                k = k + 1;
                drDeleteOrginal = dtOrginal.Rows[k];
            }
            drDeleteOrginal.Delete();
            drDelete.Delete();
            dtRunTime.AcceptChanges();
            dtOrginal.AcceptChanges();

            labelWordsLeft.Text = dtRunTime.Rows.Count.ToString();

            if (dtRunTime.Rows.Count > 0)
            {
                buttonNextWord.Visible = true;
            }
            else
            {
                textForMeesageBox = "סיימת את התרגול ";
                myMessageBox = new MyMessageBox(textForMeesageBox);
                myMessageBox.ShowDialog();
            }
            //dtRunTime.Rows[0].Delete();
            //labelTheWord.Text = dtRunTime.Rows[0].ItemArray[0].ToString().Replace(" ", string.Empty);
            //labelWordHebrew.Text = dtRunTime.Rows[0].ItemArray[1].ToString().Replace(" ", string.Empty);
        }

        private void buttonDontKnow_Click(object sender, EventArgs e)
        {
            userKnowsTheWord = false;
            buttonKnow.Enabled = false;
            buttonDontKnow.Enabled = false;
            buttonNextWord.Visible = true;
            panelTranslating.Visible = true;

            drDelete = dtRunTime.Rows[0];
            MoveDataRowTo(drDelete, 3);
            //DataTable parentTable = drDelete.Table;
            

            //drDontKnow = dtRunTime.NewRow();
            //drDontKnow = dtRunTime.Rows[0];
            //drDelete.Delete();
            //dtRunTime.AcceptChanges();
            //DataRow newDataRow = parentTable.NewRow();
            //drDontKnow = parentTable.NewRow();
            //drDontKnow = parentTable.Rows[0];
            //dtRunTime.Rows.InsertAt(drDontKnow, 2);

            //drDontKnow.Delete();
            //parentTable.AcceptChanges();


            //drDelete = dtRunTime.Rows[0];
            //drDelete.Delete();
            //dtRunTime.AcceptChanges();
            //dtRunTime.Rows.InsertAt(drDontKnow, 2);
            //dtRunTime.AcceptChanges();
            //drDontKnow.Delete();
        }

        private void buttonNextWord_Click(object sender, EventArgs e)
        {
          
                    iconButtonKnowing.FlatAppearance.BorderSize = 0;
                    //iconButtonKnowing.FlatAppearance.BorderColor = Color.Red;
                    iconButtonHalfKnowing.FlatAppearance.BorderSize = 0;
                    //iconButtonHalfKnowing.FlatAppearance.BorderColor = Color.Red;
                    iconButtonNoKnowing.FlatAppearance.BorderSize = 0;
                    //iconButtonNoKnowing.FlatAppearance.BorderColor = Color.Red;
         

            buttonKnow.Enabled = true;
            buttonDontKnow.Enabled = true;
            buttonNextWord.Visible = false;
            panelTranslating.Visible = false;

            labelTheWord.Text = dtRunTime.Rows[0].ItemArray[0].ToString().Replace("  ", string.Empty);
            labelWordHebrew.Text = dtRunTime.Rows[0].ItemArray[1].ToString().Replace("  ", string.Empty);
            colorID = int.Parse(dtRunTime.Rows[0].ItemArray[2].ToString());
            idWord = int.Parse(dtRunTime.Rows[0].ItemArray[3].ToString());

            //builder.AppendText(labelTheWord.Text.ToString());
            ss.SpeakAsync(labelTheWord.Text.ToString());

            switch (colorID)
            {
                case 1:
                    iconButtonKnowing.FlatAppearance.BorderSize = 2;
                    iconButtonKnowing.FlatAppearance.BorderColor = Color.Red;
                    break;
                case 2:
                    iconButtonHalfKnowing.FlatAppearance.BorderSize = 2;
                    iconButtonHalfKnowing.FlatAppearance.BorderColor = Color.Red;
                    break;
                case 3:
                    iconButtonNoKnowing.FlatAppearance.BorderSize = 2;
                    iconButtonNoKnowing.FlatAppearance.BorderColor = Color.Red;
                    break;
            }

        }

        private void FormSimplePractice_Load(object sender, EventArgs e)
        {
            buttonNextWord.Visible = false;
            panelTranslating.Visible = false;

            labelTheWord.Text = dtRunTime.Rows[0].ItemArray[0].ToString().Replace("  ",string.Empty);
            labelWordHebrew.Text  = dtRunTime.Rows[0].ItemArray[1].ToString().Replace("  ", string.Empty);
            colorID = int.Parse(dtRunTime.Rows[0].ItemArray[2].ToString());
            idWord = int.Parse(dtRunTime.Rows[0].ItemArray[3].ToString());
            //dt.Rows[0].ItemArray[2].ToString();

            ss.Rate = -2;
            ss.Volume = 100;
            ss.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Teen);

            //PromptBuilder builder = new PromptBuilder();
            //builder.AppendText(labelTheWord.Text.ToString());
            ss.SpeakAsync(labelTheWord.Text.ToString());
            labelWordsLeft.Text = dtRunTime.Rows.Count.ToString();

            switch(colorID)
            {
                case 1:
                    iconButtonKnowing.FlatAppearance.BorderSize = 2;
                    iconButtonKnowing.FlatAppearance.BorderColor = Color.Red;
                    break;
                case 2:
                    iconButtonHalfKnowing.FlatAppearance.BorderSize = 2;
                    iconButtonHalfKnowing.FlatAppearance.BorderColor = Color.Red;
                    break;
                case 3:
                    iconButtonNoKnowing.FlatAppearance.BorderSize = 2;
                    iconButtonNoKnowing.FlatAppearance.BorderColor = Color.Red;
                    break;
            }
        }

        private void iconButtonSpeaker_Click(object sender, EventArgs e)
        {
            ss.SpeakAsync(labelTheWord.Text.ToString());
        }

        public void MoveDataRowTo(DataRow dataRow, int destination)
        {
            DataTable parentTable = dataRow.Table;
            int rowIndex = parentTable.Rows.IndexOf(dataRow);

            //if (rowIndex > 0)
            //{
                DataRow newDataRow = parentTable.NewRow();

                for (int index = 0; index < dataRow.ItemArray.Length; index++)
                    newDataRow[index] = dataRow[index];

                parentTable.Rows.Remove(dataRow);
                parentTable.Rows.InsertAt(newDataRow, destination);

                dataRow = newDataRow;
                //return dataRow;
            //}
            //return dataRow;
        }

        private void iconButtonNoKnowing_Click(object sender, EventArgs e)

        {
            int ok;
            if (colorID != 3)
            {
                itemCheckColor = 3;
                ok = dsq.updateTypeWord(idWord, itemCheckColor);
                if (ok == 0) // Failed to update
                {
                    MessageBox.Show("בעיה לא מוכרת בנסיון העדכון");
                }
                else
                {
                    if (userKnowsTheWord == false)
                    {
                        DataRow row = dtRunTime.Select("ID=" + idWord).FirstOrDefault();
                        row["WordsType"] = 3;
                    }
                    //dataGridView1.Rows[DGVrowIndex].Cells[colorText].Value = itemCheckColor;
                    //DataRow row = tb.Select("ID=" + idWord).FirstOrDefault();
                    //row["WordsType"] = 1;
                    //dataGridView1.Focus();
                    //buttonNextWord_Click(sender, e);
                }
            }
            if (buttonNextWord.Visible == true)
            {
                buttonNextWord_Click(sender, e);
            }
            else
            {
                iconButtonKnowing.FlatAppearance.BorderSize = 0;
                iconButtonHalfKnowing.FlatAppearance.BorderSize = 0;
                iconButtonNoKnowing.FlatAppearance.BorderSize = 0;
                iconButtonNoKnowing.FlatAppearance.BorderSize = 2;
                iconButtonNoKnowing.FlatAppearance.BorderColor = Color.Red;
            }
        }

        private void iconButtonHalfKnowing_Click(object sender, EventArgs e)
        {
            int ok;
            if (colorID != 2)
            {
                itemCheckColor = 2;
                ok = dsq.updateTypeWord(idWord, itemCheckColor);
                if (ok == 0) // Failed to update
                {
                    MessageBox.Show("בעיה לא מוכרת בנסיון העדכון");
                }
                else
                {
                    if (userKnowsTheWord == false)
                    {
                        DataRow row = dtRunTime.Select("ID=" + idWord).FirstOrDefault();
                        row["WordsType"] = 2;
                    }
                    //dataGridView1.Rows[DGVrowIndex].Cells[colorText].Value = itemCheckColor;
                    //DataRow row = tb.Select("ID=" + idWord).FirstOrDefault();
                    //row["WordsType"] = 1;
                    //dataGridView1.Focus();
                    //buttonNextWord_Click(sender, e);
                }
            }
            if (buttonNextWord.Visible == true)
            {
                buttonNextWord_Click(sender, e);
            }
            else
            {
                iconButtonKnowing.FlatAppearance.BorderSize = 0;
                iconButtonHalfKnowing.FlatAppearance.BorderSize = 0;
                iconButtonNoKnowing.FlatAppearance.BorderSize = 0;
                iconButtonHalfKnowing.FlatAppearance.BorderSize = 2;
                iconButtonHalfKnowing.FlatAppearance.BorderColor = Color.Red;
            }
        }

        private void iconButtonKnowing_Click(object sender, EventArgs e)
        {
            int ok;
            if (colorID != 1)
            {
                itemCheckColor = 1;
                ok = dsq.updateTypeWord(idWord, itemCheckColor);
                if (ok == 0) // Failed to update
                {
                    MessageBox.Show("בעיה לא מוכרת בנסיון העדכון");
                }
                else
                {
                    if(userKnowsTheWord == false)
                    {
                        DataRow row = dtRunTime.Select("ID=" + idWord).FirstOrDefault();
                        row["WordsType"] = 1;
                    }
                    //dataGridView1.Rows[DGVrowIndex].Cells[colorText].Value = itemCheckColor;
                    //DataRow row = tb.Select("ID=" + idWord).FirstOrDefault();
                    //row["WordsType"] = 1;
                    //dataGridView1.Focus();
                    //buttonNextWord_Click(sender, e);
                }
            }
            if (buttonNextWord.Visible == true)
            {
                buttonNextWord_Click(sender, e);
            }
            else
            {
                iconButtonKnowing.FlatAppearance.BorderSize = 0;
                iconButtonHalfKnowing.FlatAppearance.BorderSize = 0;
                iconButtonNoKnowing.FlatAppearance.BorderSize = 0;
                iconButtonKnowing.FlatAppearance.BorderSize = 2;
                iconButtonKnowing.FlatAppearance.BorderColor = Color.Red;
            }
        }

        private void listViewFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFilterType.FocusedItem == null)
                return;
            int p = listViewFilterType.FocusedItem.Index;
            if (listViewFilterType.Items[p].Checked == true && listViewFilterType.SelectedItems.Count >= 1)
                listViewFilterType.Items[p].Checked = false;
            else
                if (listViewFilterType.SelectedItems.Count >= 1)
                listViewFilterType.Items[p].Checked = true;



            listViewFilterType.SelectedItems.Clear();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (buttonNextWord.Visible == false)
            {
                FilterText = "";
                buttonUnfilter.Enabled = true;
                checkSelectedType = CheckSelectedType(listViewFilterType);
                if (checkSelectedType == true) // at least one color is selected for filtering
                {
                    for (int i = 0; i < listViewFilterType.Items.Count; i++)
                    {
                        if (listViewFilterType.Items[i].Checked == true)
                        {
                            FilterText += "WordsType = " + (i + 1).ToString();
                            //TypeGroup[i] = true;
                            FilterText += " OR ";
                        }
                    }
                    FilterText = FilterText.Remove(FilterText.Length - 3, 3);
                    //dtOrginal = dtRunTime;
                    dtRunTime = dtRunTime.Select("" + FilterText).CopyToDataTable();
                    //need to update to first word
                    if (dtRunTime != null && dtRunTime.Rows.Count > 0)
                    {
                        labelTheWord.Text = dtRunTime.Rows[0].ItemArray[0].ToString().Replace("  ", string.Empty);
                        labelWordHebrew.Text = dtRunTime.Rows[0].ItemArray[1].ToString().Replace("  ", string.Empty);
                        colorID = int.Parse(dtRunTime.Rows[0].ItemArray[2].ToString());
                        idWord = int.Parse(dtRunTime.Rows[0].ItemArray[3].ToString());
                        labelWordsLeft.Text = dtRunTime.Rows.Count.ToString();


                        ss.SpeakAsync(labelTheWord.Text.ToString());

                        iconButtonKnowing.FlatAppearance.BorderSize = 0;
                        iconButtonHalfKnowing.FlatAppearance.BorderSize = 0;
                        iconButtonNoKnowing.FlatAppearance.BorderSize = 0;


                        switch (colorID)
                        {
                            case 1:
                                iconButtonKnowing.FlatAppearance.BorderSize = 2;
                                iconButtonKnowing.FlatAppearance.BorderColor = Color.Red;
                                break;
                            case 2:
                                iconButtonHalfKnowing.FlatAppearance.BorderSize = 2;
                                iconButtonHalfKnowing.FlatAppearance.BorderColor = Color.Red;
                                break;
                            case 3:
                                iconButtonNoKnowing.FlatAppearance.BorderSize = 2;
                                iconButtonNoKnowing.FlatAppearance.BorderColor = Color.Red;
                                break;
                        }
                    }
                    else
                    {
                        textForMeesageBox = "אין מילים לתרגול בסינון זה , בחר אחר";
                        myMessageBox = new MyMessageBox(textForMeesageBox);
                        myMessageBox.ShowDialog();
                    }


                }
                else
                {
                    textForMeesageBox = "חובה לבחור לפחות צבע אחד לסינון";
                    myMessageBox = new MyMessageBox(textForMeesageBox);
                    myMessageBox.ShowDialog();
                }
                listViewFilterType.Enabled = false;
                buttonFilter.Enabled = false;
            }
            else
            {
                textForMeesageBox = "לחץ קודם על המילה הבאה ";
                myMessageBox = new MyMessageBox(textForMeesageBox);
                myMessageBox.ShowDialog();
            }
        }

        private bool CheckSelectedType(ListView lsv)
        { // check if there any checked item
            foreach (ListViewItem item in lsv.Items)
            {
                if (item.Checked)
                {
                    return true;
                }
            }
            return
                 false;
        }

        private void buttonUnfilter_Click(object sender, EventArgs e)
        {
            if (buttonNextWord.Visible == false)
            {
                dtRunTime = dtOrginal;

                labelTheWord.Text = dtRunTime.Rows[0].ItemArray[0].ToString().Replace("  ", string.Empty);
                labelWordHebrew.Text = dtRunTime.Rows[0].ItemArray[1].ToString().Replace("  ", string.Empty);
                colorID = int.Parse(dtRunTime.Rows[0].ItemArray[2].ToString());
                idWord = int.Parse(dtRunTime.Rows[0].ItemArray[3].ToString());
                labelWordsLeft.Text = dtRunTime.Rows.Count.ToString();


                ss.SpeakAsync(labelTheWord.Text.ToString());

                iconButtonKnowing.FlatAppearance.BorderSize = 0;
                iconButtonHalfKnowing.FlatAppearance.BorderSize = 0;
                iconButtonNoKnowing.FlatAppearance.BorderSize = 0;

                switch (colorID)
                {
                    case 1:
                        iconButtonKnowing.FlatAppearance.BorderSize = 2;
                        iconButtonKnowing.FlatAppearance.BorderColor = Color.Red;
                        break;
                    case 2:
                        iconButtonHalfKnowing.FlatAppearance.BorderSize = 2;
                        iconButtonHalfKnowing.FlatAppearance.BorderColor = Color.Red;
                        break;
                    case 3:
                        iconButtonNoKnowing.FlatAppearance.BorderSize = 2;
                        iconButtonNoKnowing.FlatAppearance.BorderColor = Color.Red;
                        break;
                }
                buttonFilter.Enabled = true;
                buttonUnfilter.Enabled = false;
                listViewFilterType.Enabled = true;
                for (int i = 0; i < listViewFilterType.Items.Count; i++)
                {
                    listViewFilterType.Items[i].Checked = true;
                }
            }
            else
            {
                textForMeesageBox = "לחץ קודם על המילה הבאה ";
                myMessageBox = new MyMessageBox(textForMeesageBox);
                myMessageBox.ShowDialog();
            }
        }
    }
}
