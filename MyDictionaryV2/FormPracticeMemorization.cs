using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using FontAwesome.Sharp;
using System.Speech.Synthesis;

namespace MyDictionaryV2
{
    public partial class FormPracticeMemorization : Form
    {
        //DataTable tbUpdate;
        MyMessageBox myMessageBox;
        DataTable tbFilter = new DataTable();
        DataTable tb = new DataTable();
        DataTable dtWordInfo = new DataTable();
        DataView dvFilter;
        DAL_SQL_Queries dsq = new DAL_SQL_Queries();
        SpeechSynthesizer ss = new SpeechSynthesizer();
        SpeechSynthesizer ss2Speed = new SpeechSynthesizer();
        Color mycolor = Color.Blue;
        int newAlpha = 255;
        //Color newColor = Color.FromArgb(newAlpha, mycolor);
        //DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

        private Form currentChildForm; //represents the current form that open

        //int voiceColumn = 0;
        int voicetext = 0;
        int colorText = 2;

        int itemCheckColor;
        //int idWardForColor;

        int DGVrowIndex;

        //int hightPanel1 = 115;
        //int hightPanelFilter = 185;
        int withPanelFilter;// 
        bool panelFilterBool = false; // 

        int allPageNumber;
        int pageNum = 1;
        int pageSize;

        string FilterText = "";
        string textForMeesageBox;
        public string Word { get; set; }
        public int idWord { get; set; }
        bool checkSelectedType;
        bool helpBoolForgroup = false;

        //bool panelFilterBool = true;
        //bool[] TypeGroup = new bool[4];

        //IconButton iconButSpeaker = new IconButton();
        DataGridViewButtonColumn iconButSpeaker = new DataGridViewButtonColumn();
        IconButton icoButNew = new IconButton();

        public FormPracticeMemorization(DataTable tb2)
        {
            InitializeComponent();
            tb = tb2;
        }

        private void FormPracticeMemorization_Load(object sender, EventArgs e)
        {
            helpBoolForgroup = false;

            //tb = dsq.getdata();
            dataGridView1.DataSource = tb;
            //dataGridView1.RightToLeft = RightToLeft.Yes;

            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            

            
            ////style.BackColor = Color.Red;
           
            //iconButSpeaker.Name = "";
            ////iconButSpeaker.HeaderText = "";
            //iconButSpeaker.Text = "";
            //iconButSpeaker.UseColumnTextForButtonValue = true; //dont forget this line
            // iconButSpeaker.FlatStyle = FlatStyle.Flat;
            //iconButSpeaker.DividerWidth = 0;
            ////iconButSpeaker.
            ////iconButSpeaker.
            //this.dataGridView1.Columns.Add(iconButSpeaker);


            //this.dataGridView1.Columns.Add(icoButNew);
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            //dataGridView1.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridView1.Columns[0].HeaderText = "מילה באנגלית";
            dataGridView1.Columns[1].HeaderText = "מילה בעברית";
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 24.75F, FontStyle.Bold);

            dataGridView1.RowTemplate.Height = 42;

            dataGridView1.Columns[0].FillWeight = 80;
            dataGridView1.Columns[1].FillWeight = 130;
            //dataGridView1.Columns[4].FillWeight = 19;

            //dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            Color newColor = Color.FromArgb(newAlpha, mycolor);
            //dataGridView1.DefaultCellStyle.SelectionBackColor = default;
            //dataGridView1.DefaultCellStyle.SelectionBackColor = newColor;
            //dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ScrollBars = ScrollBars.Vertical;

            //dataGridView1.CurrentCell = dataGridView1[0, dataGridView1.Rows.Count - 1];

            //
            labelSizeGrop.Visible = false;

            dataGridView1.Columns[1].Visible = false; //word in hebrew
            //dataGridView1.Columns[4].Visible = false; // speaker button

            //dataGridView1.RightToLeft = RightToLeft.No;

                    Word = tb.Rows[0].ItemArray[voicetext].ToString();
                    idWord = int.Parse(tb.Rows[0].ItemArray[3].ToString());
                    dtWordInfo = dsq.dataSourceWordRow(idWord);

                    labelWordInEnglish.Text = dtWordInfo.Rows[0].ItemArray[2].ToString();

