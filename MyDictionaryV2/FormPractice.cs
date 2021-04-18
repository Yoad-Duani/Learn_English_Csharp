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
    public partial class FormPractice : Form
    {
        public FormPractice()
        {
            InitializeComponent();
            
        }
        //Form1 form1;
        bool cheakSelectUnit = false;
        bool cheakSelectAB = false;
        bool[] UnitsG = new bool[10];
        //bool[] TypeG = new bool[4];
        bool[] Type_AB = new bool[2];
        DataTable Table1 = new DataTable();
        DAL_SQL_Queries dsq = new DAL_SQL_Queries();
        MyMessageBox myMessageBox;
        public bool messagBoxCheak;

        ListViewItem lvHoveredItem;
        bool itemIsSelected;

        private void listViewSelectUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSelectUnit.FocusedItem == null)
                return;
            int p = listViewSelectUnit.FocusedItem.Index;
            //if (itemIsSelected == true)
            //    listViewSelectUnit.Items[p].BackColor = Color.LightBlue;
            //else
            //    listViewSelectUnit.Items[p].BackColor = listViewSelectUnit.BackColor;

            if (listViewSelectUnit.Items[p].BackColor == listViewSelectUnit.BackColor && listViewSelectUnit.SelectedItems.Count >= 1)
            {
                listViewSelectUnit.Items[p].BackColor = Color.LightBlue;
                listViewSelectUnit.Items[p].ForeColor = Color.DarkBlue;
                //UnitsG[p] = true;
                //cheakSelectUnit = true;

            }
            else
            {
                if (listViewSelectUnit.SelectedItems.Count >= 1)
                {
                    listViewSelectUnit.Items[p].BackColor = listViewSelectUnit.BackColor;
                    listViewSelectUnit.Items[p].ForeColor = listViewSelectUnit.ForeColor;
                    //UnitsG[p] = false;
                    //cheakSelectUnit = true;
                }
            }

            listViewSelectUnit.SelectedItems.Clear();
        }

        private void listViewSelectAB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSelectAB.FocusedItem == null)
                return;
            int p = listViewSelectAB.FocusedItem.Index;

            if (listViewSelectAB.Items[p].BackColor == listViewSelectAB.BackColor && listViewSelectAB.SelectedItems.Count >= 1)
            {
                listViewSelectAB.Items[p].BackColor = Color.LightBlue;
                listViewSelectAB.Items[p].ForeColor = Color.DarkBlue;

            }
            else
            {
                if (listViewSelectAB.SelectedItems.Count >= 1)
                {
                    listViewSelectAB.Items[p].BackColor = listViewSelectAB.BackColor;
                    listViewSelectAB.Items[p].ForeColor = listViewSelectAB.ForeColor;

                }
            }

            listViewSelectAB.SelectedItems.Clear();
        }

        private void iconButtonMemorization_Click(object sender, EventArgs e)
        {

            for (int i = 0; i <= listViewSelectUnit.Items.Count - 1; i++)
            {
                if (listViewSelectUnit.Items[i].BackColor == Color.LightBlue)
                {
                    UnitsG[i] = true;
                }
            }


            //for (int i = 0; i <= listViewSelectAB.Items.Count - 1; i++)
            //{
            //    if (listViewSelectAB.Items[i].BackColor == Color.LightBlue)
            //    {
            //        Type_AB[i] = true;
            //    }
            //}


            //Table1 = dsq.dataSourceAccByGroupingWordsWithoutSize(UnitsG, Type_AB);
        }

        
        //Table1 = dsq.dataSourceAccByGroupingWordsWithoutSize(UnitsG, TypeG, Type_AB);

        private void FormPractice_Load(object sender, EventArgs e)
        {
            /// clear the arry
            for (int i = 0; i <= 1 - 1; i++) // only A and B
            {
                Type_AB[i] = false;
            }

            /// clear the arry
            for (int i = 0; i <= 9; i++) // the number of the units
            {
                UnitsG[i] = false;
            }

            SetDoubleBuffering(listViewSelectUnit, true);
        }

        public DataTable Memorization_()
        {
            messagBoxCheak = false;
            cheakSelectUnit = false;
            cheakSelectAB = false;

            //ListViewItem liUnit = new ListViewItem();
            //listViewSelectUnit.Items.Add(liUnit);
            for (int i = 0; i <= 9; i++)
            {
                //listViewSelectUnit.Items[i].BackColor = Color.Red;
                if (listViewSelectUnit.Items[i].BackColor == Color.LightBlue)
                {
                    UnitsG[i] = true;
                    cheakSelectUnit = true;
                }
                //listViewSelectUnit.Items[i].BackColor = Color.Red;
            }

            for (int k = 0; k <= listViewSelectAB.Items.Count - 1; k++)
            {
                if (listViewSelectAB.Items[k].BackColor == Color.LightBlue)
                {
                     Type_AB[k] = true;
                     cheakSelectAB = true;
                }
            }

            if (cheakSelectUnit == true && cheakSelectAB == true)
            {

                if (Form1.withoutType4 == true)
                {
                    Table1 = dsq.dataSourceAccByGroupingWordsWithoutSizeAndWithoutType4(UnitsG, Type_AB);
                    Form1.withoutType4 = false;
                    return Table1;
                }
                else
                {
                    Table1 = dsq.dataSourceAccByGroupingWordsWithoutSize(UnitsG, Type_AB);
                    return Table1;
                }
            }
            else
            {
                string text = "בחר לפחות יחידה אחת ורמת קושי אחת";
                myMessageBox = new MyMessageBox(text);
                myMessageBox.ShowDialog();
                messagBoxCheak = true;
                //MessageBox.Show("בחר לפחות יחידה אחת ורמת קושי אחת");
                return null;
            }
            //Form1.withoutType4 = false;
        }

        private void listViewSelectUnit_MouseHover(object sender, EventArgs e)
        {
            
            //e.Item.BackColor = Color.Black;
        }

        public static void SetDoubleBuffering(System.Windows.Forms.Control control, bool value)
        {
            //System.Reflection.PropertyInfo controlProperty = typeof(System.Windows.Forms.Control)
            //    .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            //controlProperty.SetValue(control, value, null);
        }

        private void listViewSelectUnit_MouseMove(object sender, MouseEventArgs e)
        {
            //itemIsSelected = false;
            ////Set the Color you want the list Item to be when mouse is over
            //Color oItemColor = Color.Red;
            //Color oOriginalColor = listViewSelectUnit.BackColor; //Your original color


            ////get the Item the Mouse is currently hover
            //ListViewItem lvCurrentItem = listViewSelectUnit.GetItemAt(e.X, e.Y);

            //if ((lvCurrentItem != null) && (lvCurrentItem != lvHoveredItem))
            //{
            //    if (lvCurrentItem.BackColor == Color.LightBlue)
            //    {
            //        itemIsSelected = true;
            //    }
            //    //lvCurrentItem.BackColor = oItemColor;

            //    if (lvHoveredItem != null)
            //    {
            //        if(itemIsSelected == true)
            //            lvHoveredItem.BackColor = Color.LightBlue;
            //        else
            //            lvHoveredItem.BackColor = oOriginalColor;
            //    }

            //    lvHoveredItem = lvCurrentItem;
            //    return;

            //}


            //if (lvCurrentItem == null)
            //{
            //    if (lvHoveredItem != null)
            //    {
            //        if (itemIsSelected == true)
            //            lvHoveredItem.BackColor = Color.LightBlue;
            //        else
            //            lvHoveredItem.BackColor = oOriginalColor;
            //    }
            //}
        }

        private void listViewSelectUnit_MouseLeave(object sender, EventArgs e)
        {
            //Color oOriginalColor = listViewSelectUnit.BackColor; ; //Your original color

            ////When the mouse leave the control. If a ListViewItem was highlighted then set it's original color back
            //if (lvHoveredItem != null)
            //{
            //    if (itemIsSelected == true)
            //        lvHoveredItem.BackColor = Color.LightBlue;
            //    else
            //        lvHoveredItem.BackColor = oOriginalColor;
            //}

            //lvHoveredItem = null;
        }
    }

}
