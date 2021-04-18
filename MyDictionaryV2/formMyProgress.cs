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
    public partial class formMyProgress : Form
    {
        public formMyProgress()
        {
            InitializeComponent();
            //backgroundWorker1.RunWorkerAsync();
        }
        DAL_SQL_Queries dsq = new DAL_SQL_Queries();
        DataTable dt = new DataTable();
        int [] knowWords = new int [10];  //start from 0 - [0] is uint 1
        int[] countWords = new int[10];   //start from 0 - [0] is uint 1
        double [] precentArr = new double [10];  //start from 0 - [0] is uint 1

        int counterSec = 3;
        

        private void formMyProgress_Load(object sender, EventArgs e)
        {
            //timer1.Start();
            circularProgressBarLoading.Visible = true;
            panelUnit1.Visible = false;
            panelUnit2.Visible = false;
            panelUnit3.Visible = false;
            panelUnit4.Visible = false;
            panelUnit5.Visible = false;
            panelUnit6.Visible = false;
            panelUnit7.Visible = false;
            panelUnit8.Visible = false;
            panelUnit9.Visible = false;
            panelUnit10.Visible = false;

            //dt = dsq.getallUnintAndType();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    switch (int.Parse(dt.Rows[i].ItemArray[0].ToString()))
            //    {
            //        case 1:
            //            countWords[0] = countWords[0] + 1;
            //            if (int.Parse(dt.Rows[i].ItemArray[1].ToString()) == 1)
            //            {
            //                knowWords[0] = knowWords[0] + 1;
            //            }
            //            break;
            //        case 2:
            //            countWords[1] = countWords[1] + 1;
            //            if (int.Parse(dt.Rows[i].ItemArray[1].ToString()) == 1)
            //            {
            //                knowWords[1] = knowWords[1] + 1;
            //            }
            //            break;
            //        case 3:
            //            countWords[2] = countWords[2] + 1;
            //            if (int.Parse(dt.Rows[i].ItemArray[1].ToString()) == 1)
            //            {
            //                knowWords[2] = knowWords[2] + 1;
            //            }
            //            break;
            //        case 4:
            //            countWords[3] = countWords[3] + 1;
            //            if (int.Parse(dt.Rows[i].ItemArray[1].ToString()) == 1)
            //            {
            //                knowWords[3] = knowWords[3] + 1;
            //            }
            //            break;
            //        case 5:
            //            countWords[4] = countWords[4] + 1;
            //            if (int.Parse(dt.Rows[i].ItemArray[1].ToString()) == 1)
            //            {
            //                knowWords[4] = knowWords[4] + 1;
            //            }
            //            break;
            //        case 6:
            //            countWords[5] = countWords[5] + 1;
            //            if (int.Parse(dt.Rows[i].ItemArray[1].ToString()) == 1)
            //            {
            //                knowWords[5] = knowWords[5] + 1;
            //            }
            //            break;
            //        case 7:
            //            countWords[6] = countWords[6] + 1;
            //            if (int.Parse(dt.Rows[i].ItemArray[1].ToString()) == 1)
            //            {
            //                knowWords[6] = knowWords[6] + 1;
            //            }
            //            break;
            //        case 8:
            //            countWords[7] = countWords[7] + 1;
            //            if (int.Parse(dt.Rows[i].ItemArray[1].ToString()) == 1)
            //            {
            //                knowWords[7] = knowWords[7] + 1;
            //            }
            //            break;
            //        case 9:
            //            countWords[8] = countWords[8] + 1;
            //            if (int.Parse(dt.Rows[i].ItemArray[1].ToString()) == 1)
            //            {
            //                knowWords[8] = knowWords[8] + 1;
            //            }
            //            break;
            //        case 10:
            //            countWords[9] = countWords[9] + 1;
            //            if (int.Parse(dt.Rows[i].ItemArray[1].ToString()) == 1)
            //            {
            //                knowWords[9] = knowWords[9] + 1;
            //            }
            //            break;
            //    }
            //}

            //for (int h = 0; h < 10; h++)
            //{
            //    if (countWords[h] > 0)
            //    {
            //        if (knowWords[h] > 0)
            //        {
            //            precentArr[h] = double.Parse(knowWords[h].ToString()) / double.Parse(countWords[h].ToString());
            //            precentArr[h] = precentArr[h] * 100;
            //        }
            //        else
            //        {
            //            // add here check - 0%
            //        }
            //    }
            //    else
            //    {
            //        // no worda in this unit yet
            //    }

            //}
            //for (int k = 0; k < 10; k++)
            //{
            //    switch (k)
            //    {
            //        case 0: // unit 1
            //            if (countWords[k] == 0)
            //            {
            //                labelAllWordsInUint1Value.Text = "0";
            //                labelWorsIKnowUnit1Value.Text = "0";
            //                circularProgressBarUnit1.Value = 0;
            //                circularProgressBarUnit1.Text = "0%";
            //            }
            //            else
            //            {
            //                labelAllWordsInUint1Value.Text = countWords[k].ToString();
            //                if (knowWords[k] == 0)
            //                {
            //                    labelWorsIKnowUnit1Value.Text = "0";
            //                    circularProgressBarUnit1.Value = 0;
            //                    circularProgressBarUnit1.Text = "0%";
            //                }
            //                else
            //                {
            //                    labelWorsIKnowUnit1Value.Text = Convert.ToInt32(knowWords[k]).ToString();
            //                    circularProgressBarUnit1.Value = Convert.ToInt32(Convert.ToInt32(knowWords[k]).ToString());
            //                    circularProgressBarUnit1.Text = Convert.ToInt32(knowWords[k]).ToString() + "%";
            //                }
            //            }

            //            break;
            //        case 1:
            //            if (countWords[k] == 0)
            //            {
            //                labelAllWordsInUint2Value.Text = "0";
            //                labelWorsIKnowUnit2Value.Text = "0";
            //                circularProgressBarUnit2.Value = 0;
            //                circularProgressBarUnit2.Text = "0%";
            //            }
            //            else
            //            {
            //                labelAllWordsInUint2Value.Text = countWords[k].ToString();
            //                if (knowWords[k] == 0)
            //                {
            //                    labelWorsIKnowUnit2Value.Text = "0";
            //                    circularProgressBarUnit2.Value = 0;
            //                    circularProgressBarUnit2.Text = "0%";
            //                }
            //                else
            //                {
            //                    labelWorsIKnowUnit2Value.Text = Convert.ToInt32(knowWords[k]).ToString();
            //                    circularProgressBarUnit2.Value = Convert.ToInt32(Convert.ToInt32(knowWords[k]).ToString());
            //                    circularProgressBarUnit2.Text = Convert.ToInt32(knowWords[k]).ToString() + "%";
            //                }
            //            }
            //            break;
            //        case 2:
            //            if (countWords[k] == 0)
            //            {
            //                labelAllWordsInUint3Value.Text = "0";
            //                labelWorsIKnowUnit3Value.Text = "0";
            //                circularProgressBarUnit3.Value = 0;
            //                circularProgressBarUnit3.Text = "0%";
            //            }
            //            else
            //            {
            //                labelAllWordsInUint3Value.Text = countWords[k].ToString();
            //                if (knowWords[k] == 0)
            //                {
            //                    labelWorsIKnowUnit3Value.Text = "0";
            //                    circularProgressBarUnit3.Value = 0;
            //                    circularProgressBarUnit3.Text = "0%";
            //                }
            //                else
            //                {
            //                    labelWorsIKnowUnit3Value.Text = Convert.ToInt32(knowWords[k]).ToString();
            //                    circularProgressBarUnit3.Value = Convert.ToInt32(Convert.ToInt32(knowWords[k]).ToString());
            //                    circularProgressBarUnit3.Text = Convert.ToInt32(knowWords[k]).ToString() + "%";
            //                }
            //            }
            //            break;
            //        case 3:
            //            if (countWords[k] == 0)
            //            {
            //                labelAllWordsInUint4Value.Text = "0";
            //                labelWorsIKnowUnit4Value.Text = "0";
            //                circularProgressBarUnit4.Value = 0;
            //                circularProgressBarUnit4.Text = "0%";
            //            }
            //            else
            //            {
            //                labelAllWordsInUint4Value.Text = countWords[k].ToString();
            //                if (knowWords[k] == 0)
            //                {
            //                    labelWorsIKnowUnit4Value.Text = "0";
            //                    circularProgressBarUnit4.Value = 0;
            //                    circularProgressBarUnit4.Text = "0%";
            //                }
            //                else
            //                {
            //                    labelWorsIKnowUnit4Value.Text = Convert.ToInt32(knowWords[k]).ToString();
            //                    circularProgressBarUnit4.Value = Convert.ToInt32(Convert.ToInt32(knowWords[k]).ToString());
            //                    circularProgressBarUnit4.Text = Convert.ToInt32(knowWords[k]).ToString() + "%";
            //                }
            //            }
            //            break;
            //        case 4:
            //            if (countWords[k] == 0)
            //            {
            //                labelAllWordsInUint5Value.Text = "0";
            //                labelWorsIKnowUnit5Value.Text = "0";
            //                circularProgressBarUnit5.Value = 0;
            //                circularProgressBarUnit5.Text = "0%";
            //            }
            //            else
            //            {
            //                labelAllWordsInUint5Value.Text = countWords[k].ToString();
            //                if (knowWords[k] == 0)
            //                {
            //                    labelWorsIKnowUnit5Value.Text = "0";
            //                    circularProgressBarUnit5.Value = 0;
            //                    circularProgressBarUnit5.Text = "0%";
            //                }
            //                else
            //                {
            //                    labelWorsIKnowUnit5Value.Text = Convert.ToInt32(knowWords[k]).ToString();
            //                    circularProgressBarUnit5.Value = Convert.ToInt32(Convert.ToInt32(knowWords[k]).ToString());
            //                    circularProgressBarUnit5.Text = Convert.ToInt32(knowWords[k]).ToString() + "%";
            //                }
            //            }
            //            break;
            //        case 5:
            //            if (countWords[k] == 0)
            //            {
            //                labelAllWordsInUint6Value.Text = "0";
            //                labelWorsIKnowUnit6Value.Text = "0";
            //                circularProgressBarUnit6.Value = 0;
            //                circularProgressBarUnit6.Text = "0%";
            //            }
            //            else
            //            {
            //                labelAllWordsInUint6Value.Text = countWords[k].ToString();
            //                if (knowWords[k] == 0)
            //                {
            //                    labelWorsIKnowUnit6Value.Text = "0";
            //                    circularProgressBarUnit6.Value = 0;
            //                    circularProgressBarUnit6.Text = "0%";
            //                }
            //                else
            //                {
            //                    labelWorsIKnowUnit6Value.Text = Convert.ToInt32(knowWords[k]).ToString();
            //                    circularProgressBarUnit6.Value = Convert.ToInt32(Convert.ToInt32(knowWords[k]).ToString());
            //                    circularProgressBarUnit6.Text = Convert.ToInt32(knowWords[k]).ToString() + "%";
            //                }
            //            }
            //            break;
            //        case 6:
            //            if (countWords[k] == 0)
            //            {
            //                labelAllWordsInUint7Value.Text = "0";
            //                labelWorsIKnowUnit7Value.Text = "0";
            //                circularProgressBarUnit7.Value = 0;
            //                circularProgressBarUnit7.Text = "0%";
            //            }
            //            else
            //            {
            //                labelAllWordsInUint7Value.Text = countWords[k].ToString();
            //                if (knowWords[k] == 0)
            //                {
            //                    labelWorsIKnowUnit7Value.Text = "0";
            //                    circularProgressBarUnit7.Value = 0;
            //                    circularProgressBarUnit7.Text = "0%";
            //                }
            //                else
            //                {
            //                    labelWorsIKnowUnit7Value.Text = Convert.ToInt32(knowWords[k]).ToString();
            //                    circularProgressBarUnit7.Value = Convert.ToInt32(Convert.ToInt32(knowWords[k]).ToString());
            //                    circularProgressBarUnit7.Text = Convert.ToInt32(knowWords[k]).ToString() + "%";
            //                }
            //            }
            //            break;
            //        case 7:
            //            if (countWords[k] == 0)
            //            {
            //                labelAllWordsInUint8Value.Text = "0";
            //                labelWorsIKnowUnit8Value.Text = "0";
            //                circularProgressBarUnit8.Value = 0;
            //                circularProgressBarUnit8.Text = "0%";
            //            }
            //            else
            //            {
            //                labelAllWordsInUint8Value.Text = countWords[k].ToString();
            //                if (knowWords[k] == 0)
            //                {
            //                    labelWorsIKnowUnit8Value.Text = "0";
            //                    circularProgressBarUnit8.Value = 0;
            //                    circularProgressBarUnit8.Text = "0%";
            //                }
            //                else
            //                {
            //                    labelWorsIKnowUnit8Value.Text = Convert.ToInt32(knowWords[k]).ToString();
            //                    circularProgressBarUnit8.Value = Convert.ToInt32(Convert.ToInt32(knowWords[k]).ToString());
            //                    circularProgressBarUnit8.Text = Convert.ToInt32(knowWords[k]).ToString() + "%";
            //                }
            //            }
            //            break;
            //        case 8:
            //            if (countWords[k] == 0)
            //            {
            //                labelAllWordsInUint9Value.Text = "0";
            //                labelWorsIKnowUnit9Value.Text = "0";
            //                circularProgressBarUnit9.Value = 0;
            //                circularProgressBarUnit9.Text = "0%";
            //            }
            //            else
            //            {
            //                labelAllWordsInUint9Value.Text = countWords[k].ToString();
            //                if (knowWords[k] == 0)
            //                {
            //                    labelWorsIKnowUnit9Value.Text = "0";
            //                    circularProgressBarUnit9.Value = 0;
            //                    circularProgressBarUnit9.Text = "0%";
            //                }
            //                else
            //                {
            //                    labelWorsIKnowUnit9Value.Text = Convert.ToInt32(knowWords[k]).ToString();
            //                    circularProgressBarUnit9.Value = Convert.ToInt32(Convert.ToInt32(knowWords[k]).ToString());
            //                    circularProgressBarUnit9.Text = Convert.ToInt32(knowWords[k]).ToString() + "%";
            //                }
            //            }
            //            break;
            //        case 9:
            //            if (countWords[k] == 0)
            //            {
            //                labelAllWordsInUint10Value.Text = "0";
            //                labelWorsIKnowUnit10Value.Text = "0";
            //                circularProgressBarUnit10.Value = 0;
            //                circularProgressBarUnit10.Text = "0%";
            //            }
            //            else
            //            {
            //                labelAllWordsInUint10Value.Text = countWords[k].ToString();
            //                if (knowWords[k] == 0)
            //                {
            //                    labelWorsIKnowUnit10Value.Text = "0";
            //                    circularProgressBarUnit10.Value = 0;
            //                    circularProgressBarUnit10.Text = "0%";
            //                }
            //                else
            //                {
            //                    labelWorsIKnowUnit10Value.Text = Convert.ToInt32(knowWords[k]).ToString();
            //                    circularProgressBarUnit10.Value = Convert.ToInt32(Convert.ToInt32(knowWords[k]).ToString());
            //                    circularProgressBarUnit10.Text = Convert.ToInt32(knowWords[k]).ToString() + "%";
            //                }
            //            }
            //            break;
            //    }





            //}
            //backgroundWorker1.RunWorkerAsync();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

            private void circularProgressBarLoading_VisibleChanged(object sender, EventArgs e)
            {

            }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            dt = dsq.getallUnintAndType();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                switch (int.Parse(dt.Rows[i].ItemArray[0].ToString()))
                {
                    case 1:
                        countWords[0] = countWords[0] + 1;
                        if (int.Parse(dt.Rows[i].ItemArray[1].ToString()) == 1)
                        {
                            knowWords[0] = knowWords[0] + 1;
                        }
                        break;
                    case 2:
                        countWords[1] = countWords[1] + 1;
                        if (int.Parse(dt.Rows[i].ItemArray[1].ToString()) == 1)
                        {
                            knowWords[1] = knowWords[1] + 1;
                        }
                        break;
                    case 3:
                        countWords[2] = countWords[2] + 1;
                        if (int.Parse(dt.Rows[i].ItemArray[1].ToString()) == 1)
                        {
                            knowWords[2] = knowWords[2] + 1;
                        }
                        break;
                    case 4:
                        countWords[3] = countWords[3] + 1;
                        if (int.Parse(dt.Rows[i].ItemArray[1].ToString()) == 1)
                        {
                            knowWords[3] = knowWords[3] + 1;
                        }
                        break;
                    case 5:
                        countWords[4] = countWords[4] + 1;
                        if (int.Parse(dt.Rows[i].ItemArray[1].ToString()) == 1)
                        {
                            knowWords[4] = knowWords[4] + 1;
                        }
                        break;
                    case 6:
                        countWords[5] = countWords[5] + 1;
                        if (int.Parse(dt.Rows[i].ItemArray[1].ToString()) == 1)
                        {
                            knowWords[5] = knowWords[5] + 1;
                        }
                        break;
                    case 7:
                        countWords[6] = countWords[6] + 1;
                        if (int.Parse(dt.Rows[i].ItemArray[1].ToString()) == 1)
                        {
                            knowWords[6] = knowWords[6] + 1;
                        }
                        break;
                    case 8:
                        countWords[7] = countWords[7] + 1;
                        if (int.Parse(dt.Rows[i].ItemArray[1].ToString()) == 1)
                        {
                            knowWords[7] = knowWords[7] + 1;
                        }
                        break;
                    case 9:
                        countWords[8] = countWords[8] + 1;
                        if (int.Parse(dt.Rows[i].ItemArray[1].ToString()) == 1)
                        {
                            knowWords[8] = knowWords[8] + 1;
                        }
                        break;
                    case 10:
                        countWords[9] = countWords[9] + 1;
                        if (int.Parse(dt.Rows[i].ItemArray[1].ToString()) == 1)
                        {
                            knowWords[9] = knowWords[9] + 1;
                        }
                        break;
                }
            }

            for (int h = 0; h < 10; h++)
            {
                if (countWords[h] > 0)
                {
                    if (knowWords[h] > 0)
                    {
                        precentArr[h] = double.Parse(knowWords[h].ToString()) / double.Parse(countWords[h].ToString());
                        precentArr[h] = precentArr[h] * 100;
                    }
                    else
                    {
                        // add here check - 0%
                    }
                }
                else
                {
                    // no worda in this unit yet
                }

            }
            //for (int k = 0; k < 10; k++)
            //{
            //    switch (k)
            //    {
            //        case 0: // unit 1
            //            if (countWords[k] == 0)
            //            {
            //                labelAllWordsInUint1Value.Text = "0";
            //                labelWorsIKnowUnit1Value.Text = "0";
            //                circularProgressBarUnit1.Value = 0;
            //                circularProgressBarUnit1.Text = "0%";
            //            }
            //            else
            //            {
            //                labelAllWordsInUint1Value.Text = countWords[k].ToString();
            //                if (knowWords[k] == 0)
            //                {
            //                    labelWorsIKnowUnit1Value.Text = "0";
            //                    circularProgressBarUnit1.Value = 0;
            //                    circularProgressBarUnit1.Text = "0%";
            //                }
            //                else
            //                {
            //                    labelWorsIKnowUnit1Value.Text = Convert.ToInt32(knowWords[k]).ToString();
            //                    circularProgressBarUnit1.Value = Convert.ToInt32(Convert.ToInt32(knowWords[k]).ToString());
            //                    circularProgressBarUnit1.Text = Convert.ToInt32(knowWords[k]).ToString() + "%";
            //                }
            //            }

            //            break;
            //        case 1:
            //            if (countWords[k] == 0)
            //            {
            //                labelAllWordsInUint2Value.Text = "0";
            //                labelWorsIKnowUnit2Value.Text = "0";
            //                circularProgressBarUnit2.Value = 0;
            //                circularProgressBarUnit2.Text = "0%";
            //            }
            //            else
            //            {
            //                labelAllWordsInUint2Value.Text = countWords[k].ToString();
            //                if (knowWords[k] == 0)
            //                {
            //                    labelWorsIKnowUnit2Value.Text = "0";
            //                    circularProgressBarUnit2.Value = 0;
            //                    circularProgressBarUnit2.Text = "0%";
            //                }
            //                else
            //                {
            //                    labelWorsIKnowUnit2Value.Text = Convert.ToInt32(knowWords[k]).ToString();
            //                    circularProgressBarUnit2.Value = Convert.ToInt32(Convert.ToInt32(knowWords[k]).ToString());
            //                    circularProgressBarUnit2.Text = Convert.ToInt32(knowWords[k]).ToString() + "%";
            //                }
            //            }
            //            break;
            //        case 2:
            //            if (countWords[k] == 0)
            //            {
            //                labelAllWordsInUint3Value.Text = "0";
            //                labelWorsIKnowUnit3Value.Text = "0";
            //                circularProgressBarUnit3.Value = 0;
            //                circularProgressBarUnit3.Text = "0%";
            //            }
            //            else
            //            {
            //                labelAllWordsInUint3Value.Text = countWords[k].ToString();
            //                if (knowWords[k] == 0)
            //                {
            //                    labelWorsIKnowUnit3Value.Text = "0";
            //                    circularProgressBarUnit3.Value = 0;
            //                    circularProgressBarUnit3.Text = "0%";
            //                }
            //                else
            //                {
            //                    labelWorsIKnowUnit3Value.Text = Convert.ToInt32(knowWords[k]).ToString();
            //                    circularProgressBarUnit3.Value = Convert.ToInt32(Convert.ToInt32(knowWords[k]).ToString());
            //                    circularProgressBarUnit3.Text = Convert.ToInt32(knowWords[k]).ToString() + "%";
            //                }
            //            }
            //            break;
            //        case 3:
            //            if (countWords[k] == 0)
            //            {
            //                labelAllWordsInUint4Value.Text = "0";
            //                labelWorsIKnowUnit4Value.Text = "0";
            //                circularProgressBarUnit4.Value = 0;
            //                circularProgressBarUnit4.Text = "0%";
            //            }
            //            else
            //            {
            //                labelAllWordsInUint4Value.Text = countWords[k].ToString();
            //                if (knowWords[k] == 0)
            //                {
            //                    labelWorsIKnowUnit4Value.Text = "0";
            //                    circularProgressBarUnit4.Value = 0;
            //                    circularProgressBarUnit4.Text = "0%";
            //                }
            //                else
            //                {
            //                    labelWorsIKnowUnit4Value.Text = Convert.ToInt32(knowWords[k]).ToString();
            //                    circularProgressBarUnit4.Value = Convert.ToInt32(Convert.ToInt32(knowWords[k]).ToString());
            //                    circularProgressBarUnit4.Text = Convert.ToInt32(knowWords[k]).ToString() + "%";
            //                }
            //            }
            //            break;
            //        case 4:
            //            if (countWords[k] == 0)
            //            {
            //                labelAllWordsInUint5Value.Text = "0";
            //                labelWorsIKnowUnit5Value.Text = "0";
            //                circularProgressBarUnit5.Value = 0;
            //                circularProgressBarUnit5.Text = "0%";
            //            }
            //            else
            //            {
            //                labelAllWordsInUint5Value.Text = countWords[k].ToString();
            //                if (knowWords[k] == 0)
            //                {
            //                    labelWorsIKnowUnit5Value.Text = "0";
            //                    circularProgressBarUnit5.Value = 0;
            //                    circularProgressBarUnit5.Text = "0%";
            //                }
            //                else
            //                {
            //                    labelWorsIKnowUnit5Value.Text = Convert.ToInt32(knowWords[k]).ToString();
            //                    circularProgressBarUnit5.Value = Convert.ToInt32(Convert.ToInt32(knowWords[k]).ToString());
            //                    circularProgressBarUnit5.Text = Convert.ToInt32(knowWords[k]).ToString() + "%";
            //                }
            //            }
            //            break;
            //        case 5:
            //            if (countWords[k] == 0)
            //            {
            //                labelAllWordsInUint6Value.Text = "0";
            //                labelWorsIKnowUnit6Value.Text = "0";
            //                circularProgressBarUnit6.Value = 0;
            //                circularProgressBarUnit6.Text = "0%";
            //            }
            //            else
            //            {
            //                labelAllWordsInUint6Value.Text = countWords[k].ToString();
            //                if (knowWords[k] == 0)
            //                {
            //                    labelWorsIKnowUnit6Value.Text = "0";
            //                    circularProgressBarUnit6.Value = 0;
            //                    circularProgressBarUnit6.Text = "0%";
            //                }
            //                else
            //                {
            //                    labelWorsIKnowUnit6Value.Text = Convert.ToInt32(knowWords[k]).ToString();
            //                    circularProgressBarUnit6.Value = Convert.ToInt32(Convert.ToInt32(knowWords[k]).ToString());
            //                    circularProgressBarUnit6.Text = Convert.ToInt32(knowWords[k]).ToString() + "%";
            //                }
            //            }
            //            break;
            //        case 6:
            //            if (countWords[k] == 0)
            //            {
            //                labelAllWordsInUint7Value.Text = "0";
            //                labelWorsIKnowUnit7Value.Text = "0";
            //                circularProgressBarUnit7.Value = 0;
            //                circularProgressBarUnit7.Text = "0%";
            //            }
            //            else
            //            {
            //                labelAllWordsInUint7Value.Text = countWords[k].ToString();
            //                if (knowWords[k] == 0)
            //                {
            //                    labelWorsIKnowUnit7Value.Text = "0";
            //                    circularProgressBarUnit7.Value = 0;
            //                    circularProgressBarUnit7.Text = "0%";
            //                }
            //                else
            //                {
            //                    labelWorsIKnowUnit7Value.Text = Convert.ToInt32(knowWords[k]).ToString();
            //                    circularProgressBarUnit7.Value = Convert.ToInt32(Convert.ToInt32(knowWords[k]).ToString());
            //                    circularProgressBarUnit7.Text = Convert.ToInt32(knowWords[k]).ToString() + "%";
            //                }
            //            }
            //            break;
            //        case 7:
            //            if (countWords[k] == 0)
            //            {
            //                labelAllWordsInUint8Value.Text = "0";
            //                labelWorsIKnowUnit8Value.Text = "0";
            //                circularProgressBarUnit8.Value = 0;
            //                circularProgressBarUnit8.Text = "0%";
            //            }
            //            else
            //            {
            //                labelAllWordsInUint8Value.Text = countWords[k].ToString();
            //                if (knowWords[k] == 0)
            //                {
            //                    labelWorsIKnowUnit8Value.Text = "0";
            //                    circularProgressBarUnit8.Value = 0;
            //                    circularProgressBarUnit8.Text = "0%";
            //                }
            //                else
            //                {
            //                    labelWorsIKnowUnit8Value.Text = Convert.ToInt32(knowWords[k]).ToString();
            //                    circularProgressBarUnit8.Value = Convert.ToInt32(Convert.ToInt32(knowWords[k]).ToString());
            //                    circularProgressBarUnit8.Text = Convert.ToInt32(knowWords[k]).ToString() + "%";
            //                }
            //            }
            //            break;
            //        case 8:
            //            if (countWords[k] == 0)
            //            {
            //                labelAllWordsInUint9Value.Text = "0";
            //                labelWorsIKnowUnit9Value.Text = "0";
            //                circularProgressBarUnit9.Value = 0;
            //                circularProgressBarUnit9.Text = "0%";
            //            }
            //            else
            //            {
            //                labelAllWordsInUint9Value.Text = countWords[k].ToString();
            //                if (knowWords[k] == 0)
            //                {
            //                    labelWorsIKnowUnit9Value.Text = "0";
            //                    circularProgressBarUnit9.Value = 0;
            //                    circularProgressBarUnit9.Text = "0%";
            //                }
            //                else
            //                {
            //                    labelWorsIKnowUnit9Value.Text = Convert.ToInt32(knowWords[k]).ToString();
            //                    circularProgressBarUnit9.Value = Convert.ToInt32(Convert.ToInt32(knowWords[k]).ToString());
            //                    circularProgressBarUnit9.Text = Convert.ToInt32(knowWords[k]).ToString() + "%";
            //                }
            //            }
            //            break;
            //        case 9:
            //            if (countWords[k] == 0)
            //            {
            //                labelAllWordsInUint10Value.Text = "0";
            //                labelWorsIKnowUnit10Value.Text = "0";
            //                circularProgressBarUnit10.Value = 0;
            //                circularProgressBarUnit10.Text = "0%";
            //            }
            //            else
            //            {
            //                labelAllWordsInUint10Value.Text = countWords[k].ToString();
            //                if (knowWords[k] == 0)
            //                {
            //                    labelWorsIKnowUnit10Value.Text = "0";
            //                    circularProgressBarUnit10.Value = 0;
            //                    circularProgressBarUnit10.Text = "0%";
            //                }
            //                else
            //                {
            //                    labelWorsIKnowUnit10Value.Text = Convert.ToInt32(knowWords[k]).ToString();
            //                    circularProgressBarUnit10.Value = Convert.ToInt32(Convert.ToInt32(knowWords[k]).ToString());
            //                    circularProgressBarUnit10.Text = Convert.ToInt32(knowWords[k]).ToString() + "%";
            //                }
            //            }
            //            break;
            //    }





            //}
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            for (int k = 0; k < 10; k++)
            {
                switch (k)
                {
                    case 0: // unit 1
                        if (countWords[k] == 0)
                        {
                            labelAllWordsInUint1Value.Text = "0";
                            labelWorsIKnowUnit1Value.Text = "0";
                            circularProgressBarUnit1.Value = 0;
                            circularProgressBarUnit1.Text = "0%";
                        }
                        else
                        {
                            labelAllWordsInUint1Value.Text = countWords[k].ToString();
                            if (knowWords[k] == 0)
                            {
                                labelWorsIKnowUnit1Value.Text = "0";
                                circularProgressBarUnit1.Value = 0;
                                circularProgressBarUnit1.Text = "0%";
                            }
                            else
                            {
                                labelWorsIKnowUnit1Value.Text = Convert.ToInt32(knowWords[k]).ToString();
                                circularProgressBarUnit1.Value = Convert.ToInt32(Convert.ToInt32(precentArr[k]).ToString());
                                circularProgressBarUnit1.Text = Convert.ToInt32(precentArr[k]).ToString() + "%";
                            }
                        }

                        break;
                    case 1:
                        if (countWords[k] == 0)
                        {
                            labelAllWordsInUint2Value.Text = "0";
                            labelWorsIKnowUnit2Value.Text = "0";
                            circularProgressBarUnit2.Value = 0;
                            circularProgressBarUnit2.Text = "0%";
                        }
                        else
                        {
                            labelAllWordsInUint2Value.Text = countWords[k].ToString();
                            if (knowWords[k] == 0)
                            {
                                labelWorsIKnowUnit2Value.Text = "0";
                                circularProgressBarUnit2.Value = 0;
                                circularProgressBarUnit2.Text = "0%";
                            }
                            else
                            {
                                labelWorsIKnowUnit2Value.Text = Convert.ToInt32(knowWords[k]).ToString();
                                circularProgressBarUnit2.Value = Convert.ToInt32(Convert.ToInt32(precentArr[k]).ToString());
                                circularProgressBarUnit2.Text = Convert.ToInt32(precentArr[k]).ToString() + "%";
                            }
                        }
                        break;
                    case 2:
                        if (countWords[k] == 0)
                        {
                            labelAllWordsInUint3Value.Text = "0";
                            labelWorsIKnowUnit3Value.Text = "0";
                            circularProgressBarUnit3.Value = 0;
                            circularProgressBarUnit3.Text = "0%";
                        }
                        else
                        {
                            labelAllWordsInUint3Value.Text = countWords[k].ToString();
                            if (knowWords[k] == 0)
                            {
                                labelWorsIKnowUnit3Value.Text = "0";
                                circularProgressBarUnit3.Value = 0;
                                circularProgressBarUnit3.Text = "0%";
                            }
                            else
                            {
                                labelWorsIKnowUnit3Value.Text = Convert.ToInt32(knowWords[k]).ToString();
                                circularProgressBarUnit3.Value = Convert.ToInt32(Convert.ToInt32(precentArr[k]).ToString());
                                circularProgressBarUnit3.Text = Convert.ToInt32(precentArr[k]).ToString() + "%";
                            }
                        }
                        break;
                    case 3:
                        if (countWords[k] == 0)
                        {
                            labelAllWordsInUint4Value.Text = "0";
                            labelWorsIKnowUnit4Value.Text = "0";
                            circularProgressBarUnit4.Value = 0;
                            circularProgressBarUnit4.Text = "0%";
                        }
                        else
                        {
                            labelAllWordsInUint4Value.Text = countWords[k].ToString();
                            if (knowWords[k] == 0)
                            {
                                labelWorsIKnowUnit4Value.Text = "0";
                                circularProgressBarUnit4.Value = 0;
                                circularProgressBarUnit4.Text = "0%";
                            }
                            else
                            {
                                labelWorsIKnowUnit4Value.Text = Convert.ToInt32(knowWords[k]).ToString();
                                circularProgressBarUnit4.Value = Convert.ToInt32(Convert.ToInt32(precentArr[k]).ToString());
                                circularProgressBarUnit4.Text = Convert.ToInt32(precentArr[k]).ToString() + "%";
                            }
                        }
                        break;
                    case 4:
                        if (countWords[k] == 0)
                        {
                            labelAllWordsInUint5Value.Text = "0";
                            labelWorsIKnowUnit5Value.Text = "0";
                            circularProgressBarUnit5.Value = 0;
                            circularProgressBarUnit5.Text = "0%";
                        }
                        else
                        {
                            labelAllWordsInUint5Value.Text = countWords[k].ToString();
                            if (knowWords[k] == 0)
                            {
                                labelWorsIKnowUnit5Value.Text = "0";
                                circularProgressBarUnit5.Value = 0;
                                circularProgressBarUnit5.Text = "0%";
                            }
                            else
                            {
                                labelWorsIKnowUnit5Value.Text = Convert.ToInt32(knowWords[k]).ToString();
                                circularProgressBarUnit5.Value = Convert.ToInt32(Convert.ToInt32(precentArr[k]).ToString());
                                circularProgressBarUnit5.Text = Convert.ToInt32(precentArr[k]).ToString() + "%";
                            }
                        }
                        break;
                    case 5:
                        if (countWords[k] == 0)
                        {
                            labelAllWordsInUint6Value.Text = "0";
                            labelWorsIKnowUnit6Value.Text = "0";
                            circularProgressBarUnit6.Value = 0;
                            circularProgressBarUnit6.Text = "0%";
                        }
                        else
                        {
                            labelAllWordsInUint6Value.Text = countWords[k].ToString();
                            if (knowWords[k] == 0)
                            {
                                labelWorsIKnowUnit6Value.Text = "0";
                                circularProgressBarUnit6.Value = 0;
                                circularProgressBarUnit6.Text = "0%";
                            }
                            else
                            {
                                labelWorsIKnowUnit6Value.Text = Convert.ToInt32(knowWords[k]).ToString();
                                circularProgressBarUnit6.Value = Convert.ToInt32(Convert.ToInt32(precentArr[k]).ToString());
                                circularProgressBarUnit6.Text = Convert.ToInt32(precentArr[k]).ToString() + "%";
                            }
                        }
                        break;
                    case 6:
                        if (countWords[k] == 0)
                        {
                            labelAllWordsInUint7Value.Text = "0";
                            labelWorsIKnowUnit7Value.Text = "0";
                            circularProgressBarUnit7.Value = 0;
                            circularProgressBarUnit7.Text = "0%";
                        }
                        else
                        {
                            labelAllWordsInUint7Value.Text = countWords[k].ToString();
                            if (knowWords[k] == 0)
                            {
                                labelWorsIKnowUnit7Value.Text = "0";
                                circularProgressBarUnit7.Value = 0;
                                circularProgressBarUnit7.Text = "0%";
                            }
                            else
                            {
                                labelWorsIKnowUnit7Value.Text = Convert.ToInt32(knowWords[k]).ToString();
                                circularProgressBarUnit7.Value = Convert.ToInt32(Convert.ToInt32(precentArr[k]).ToString());
                                circularProgressBarUnit7.Text = Convert.ToInt32(precentArr[k]).ToString() + "%";
                            }
                        }
                        break;
                    case 7:
                        if (countWords[k] == 0)
                        {
                            labelAllWordsInUint8Value.Text = "0";
                            labelWorsIKnowUnit8Value.Text = "0";
                            circularProgressBarUnit8.Value = 0;
                            circularProgressBarUnit8.Text = "0%";
                        }
                        else
                        {
                            labelAllWordsInUint8Value.Text = countWords[k].ToString();
                            if (knowWords[k] == 0)
                            {
                                labelWorsIKnowUnit8Value.Text = "0";
                                circularProgressBarUnit8.Value = 0;
                                circularProgressBarUnit8.Text = "0%";
                            }
                            else
                            {
                                labelWorsIKnowUnit8Value.Text = Convert.ToInt32(knowWords[k]).ToString();
                                circularProgressBarUnit8.Value = Convert.ToInt32(Convert.ToInt32(precentArr[k]).ToString());
                                circularProgressBarUnit8.Text = Convert.ToInt32(precentArr[k]).ToString() + "%";
                            }
                        }
                        break;
                    case 8:
                        if (countWords[k] == 0)
                        {
                            labelAllWordsInUint9Value.Text = "0";
                            labelWorsIKnowUnit9Value.Text = "0";
                            circularProgressBarUnit9.Value = 0;
                            circularProgressBarUnit9.Text = "0%";
                        }
                        else
                        {
                            labelAllWordsInUint9Value.Text = countWords[k].ToString();
                            if (knowWords[k] == 0)
                            {
                                labelWorsIKnowUnit9Value.Text = "0";
                                circularProgressBarUnit9.Value = 0;
                                circularProgressBarUnit9.Text = "0%";
                            }
                            else
                            {
                                labelWorsIKnowUnit9Value.Text = Convert.ToInt32(knowWords[k]).ToString();
                                circularProgressBarUnit9.Value = Convert.ToInt32(Convert.ToInt32(precentArr[k]).ToString());
                                circularProgressBarUnit9.Text = Convert.ToInt32(precentArr[k]).ToString() + "%";
                            }
                        }
                        break;
                    case 9:
                        if (countWords[k] == 0)
                        {
                            labelAllWordsInUint10Value.Text = "0";
                            labelWorsIKnowUnit10Value.Text = "0";
                            circularProgressBarUnit10.Value = 0;
                            circularProgressBarUnit10.Text = "0%";
                        }
                        else
                        {
                            labelAllWordsInUint10Value.Text = countWords[k].ToString();
                            if (knowWords[k] == 0)
                            {
                                labelWorsIKnowUnit10Value.Text = "0";
                                circularProgressBarUnit10.Value = 0;
                                circularProgressBarUnit10.Text = "0%";
                            }
                            else
                            {
                                labelWorsIKnowUnit10Value.Text = Convert.ToInt32(knowWords[k]).ToString();
                                circularProgressBarUnit10.Value = Convert.ToInt32(Convert.ToInt32(precentArr[k]).ToString());
                                circularProgressBarUnit10.Text = Convert.ToInt32(precentArr[k]).ToString() + "%";
                            }
                        }
                        break;
                }

            }

            circularProgressBarLoading.Visible = false;
            panelUnit1.Visible = true;
            panelUnit2.Visible = true;
            panelUnit3.Visible = true;
            panelUnit4.Visible = true;
            panelUnit5.Visible = true;
            panelUnit6.Visible = true;
            panelUnit7.Visible = true;
            panelUnit8.Visible = true;
            panelUnit9.Visible = true;
            panelUnit10.Visible = true;


        }

        private void formMyProgress_Shown(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