                    ss2Speed.Rate = -1;
                    ss2Speed.Volume = 100;
                    ss2Speed.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
                    //ss.SelectVoice("Microsoft Zira Desktop");

                    PromptBuilder builder = new PromptBuilder();
                    builder.AppendText(labelWordInEnglish.Text.ToString());
                    ss2Speed.SpeakAsync(builder);

                    labelWordInHebrew.Text = dtWordInfo.Rows[0].ItemArray[1].ToString();

                    if (dtWordInfo.Rows[0].ItemArray[5].ToString() != "")
                        labelExampleSentences.Text = dtWordInfo.Rows[0].ItemArray[5].ToString();

                    if (dtWordInfo.Rows[0].ItemArray[4].ToString() != "")
                        labelExampleWords.Text = dtWordInfo.Rows[0].ItemArray[4].ToString(); //

            if (dtWordInfo.Rows[0].ItemArray[8].ToString() != "") //note
            {
                labelNote.Text = dtWordInfo.Rows[0].ItemArray[8].ToString(); 
                textBoxNote.Text = dtWordInfo.Rows[0].ItemArray[8].ToString();
                textBoxNote.SelectAll();
                textBoxNote.Focus();
            }
            


            DGVrowIndex = 0;
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //if (e.RowIndex < 0)
            //    return;

            ////I supposed your button column is at index 0
            //if (e.ColumnIndex == 0)
            //{
            //    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            //    var w = Properties.Resources.speakerBut.Width;
            //    var h = Properties.Resources.speakerBut.Height;
            //    var x = e.CellBounds.Left + (e.CellBounds.Width - w ) / 2;
            //    var y = e.CellBounds.Top + (e.CellBounds.Height - h ) / 2;

            //    e.Graphics.DrawImage(Properties.Resources.speakerBut, new Rectangle(x, y, w, h));
            //    e.Handled = true;
            //}
        }


