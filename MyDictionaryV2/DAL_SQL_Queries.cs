using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // SQL server local DB
using System.Data;
//using System.Data.OleDb;

namespace MyDictionaryV2
{
    //public string cn_string = Properties.Settings.Default.wordsDBConnectionString;
    class DAL_SQL_Queries
    {
        //C:\MyDictionaryV2\MyDictionaryV2\wordsDB.mdf
        //string strProvider = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\MyDictionaryV2\MyDictionaryV2\wordsDB.mdf";
        static string cn_string = Properties.Settings.Default.wordsDBConnectionString;
        //SqlConnection cn_connetion = new SqlConnection(cn_string);
        DataTable tb = new DataTable();
        //SqlDataAdapter adapter = new SqlDataAdapter(sql_text,);
        SqlConnection cn_connetion = new SqlConnection(cn_string);
    
    
        public DataTable getdata()
        {
            try
            {
                string sql_text = "SELECT EnglisgWords, HebrewWords, WordsType, ID FROM Table1"; 
                //SqlConnection cn_connetion = new SqlConnection(cn_string);
                if (cn_connetion.State != System.Data.ConnectionState.Open)
                {
                    cn_connetion.Open();
                }
                SqlDataAdapter adapter = new SqlDataAdapter(sql_text,cn_connetion);
                adapter.Fill(tb);
                return tb;
            }
            catch
            {
                return null;
            }
            finally
            {
                cn_connetion.Close();
            }
        }

        public DataTable dataSourceWordRow(int idword)
        {
            try
            {
                string sql_text = "SELECT * FROM Table1 WHERE ID = '" + idword + "'";
                if (cn_connetion.State != System.Data.ConnectionState.Open)
                {
                    cn_connetion.Open();
                }
                SqlDataAdapter adapter = new SqlDataAdapter(sql_text, cn_connetion);
                adapter.Fill(tb);
                return tb;


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: Failed to retrieve the required data from the DataBase.\n{0}", ex.Message);
                return null;
            }
            finally
            {
                cn_connetion.Close();
            }
        }
        
        public DataTable dataSourceAccByGroupingWordsWithoutSize(bool[] UnitsG, bool[] Type_AB)
        {
            //return the words according to the user's filter
            string strSql = "SELECT EnglisgWords, HebrewWords, WordsType, ID FROM Table1 WHERE UnitWords IN (";
            for (int i = 0; i <= 9; i++)
            {
                if (UnitsG[i] == true)
                {
                    strSql += "" + (i + 1) + ", ";
                }

            }
            strSql = strSql.Remove(strSql.Length - 2, 1);
            strSql += ") ";
            //strSql += "AND WordsType IN (";
            //for (int i = 0; i <= 3; i++)
            //{
            //    if (TypeG[i] == true)
            //    {
            //        strSql += "" + (i + 1) + ", ";
            //    }

            //}
            //strSql = strSql.Remove(strSql.Length - 2, 1);
            //strSql += ") ";
            strSql += "AND WordsTypeAB IN (";
            for (int i = 0; i <= 1; i++)
            {
                if (Type_AB[i] == true)
                {
                    strSql += "" + (i + 1) + ", ";
                }

            }
            //strSql += "";
            strSql = strSql.Remove(strSql.Length - 2, 1);
            strSql += ") ORDER BY EnglisgWords";

            //OleDbConnection con = new OleDbConnection(strProvider);
            //OleDbCommand cmd = new OleDbCommand(strSql, con);
            try
            {
                if (cn_connetion.State != System.Data.ConnectionState.Open)
                {
                    cn_connetion.Open();
                }
                SqlDataAdapter adapter = new SqlDataAdapter(strSql, cn_connetion);
                adapter.Fill(tb);
                return tb;
                //con.Open();
                //cmd.CommandType = CommandType.Text;
                //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                //DataTable tb = new DataTable();
                //da.Fill(tb);
                //return tb;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: Failed to retrieve the required data from the DataBase.\n{0}", ex.Message);
                return null;
            }
            finally
            {
                cn_connetion.Close();
            }
        }

