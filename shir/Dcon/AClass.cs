using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace system
{
    class DataManagement
    {
        private static string css = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True";
        public static SqlConnection SCO = new SqlConnection(css);
        public static SqlCommand SCM = new SqlCommand();
        public static SqlDataAdapter SDA = new SqlDataAdapter();
        public static SqlCommandBuilder SCB = new SqlCommandBuilder();
        public static DataTable DT = new DataTable();

        public static DataTable Search(string CTS)
        {
            if (SCO.State != ConnectionState.Open) SCO.Open();
            DT = new DataTable();
            try
            {
                SCM = new SqlCommand(CTS, SCO);
                SDA = new SqlDataAdapter(SCM);
                SCB = new SqlCommandBuilder(SDA);
                SDA.Fill(DT);
            }
            catch
            {
                return null;
            }
            return (DT);
        }

        public static DataTable I_U_D(string CTSIDU, string SQLSHOW)
        {
            if (SCO.State != ConnectionState.Open) SCO.Open();
            DT = new DataTable();
            try
            {
                SCM = new SqlCommand(CTSIDU, SCO);
                SCM.ExecuteNonQuery();

                if (SQLSHOW == "") return null;
                SCM.CommandText = SQLSHOW;
                SDA = new SqlDataAdapter(SCM);
                SCB = new SqlCommandBuilder(SDA);
                SDA.Fill(DT);
            }
            catch 
            {
                return null;
            }
            return DT;
        }
    }

    class Languge_Keybord
    {
        public static void Persian()
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("fa-ir"));
        }
        public static void English()
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("en-us"));
        }

        public static string GetLanguage()
        {
            return InputLanguage.CurrentInputLanguage.Culture.Name;
        }
    }
}
