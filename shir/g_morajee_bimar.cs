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

namespace system
{
    public partial class g_morajee_bimar : Office2007Form
    {
        connect con = new connect();
        string name_bimar, sql;
        public g_morajee_bimar()
        {
            InitializeComponent();
        }

        private void g_morajee_bimar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.analizeshir' table. You can move, or remove it, as needed.
            this.analizeshirTableAdapter.Fill(this.dataSet.analizeshir);
            btnLeft.Text = Persia.Calendar.ConvertToPersian(DateTime.Now).ToString("W");

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            /*if (intcode.Text == "")
            {
                labelX2.Visible = true;
                intcode.Focus();
                return;
            }

            labelX2.Visible = false;
            connect con = new connect();
            con.connection();
            DataTable dt = con.show_data("select date, elat,bimekonande,sbimar,mablagh,ssazman from veroozane where (shdaftarche = N'" + intcode.Text + "' )");
            con.Disconnect();
            if (dt.Rows.Count == 0)
            {
                FMessegeBox.FarsiMessegeBox.Show("اطلاعاتی یاقت نشد");
                intcode.Focus();
                return;
            }
            string date1 = PDtxt1.Value.Year.ToString() + "/" + (PDtxt1.Value.Month < 10 ? "0" + PDtxt1.Value.Month.ToString() : PDtxt1.Value.Month.ToString()) + "/" + (PDtxt1.Value.Day < 10 ? "0" + PDtxt1.Value.Day.ToString() : PDtxt1.Value.Day.ToString());
            string date2 = PDtxt2.Value.Year.ToString() + "/" + (PDtxt2.Value.Month < 10 ? "0" + PDtxt2.Value.Month.ToString() : PDtxt1.Value.Month.ToString()) + "/" + (PDtxt2.Value.Day < 10 ? "0" + PDtxt2.Value.Day.ToString() : PDtxt2.Value.Day.ToString());

            FreeControls.PersianDate pd1 = FreeControls.PersianDate.Parse(date1);
            FreeControls.PersianDate pd2 = FreeControls.PersianDate.Parse(date2);
            double jamekol = 0, jamebimar = 0, jamesaz = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!IsOK(dt.Rows[i].ItemArray.GetValue(0).ToString(), pd1, pd2))
                {
                    dt.Rows.RemoveAt(i--);
                    continue;
                }
                jamebimar += double.Parse((dt.Rows[i].ItemArray.GetValue(3).ToString() == "" ? "0" : dt.Rows[i].ItemArray.GetValue(3).ToString()));
                jamekol += double.Parse((dt.Rows[i].ItemArray.GetValue(4).ToString() == "" ? "0" : dt.Rows[i].ItemArray.GetValue(4).ToString()));
                jamesaz += double.Parse((dt.Rows[i].ItemArray.GetValue(5).ToString() == "" ? "0" : dt.Rows[i].ItemArray.GetValue(5).ToString()));
            }

            */btnRight.Enabled = true;
            btnRight.Focus();
        }

        private bool IsOK(string PersianDate, FreeControls.PersianDate PD1, FreeControls.PersianDate PD2)
        {
            FreeControls.PersianDate date = FreeControls.PersianDate.Parse(PersianDate);

            if (FreeControls.PersianDate.Compare2Date(PD1, date) == 1 || FreeControls.PersianDate.Compare2Date(PD2, date) == -1)
                return false;
            return true;
        }

        private void intcode_KeyDown(object sender, KeyEventArgs e)
        {
        }

        int flag = 0;

        private void dataGridViewX1_Leave(object sender, EventArgs e)
        {
        }

        private void dataGridViewX1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridViewX1_KeyDown(object sender, KeyEventArgs e)
        {
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

        private void btnRight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            system.DGVPrinter printer = new system.DGVPrinter();
            printer.CellAlignment = StringAlignment.Center;
            printer.CellFormatFlags = StringFormatFlags.DirectionRightToLeft;
            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.HeaderCellFormatFlags = StringFormatFlags.DirectionRightToLeft;
            printer.PageNumberAlignment = StringAlignment.Near;
            printer.PageNumberInHeader = true;
            printer.PageNumberOnSeparateLine = true;
            printer.PageNumbers = true;
            printer.PorportionalColumns = true;

            printer.Title = txtOnvan.Text;
            printer.TitleAlignment = StringAlignment.Center;
            printer.TitleColor = Color.Blue;
            printer.TitleFont = new Font("Arial", 14);
            printer.TitleFormatFlags = StringFormatFlags.DirectionRightToLeft;

            //printer.SubTitle = " ";
            //printer.SubTitleAlignment = StringAlignment.Center;
            //printer.SubTitleColor = Color.Blue;
            //printer.SubTitleFont = new Font("Arial", 14);
            //printer.SubTitleFormatFlags = StringFormatFlags.DirectionRightToLeft;

            //printer.Footer = "Footer";
            //printer.FooterAlignment = StringAlignment.Center;
            //printer.FooterColor = Color.Blue;
            //printer.FooterFont = new Font("Arial", 14);
            //printer.FooterFormatFlags = 
            //StringFormatFlags.DirectionRightToLeft;
            //printer.FooterSpacing = 10;

            printer.PrintPreviewDataGridView(dataGridViewX2);

            this.Cursor = Cursors.Default;

        }

        private void intcode_Leave(object sender, EventArgs e)
        {
        }

        private void intcode_Enter(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("fa-ir");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);
        }

        private void buttonX2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyCode == Keys.Up) PDtxt2.Focus();
        }

        private void buttonX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyCode == Keys.Up) buttonX1.Focus();
        }


        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
