using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
namespace WindowsFormsApplication1
{
    class db
    {
        SQLiteConnection con1;
        SQLiteCommand s1 = new SQLiteCommand();
        public db(string sBankname)
        {
            con1 = new SQLiteConnection(@"data source=" + Application.StartupPath + "\\" + "bank.db");
            con1.Open();
        }

        public int getLastInsertID()
        {
            try
            {
                s1.CommandText = "SELECT last_insert_rowid()";
                s1.Connection = con1;
                object ret = s1.ExecuteScalar();
                return Convert.ToInt32(ret);

            }
            catch (Exception e1)
            {
                writeError(e1.Message, "275");
                return 0;
            }
        }

        public void RunQuery(string strQuery)
        {
            try
            {
                s1.CommandText = strQuery;
                s1.Connection = con1;
                s1.ExecuteNonQuery();
            }
            catch (Exception e1)
            {
                writeError(e1.Message, "275");
            }
        }

        public object QueryScaler(string sql)
        {
            try
            {
                s1.CommandText = sql;
                s1.Connection = con1;
                object ret = s1.ExecuteScalar();
                return ret;

            }
            catch (Exception e1)
            {
                writeError(e1.Message, "275");
                return 0;
            }
        }

        public string getFieldInformation(string sField)
        {
            try
            {
                DataTable d1 = new DataTable();
                SQLiteDataAdapter sql1 = new SQLiteDataAdapter("SELECT " + sField + " FROM tbl_information", con1);
                sql1.Fill(d1);
                return d1.Rows[0][0].ToString();
            }
            catch (Exception e1)
            {
                writeError(e1.Message, "275");
                return "";
            }
        }

        public DataTable getRow(string query)
        {
            try
            {
                DataTable d1 = new DataTable();
                SQLiteDataAdapter sql1 = new SQLiteDataAdapter(query, con1);
                sql1.Fill(d1);
                return d1;
            }
            catch (Exception e1)
            {
                writeError(e1.Message, "275");
                return null;
            }
        }

        public void AutoComplete(TextBox textbox,string query,string fieldname)
        {
            try
            {
                DataTable d1 = new DataTable();
                SQLiteDataAdapter sql1 = new SQLiteDataAdapter(query, con1);
                sql1.Fill(d1);
                textbox.AutoCompleteCustomSource.Clear();
                for (int i = 0; i < d1.Rows.Count; i++)
                {
                    textbox.AutoCompleteCustomSource.Add(d1.Rows[i][fieldname].ToString());
                }
            }
            catch (Exception e1)
            {
            }
        }

        public void DeleteTopic(string sWhere)
        {
            try
            {
                s1.CommandText = "DELETE FROM tbl_app WHERE " + sWhere;
                s1.Connection = con1;
                s1.ExecuteNonQuery();
            }
            catch (Exception e1)
            {
                writeError(e1.Message, "275");
            }
        }

        public void stopConnect()
        {
            con1.Close();
            s1.Dispose();
            con1.Dispose();
        }

        public void OpenConnection()
        {
            con1 = new SQLiteConnection(@"data source=" + Application.StartupPath + "\\" + "bank.db");
            con1.Open();
        }

        public void writeError(string message, string line)
        {
            try
            {
                System.IO.File.AppendAllText(Application.StartupPath + "\\log.txt", "Error In line " + line + " with message: " + message + "\r\n");
            }
            catch (Exception)
            {

            }
        }
    }
}