        //
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1) // wordInfo
            {
                if (e.ColumnIndex == 0) // check the column is word in english
                {
                    
                    dtWordInfo.Clear();
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    Word = row.Cells[voicetext].Value.ToString();
                    idWord = int.Parse(row.Cells[3].Value.ToString());
                    dtWordInfo = dsq.dataSourceWordRow(idWord);

                    labelWordInEnglish.Text = dtWordInfo.Rows[0].ItemArray[2].ToString().Replace("  ", string.Empty);

                    ss2Speed.Rate = -1;
                    ss2Speed.Volume = 100;
                    ss2Speed.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
                    //ss.SelectVoice("Microsoft Zira Desktop");

                    PromptBuilder builder = new PromptBuilder();
                    builder.AppendText(labelWordInEnglish.Text.ToString());
                    ss2Speed.SpeakAsync(builder);

                    labelWordInHebrew.Text = dtWordInfo.Rows[0].ItemArray[1].ToString().Replace("  ", string.Empty);

                    if (dtWordInfo.Rows[0].ItemArray[5].ToString() != "")
                        labelExampleSentences.Text = dtWordInfo.Rows[0].ItemArray[5].ToString().Replace("     ", string.Empty);
                    else
                    {
                        labelExampleSentences.Text = "אין משפטים לדוגמא";
                    }


                    if (dtWordInfo.Rows[0].ItemArray[4].ToString() != "")
                        labelExampleWords.Text = dtWordInfo.Rows[0].ItemArray[4].ToString().Replace("  ",string.Empty); //
                    else
                    {
                        labelExampleWords.Text = "אין מילים קשורות";
                    }

                    if (dtWordInfo.Rows[0].ItemArray[8].ToString() != "") //note for word
                    {
                        labelNote.Text = dtWordInfo.Rows[0].ItemArray[8].ToString();
                        textBoxNote.Text = dtWordInfo.Rows[0].ItemArray[8].ToString();
                        textBoxNote.SelectAll();
                        textBoxNote.Focus();
                    }
                    else
                    {
                        labelNote.Text = "אין הערה";
                        textBoxNote.Text = "אין הערה";
                        textBoxNote.SelectAll();
                        textBoxNote.Focus();
                    }
                    //dtWordInfo.Clear();

                    //ss2Speed.Rate = 0;
                    //ss2Speed.Volume = 100;
                    //ss2Speed.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
                    ////ss.SelectVoice("Microsoft Zira Desktop");

                    //PromptBuilder builder = new PromptBuilder();
                    //builder.AppendText(labelWordInEnglish.Text.ToString());
                    //ss2Speed.SpeakAsync(builder);


                    DGVrowIndex = e.RowIndex;

                }
            }
            //foreach (var v in ss.GetInstalledVoices().Select(v => v.VoiceInfo))
            //{
            //    Console.WriteLine("Name:{0}, Gender:{1}, Age:{2}",
            //      v.Description, v.Gender, v.Age);
            //}

            ////ss.SetOutputToDefaultAudioDevice();

            //DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            ////ss = new SpeechSynthesizer();
            ////ss. = VoiceGender.Female;
            //ss.Rate = -3;
            //ss.Volume = 100;
            //ss.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            //ss.SelectVoice("Microsoft Zira Desktop");

            //PromptBuilder builder = new PromptBuilder();
            //builder.AppendText(row.Cells[1].Value.ToString());
            //ss.SpeakAsync(builder);
            ////ss.Speak(row.Cells[1].Value.ToString());
            ////ss.GetInstalledVoices();
            //dataGridView1.AreAllCellsSelected(false);
        }
        //

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //if (e.ColumnIndex == voiceColumn)
            //{
            //    foreach (var v in ss.GetInstalledVoices().Select(v => v.VoiceInfo))
            //    {
            //        Console.WriteLine("Name:{0}, Gender:{1}, Age:{2}",
            //          v.Description, v.Gender, v.Age);
            //    }

                //ss.SetOutputToDefaultAudioDevice();

                //DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //ss = new SpeechSynthesizer();
                //ss. = VoiceGender.Female;
                //ss.Rate = -2;
                //ss.Volume = 100;
                //ss.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
                //ss.SelectVoice("Microsoft Zira Desktop");

                //PromptBuilder builder = new PromptBuilder();
                //builder.AppendText(row.Cells[1].Value.ToString());
                //ss.SpeakAsync(builder);
                //ss.Speak(row.Cells[1].Value.ToString());
                //ss.GetInstalledVoices();
                //dataGridView1.AreAllCellsSelected(false);
            //}
            //DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //idWord = int.Parse(row.Cells[4].Value.ToString());
            //openChildForm(new WordInformation(idWord));


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.RowIndex != -1)
            //{
            //    if (e.ColumnIndex != voiceColumn)
            //    {
            //        DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //        Word = row.Cells[voicetext].Value.ToString();

            //        idWord = int.Parse(row.Cells[4].Value.ToString());


            //        WordInformation WordInformation1 = new WordInformation(idWord);
            //        WordInformation1.StartPosition = FormStartPosition.Manual;
            //        WordInformation1.Left = 400;
            //        WordInformation1.Top = 150;
            //        WordInformation1.StartPosition = FormStartPosition.CenterParent;
            //        WordInformation1.ShowDialog();
            //        dataGridView1.Rows[e.RowIndex].Cells[colorText].Value = WordInformation1.itemCheckColor;

            //        openChildForm(new WordInformation(idWord));

            //        if(helpBoolForgroup == true)
            //        {
            //            tbUpdate = dvFilter.ToTable();
            //            DataRow row1 = tbUpdate.Select("ID = " + idWord).FirstOrDefault();
            //            row1["WordsType"] = WordInformation1.itemCheckColor;
            //            DataRow row2 = tb.Select("ID = " + idWord).FirstOrDefault();
            //            row2["WordsType"] = WordInformation1.itemCheckColor;
            //            dvFilter = new DataView(tbUpdate);
            //        }
            //        //dataGridView1.Rows[e.RowIndex].Cells[colorText].Value = WordInformation1.itemCheck;

            //    }
            //}
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            switch (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[colorText].Value.ToString()))
            {
                case 1:
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(193, 246, 167); //
                    break;
                case 2:
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(246, 242, 167); // need to replace to more light color
                    break;
                case 3:
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(245, 158, 158); //
                    break;
                case 4:
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    break;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //this.dataGridView1.ClearSelection();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            labelSizeGrop.Text = trackBar1.Value.ToString();
            //labelSizeGrop.Visible = true;
            checkBoxTitleSizeGruop.Checked = true;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            helpBoolForgroup = false;
            checkSelectedType = CheckSelectedType(listViewFilterType);
            if(checkSelectedType == true) // at least one color is selected for filtering
            {
                FilterText = "";

                for (int i = 0; i < listViewFilterType.Items.Count; i++)
                {
                    if (listViewFilterType.Items[i].Checked == true)
                    {
                        FilterText += "WordsType = " + (i+1).ToString();
                        //TypeGroup[i] = true;
                        FilterText += " OR ";
                    }
                }
                FilterText = FilterText.Remove(FilterText.Length - 3, 3);

                dvFilter = new DataView(tb);
                dvFilter.RowFilter = FilterText;

                if (checkBoxTitleSizeGruop.Checked == false) //without group size
                {
                    timer1.Start();
                    //dvFilter = new DataView(tb);
                    //dvFilter.RowFilter = FilterText;
                    dataGridView1.DataSource = dvFilter;
                    panelPage.Visible = false;
                    helpBoolForgroup = false;
                }
                else //with group size
                {
                    //dataGridView1.Columns[1].Visible = false; //test
                    //dataGridView1.Columns[2].Visible = false; //word in hebrew
                    //dataGridView1.Columns[0].Visible = false; // speaker button
                    //panelWord.Width = 800;
                    //this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 16);
                    if (labelSizeGrop.Visible == true)
                    {
                        panelPage.Visible = true;
                        helpBoolForgroup = true;
                        pageNum = 1;
                        labelTitleCurrentPage.Text = pageNum.ToString();
                        timer1.Start();
                        pageSize = int.Parse(labelSizeGrop.Text.ToString());
                        tbFilter = dvFilter.ToTable().Rows.Cast<System.Data.DataRow>().Skip((pageNum - 1) * pageSize).Take(pageSize).CopyToDataTable();
                        //DataTable dtPage = dt.Rows.Cast<System.Data.DataRow>().Skip((pageNum - 1) * pageSize).Take(pageSize).CopyToDataTable();
                        dataGridView1.DataSource = tbFilter;

                        allPageNumber = dvFilter.Count / pageSize;
                        if(dvFilter.Count % pageSize !=0)
                        {
                            allPageNumber = allPageNumber + 1;
                        }
                        labelAllPages.Text = allPageNumber.ToString();

                        dataGridView1.RowTemplate.Height = 42;
                        this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 20);

                    }
                    else
                    {
                        textForMeesageBox = "להצגת מקבץ חובה לבחור גודל מקבץ";
                        myMessageBox = new MyMessageBox(textForMeesageBox);
                        myMessageBox.ShowDialog();
                    }

                }

            }
            else
            {
                textForMeesageBox = "בחר לפחות צבע אחד לסינון";
                myMessageBox = new MyMessageBox(textForMeesageBox);
                myMessageBox.ShowDialog();
            }

            //timer1.Start();
        }

        private void listViewFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFilterType.FocusedItem == null)
                return;
            int p = listViewFilterType.FocusedItem.Index;
            if (listViewFilterType.Items[p].Checked == true && listViewFilterType.SelectedItems.Count >= 1)
                listViewFilterType.Items[p].Checked = false;
            else
                if(listViewFilterType.SelectedItems.Count >= 1)
                    listViewFilterType.Items[p].Checked = true;



            listViewFilterType.SelectedItems.Clear();
        }

        private void listViewFilterType_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //listViewFilterType.Items[e.Index].Checked = true;
        }

        private bool CheckSelectedType (ListView lsv)
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

        private void buttonClearFilter_Click(object sender, EventArgs e)
        {
            if(FilterText != "")
            {
                dataGridView1.DataSource = tb;
            }
            helpBoolForgroup = false;
            panelPage.Visible = false;

            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);
        }

        private void iconButtonMenuFillter_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            withPanelFilter = panelFilter.Location.X;
            if (panelFilterBool == true)
            {
                if (panel1.Height > 95)
                {
                    //hightPanelFilter += 10;
                    withPanelFilter += 15;
                    //panelFilter.Top = hightPanelFilter;
                    panelFilter.Left = withPanelFilter;
                    panel1.Height -= 10;
                }
                else
                {
                    timer1.Stop();
                    panelFilterBool = false;
                }
                
            }
            else
            {
                if(panel1.Height < 215)
                {
                    
                    //hightPanelFilter -= 10;
                    //panelFilter.Top = hightPanelFilter;
                    withPanelFilter -= 15;
                    panelFilter.Left = withPanelFilter;
                    panel1.Height += 10;
                }
                else
                {
                    timer1.Stop();
                    panelFilterBool = true;
                }

            }

           
        }

        private void iconButtonNextPage_Click(object sender, EventArgs e)
        {
            if (pageNum < allPageNumber) //
            {
                pageNum = pageNum + 1;
                labelTitleCurrentPage.Text = pageNum.ToString();
                tbFilter = dvFilter.ToTable().Rows.Cast<System.Data.DataRow>().Skip((pageNum - 1) * pageSize).Take(pageSize).CopyToDataTable();
                dataGridView1.DataSource = tbFilter;

                dtWordInfo.Clear();
                Word = tbFilter.Rows[0].ItemArray[voicetext].ToString();
                idWord = int.Parse(tbFilter.Rows[0].ItemArray[3].ToString());
                dtWordInfo = dsq.dataSourceWordRow(idWord);

                labelWordInEnglish.Text = dtWordInfo.Rows[0].ItemArray[2].ToString();

                ss2Speed.Rate = -1;
                ss2Speed.Volume = 100;
                ss2Speed.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
                //ss.SelectVoice("Microsoft Zira Desktop");

                PromptBuilder builder = new PromptBuilder();
                builder.AppendText(labelWordInEnglish.Text.ToString());
                ss2Speed.SpeakAsync(builder);

                labelWordInHebrew.Text = dtWordInfo.Rows[0].ItemArray[1].ToString();

                if (dtWordInfo.Rows[0].ItemArray[5].ToString() != "")
                    labelExampleSentences.Text = dtWordInfo.Rows[0].ItemArray[5].ToString();

                if (dtWordInfo.Rows[0].ItemArray[4].ToString() != "")
                    labelExampleWords.Text = dtWordInfo.Rows[0].ItemArray[4].ToString(); //

                if (dtWordInfo.Rows[0].ItemArray[8].ToString() != "") //note
                {
                    labelNote.Text = dtWordInfo.Rows[0].ItemArray[8].ToString();
                    textBoxNote.Text = dtWordInfo.Rows[0].ItemArray[8].ToString();
                    textBoxNote.SelectAll();
                    textBoxNote.Focus();
                }

            }
            else
            {
                textForMeesageBox = "אתה במקבץ האחרון";
                myMessageBox = new MyMessageBox(textForMeesageBox);
                myMessageBox.ShowDialog();
            }
        }

        private void iconButtonpreviousPage_Click(object sender, EventArgs e)
        {
            if(pageNum > 1) // 
            {
                pageNum = pageNum - 1;
                labelTitleCurrentPage.Text = pageNum.ToString();
                tbFilter = dvFilter.ToTable().Rows.Cast<System.Data.DataRow>().Skip((pageNum - 1) * pageSize).Take(pageSize).CopyToDataTable();
                dataGridView1.DataSource = tbFilter;


                dtWordInfo.Clear();
                Word = tbFilter.Rows[0].ItemArray[voicetext].ToString();
                idWord = int.Parse(tbFilter.Rows[0].ItemArray[3].ToString());
                dtWordInfo = dsq.dataSourceWordRow(idWord);

                labelWordInEnglish.Text = dtWordInfo.Rows[0].ItemArray[2].ToString();

                ss2Speed.Rate = -1;
                ss2Speed.Volume = 100;
                ss2Speed.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
                //ss.SelectVoice("Microsoft Zira Desktop");

                PromptBuilder builder = new PromptBuilder();
                builder.AppendText(labelWordInEnglish.Text.ToString());
                ss2Speed.SpeakAsync(builder);

                labelWordInHebrew.Text = dtWordInfo.Rows[0].ItemArray[1].ToString();

                if (dtWordInfo.Rows[0].ItemArray[5].ToString() != "")
                    labelExampleSentences.Text = dtWordInfo.Rows[0].ItemArray[5].ToString();

                if (dtWordInfo.Rows[0].ItemArray[4].ToString() != "")
                    labelExampleWords.Text = dtWordInfo.Rows[0].ItemArray[4].ToString(); //

                if (dtWordInfo.Rows[0].ItemArray[8].ToString() != "") //note
                {
                    labelNote.Text = dtWordInfo.Rows[0].ItemArray[8].ToString();
                    textBoxNote.Text = dtWordInfo.Rows[0].ItemArray[8].ToString();
                    textBoxNote.SelectAll();
                    textBoxNote.Focus();
                }

            }
            else
            {
                textForMeesageBox = "אתה במקבץ הראשון";
                myMessageBox = new MyMessageBox(textForMeesageBox);
                myMessageBox.ShowDialog();
            }
        }

        private void checkBoxTitleSizeGruop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTitleSizeGruop.Checked == true)
            {
                labelSizeGrop.Visible = true;
            }
            else 
            {
                labelSizeGrop.Visible = false;
            }
        }
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
            panelWordInformation.Controls.Add(childForm);
            panelWordInformation.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void iconButtonSpeaker_Click(object sender, EventArgs e)
        {
            ss.Rate = -4;
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
            colorID = int.Parse(dtWordInfo.Rows[0].ItemArray[6].ToString());
            if (colorID != 1)
            {
                itemCheckColor = 1;
                ok = dsq.updateTypeWord((int.Parse(dtWordInfo.Rows[0].ItemArray[0].ToString())), itemCheckColor);
                //dalAcss.updateWordType(itemCheck, id);
                if (ok == 0) // Failed to update
                {
                    MessageBox.Show("בעיה לא מוכרת בנסיון העדכון");
                }
                else
                {
                    dataGridView1.Rows[DGVrowIndex].Cells[colorText].Value = itemCheckColor;
                    DataRow row = tb.Select("ID=" + idWord).FirstOrDefault();
                    row["WordsType"] = 1;
                    dataGridView1.Focus();
                }
            }
        }

        private void iconButtonHalfKnowing_Click(object sender, EventArgs e)
        {
            int ok;
            int colorID;
            colorID = int.Parse(dtWordInfo.Rows[0].ItemArray[6].ToString());
            if (colorID != 2)
            {
                itemCheckColor = 2;
                ok = dsq.updateTypeWord((int.Parse(dtWordInfo.Rows[0].ItemArray[0].ToString())), itemCheckColor);
                //dalAcss.updateWordType(itemCheck, id);
                if (ok == 0) // Failed to update
                {
                    MessageBox.Show("בעיה לא מוכרת בנסיון העדכון");
                }
                else
                {
                    dataGridView1.Rows[DGVrowIndex].Cells[colorText].Value = itemCheckColor;
                    DataRow row = tb.Select("ID=" + idWord).FirstOrDefault();
                    row["WordsType"] = 2;
                    dataGridView1.Focus();
                }
            }
        }

        private void iconButtonNoKnowing_Click(object sender, EventArgs e)
        {
            int ok;
            int colorID;
            colorID = int.Parse(dtWordInfo.Rows[0].ItemArray[6].ToString());
            if (colorID != 3)
            {
                itemCheckColor = 3;
                ok = dsq.updateTypeWord((int.Parse(dtWordInfo.Rows[0].ItemArray[0].ToString())), itemCheckColor);
                //dalAcss.updateWordType(itemCheck, id);
                if (ok == 0) // Failed to update
                {
                    MessageBox.Show("בעיה לא מוכרת בנסיון העדכון");
                }
                else
                {
                    dataGridView1.Rows[DGVrowIndex].Cells[colorText].Value = itemCheckColor;
                    DataRow row = tb.Select("ID=" + idWord).FirstOrDefault();
                    row["WordsType"] = 3;
                    dataGridView1.Focus();
                }
            }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void labelWordInHebrew_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNote_Enter(object sender, EventArgs e)
        {
            
        }

        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            //can add some  validate user input 
            //
            int updadeNote;
            updadeNote = dsq.updateNoteWord(textBoxNote.Text.ToString(), idWord);
            labelNote.Text = textBoxNote.Text.ToString();
            if (string.IsNullOrEmpty(textBoxNote.Text))
            {
                textBoxNote.Text = "אין הערה";
                labelNote.Text = "אין הערה";
            }
            else
            {
                labelNote.Text = textBoxNote.Text.ToString();
            }
            textBoxNote.SelectAll();
            textBoxNote.Focus();

        }
    }
}