        public int updateTypeWord(int id, int wordsType)
        {


            try
            {
               
                SqlCommand command = new SqlCommand("UPDATE Table1 SET WordsType = @wordsType WHERE ID = @id", cn_connetion);
                SqlDataAdapter adapter = new SqlDataAdapter();
                command.Parameters.AddWithValue("@wordsType", wordsType);
                command.Parameters.AddWithValue("@id", id);

                if (cn_connetion.State != System.Data.ConnectionState.Open)
                {
                    cn_connetion.Open();
                }
                command.ExecuteNonQuery();
                return 1;
                
            }
            catch
            {
                return 0; // Failed to update
            }
            finally
            {
                cn_connetion.Close();
            }
        }




        public DataTable dataSourceAccByGroupingWordsWithoutSizeAndWithoutType4(bool[] UnitsG, bool[] Type_AB)
        {
            //return the words according to the user's filter
            string strSql = "SELECT EnglisgWords, HebrewWords, WordsType, ID FROM Table1 WHERE UnitWords IN (";
            for (int i = 0; i <= 9; i++)
            {
                if (UnitsG[i] == true)
                {
                    strSql += "" + (i + 1) + ", ";
                }

            }
            strSql = strSql.Remove(strSql.Length - 2, 1);
            strSql += ") ";
            //strSql += "AND WordsType IN (";
            //for (int i = 0; i <= 3; i++)
            //{
            //    if (TypeG[i] == true)
            //    {
            //        strSql += "" + (i + 1) + ", ";
            //    }

            //}
            //strSql = strSql.Remove(strSql.Length - 2, 1);
            //strSql += ") ";
            strSql += "AND WordsTypeAB IN (";
            for (int i = 0; i <= 1; i++)
            {
                if (Type_AB[i] == true)
                {
                    strSql += "" + (i + 1) + ", ";
                }

            }
            //strSql += "";
            strSql = strSql.Remove(strSql.Length - 2, 1);
            strSql += ")";

            strSql += " AND WordsType != 4 ";
            //for (int i = 0; i <= 1; i++)
            //{
            //    if (Type_AB[i] == true)
            //    {
            //        strSql += "" + (i + 1) + ", ";
            //    }

            //}
            //strSql += "";
            //strSql = strSql.Remove(strSql.Length - 2, 1);


            strSql += "ORDER BY ID";

            //OleDbConnection con = new OleDbConnection(strProvider);
            //OleDbCommand cmd = new OleDbCommand(strSql, con);
            try
            {
                if (cn_connetion.State != System.Data.ConnectionState.Open)
                {
                    cn_connetion.Open();
                }
                SqlDataAdapter adapter = new SqlDataAdapter(strSql, cn_connetion);
                adapter.Fill(tb);
                return tb;
                //con.Open();
                //cmd.CommandType = CommandType.Text;
                //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                //DataTable tb = new DataTable();
                //da.Fill(tb);
                //return tb;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: Failed to retrieve the required data from the DataBase.\n{0}", ex.Message);
                return null;
            }
            finally
            {
                cn_connetion.Close();
            }
        }
        public DataTable getallUnintAndType()
        {
            try
            {
                string sql_text = "SELECT UnitWords , WordsType FROM Table1 ";
                //SqlConnection cn_connetion = new SqlConnection(cn_string);
                if (cn_connetion.State != System.Data.ConnectionState.Open)
                {
                    cn_connetion.Open();
                }
                SqlDataAdapter adapter = new SqlDataAdapter(sql_text, cn_connetion);
                adapter.Fill(tb);
                return tb;
            }
            catch
            {
                return null;
            }
            finally
            {
                cn_connetion.Close();
            }

        }


        public int updateNoteWord(string note , int id)
        {


            try
            {

                SqlCommand command = new SqlCommand("UPDATE Table1 SET NoteWord = @noteword WHERE ID = @id", cn_connetion);
                SqlDataAdapter adapter = new SqlDataAdapter();
                command.Parameters.AddWithValue("@noteword", note);
                command.Parameters.AddWithValue("@id", id);

                if (cn_connetion.State != System.Data.ConnectionState.Open)
                {
                    cn_connetion.Open();
                }
                command.ExecuteNonQuery();
                return 1;

            }
            catch
            {
                return 0; // Failed to update
            }
            finally
            {
                cn_connetion.Close();
            }
        }



    }
}
