using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace system
{
    class connect
    {
        
        SqlConnection objcon;
        String con;
        SqlDataAdapter objdataadapter;
        SqlCommand objcommand;
        public connect()
        {
            objcommand = new SqlCommand();
            objcon = new SqlConnection();
            objdataadapter = new SqlDataAdapter();
            objcommand.Connection = objcon;
            objdataadapter.SelectCommand = objcommand;
        }

        public void connection()
        {
            string cs = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True";
            objcon.ConnectionString = cs;
            objcon.Open();
        }

        public void Disconnect()
        {
            objcon.Close();
        }

        public DataTable show_data(string sql)
        {
            DataTable dt = new DataTable();
            objcommand.CommandText = sql;
            objcommand.CommandType = CommandType.Text;
            objdataadapter.Fill(dt);
            
            return dt;
        }

        public bool exe_data(string sql)
        {
            try
            {

                objcommand.CommandText = sql;
                objcommand.ExecuteNonQuery();
                return true;
            }
           catch 
            {
                return false;
            }
        }

        internal void backup()
        {
            
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "*.bak|*.bak";
            string s = "C:\\Users\\alfa\\Desktop\\abolfazl\\proje\\library-c-sharp\\WindowsFormsApplication5\\App_Data\\library.mdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                objcommand.CommandText = "backup database "+s+" to disk='" + sfd.FileName + "' with format";
                objcommand.ExecuteNonQuery();
            }
        }

        public string detach(string DBName)
        {
        string re;
            SqlConnection.ClearAllPools();
            try
            {
                SqlConnection con = new SqlConnection("server=.;trusted_connection=yes;");
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "EXEC sp_detach_db '" + DBName + "', 'true';";
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                re = "قطع اتصال با موفقیت انجام شد";
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }//detach

        public string attach(string DBName)
        {
            string re;
            SqlConnection.ClearAllPools();
            string n = Application.StartupPath + "\\App_Data\\" + DBName;
            if (File.Exists(n + "_log.ldf"))
                File.Delete(n + "_log.ldf");
            try
            {
                SqlConnection con = new SqlConnection("server=.;trusted_connection=yes;");
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "EXEC sp_attach_db '" + DBName + "', '" + n + ".Mdf'";
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                re = "اتصال با موفقیت انجام شد";
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }//attach

        public string check(string DBName)
        {
            string re="";
            try
            {
                SqlConnection sq = new SqlConnection("server=.;trusted_connection=yes;");
                SqlDataAdapter adapt = new SqlDataAdapter("Exec sp_helpdb", sq);
                DataSet set = new DataSet();
                adapt.Fill(set);
                DataView view = new DataView(set.Tables[0]);
                view.Sort = "name";
                int res = view.Find(DBName);//res=0 ->Exist , res=-1->Not Exist
                if (res == 0)
                    re = "Exist";
                else if (res == -1)
                    re = "NotExist";
            }//try
            catch(Exception ex)
            {
                re = ex.Message;
            }//catch
            return re;
        }//check
    }
}
