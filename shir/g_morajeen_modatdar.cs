using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;
using Stimulsoft.Report;

namespace system
{
    public partial class g_morajeen_modatdar : Office2007Form
    {
        DataTable dt = null;
        public g_morajeen_modatdar()
        {
            InitializeComponent();
        }

        private void g_morajeen_modatdar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.tahvilshir' table. You can move, or remove it, as needed.
            this.tahvilshirTableAdapter.Fill(this.dataSet.tahvilshir);
            dt = DataManagement.Search("SELECT * FROM moshtary");
            btnLeft.Text = Persia.Calendar.ConvertToPersian(DateTime.Now).ToString("W");
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            /*
            connect con = new connect();

            con.connection();
            dt = con.show_data("select date,name+N' '+family AS name,shdaftarche,bimekonande,franshiz,ssazman,mablagh, sbimar from veroozane");
            con.Disconnect();

            if (dt.Rows.Count == 0)
            {
                FMessegeBox.FarsiMessegeBox.Show("اطلاعاتی یاقت نشد");
                PDtxt1.Focus();
                return;
            }

            string date1 = PDtxt1.Value.Year.ToString() + "/" + (PDtxt1.Value.Month < 10 ? "0" + PDtxt1.Value.Month.ToString() : PDtxt1.Value.Month.ToString()) + "/" + (PDtxt1.Value.Day < 10 ? "0" + PDtxt1.Value.Day.ToString() : PDtxt1.Value.Day.ToString());
            string date2 = PDtxt2.Value.Year.ToString() + "/" + (PDtxt2.Value.Month < 10 ? "0" + PDtxt2.Value.Month.ToString() : PDtxt1.Value.Month.ToString()) + "/" + (PDtxt2.Value.Day < 10 ? "0" + PDtxt2.Value.Day.ToString() : PDtxt2.Value.Day.ToString());

            FreeControls.PersianDate pd1 = FreeControls.PersianDate.Parse(date1);
            FreeControls.PersianDate pd2 = FreeControls.PersianDate.Parse(date2);

            double jamekol = 0, jamesazman = 0, jamebimar = 0;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].ItemArray.GetValue(0).ToString() == "" || !IsOK(dt.Rows[i].ItemArray.GetValue(0).ToString(), pd1, pd2))
                {
                    dt.Rows.RemoveAt(i--);
                    continue;
                }

                jamesazman += double.Parse((dt.Rows[i].ItemArray.GetValue(5).ToString() == "" ? "0" : dt.Rows[i].ItemArray.GetValue(5).ToString()));
                jamekol += double.Parse((dt.Rows[i].ItemArray.GetValue(6).ToString() == "" ? "0" : dt.Rows[i].ItemArray.GetValue(6).ToString()));
                jamebimar += double.Parse((dt.Rows[i].ItemArray.GetValue(7).ToString() == "" ? "0" : dt.Rows[i].ItemArray.GetValue(5).ToString()));
            }

            rpt_moraje_mod rpt = new rpt_moraje_mod();
            rpt.SetDataSource(dt);
            rpt.SetParameterValue("date1", date1);
            rpt.SetParameterValue("date2", date2);
            rpt.SetParameterValue("jamesaz", jamesazman);
            rpt.SetParameterValue("jamebimar", jamebimar);
            rpt.SetParameterValue("jamekol", jamekol);
            crystalReportViewer1.ReportSource = rpt;
            */
            btnRight.Focus();
        }

        private bool IsOK(string PDate, FreeControls.PersianDate PD1, FreeControls.PersianDate PD2)
        {
            FreeControls.PersianDate date = FreeControls.PersianDate.Parse(PDate);

            if (FreeControls.PersianDate.Compare2Date(PD1, date) == 1 || FreeControls.PersianDate.Compare2Date(PD2, date) == -1)
                return false;
            return true;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            try
            {
                if (dt.Rows.Count == 0)
                    return;

                dt.Clear();
                dt.Columns.Clear();
                dt.Rows.Clear();

                dt = DataManagement.Search("SELECT * FROM moshtary");
                /*
                dt.Columns.Add("num");
                dt.Columns.Add("date");
                dt.Columns.Add("peyvast");
                dt.Columns.Add("paygah");
                dt.Columns.Add("hoze");
                dt.Columns.Add("farmande");
                dt.Columns.Add("date1");
                dt.Columns.Add("date2");
                dt.Columns.Add("date01");
                dt.Columns.Add("date02");
                dt.Columns.Add("jahat");
                dt.Columns.Add("pay");

                dt.Rows[0]["num"] = txtShomare.Text;
                dt.Rows[0]["date"] = txtDate.TextDate;
                dt.Rows[0]["peyvast"] = txtPeyvast.Text;
                dt.Rows[0]["paygah"] = lblPaygahF.Text;
                dt.Rows[0]["hoze"] = txthoze.Text;
                dt.Rows[0]["farmande"] = lblFarmande.Text;
                dt.Rows[0]["date1"] = txtDate1.TextDate;
                dt.Rows[0]["date2"] = txtDate2.TextDate;
                dt.Rows[0]["date01"] = txtDate01.TextDate;
                dt.Rows[0]["date02"] = txtDate02.TextDate;
                dt.Rows[0]["jahat"] = txtJahat.Text;
                dt.Rows[0]["pay"] = txtPaygah.Text;
                */
                StiReport sti = new StiReport();
                sti.Load("rpt_mosh.mrt");
                sti.RegData("ds", dt);
                sti.Dictionary.DataSources.Items[0].DataTable = dt;
                sti.Show();
            }
            catch (Exception ex)
            {
                FMessegeBox.FarsiMessegeBox.Show("خطا\n" + ex.Message);
            }
        }

        private void PDtxt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) PDtxt2.Focus();
        }

        private void PDtxt2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) buttonX2.Focus();
            if (e.KeyCode == Keys.Up) PDtxt1.Focus();
        }

        private void buttonX2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyCode == Keys.Up) PDtxt2.Focus();
        }

        private void buttonX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyCode == Keys.Up) buttonX2.Focus();
        }

        private void crystalReportViewer1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }
    }
}
