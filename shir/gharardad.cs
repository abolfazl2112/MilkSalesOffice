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
    public partial class gharardad : Office2007Form
    {
        public int type;
        connect con = new connect();
        public gharardad()
        {
            InitializeComponent();
        }

        private void gharardad_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.gharardadbar' table. You can move, or remove it, as needed.
            this.gharardadbarTableAdapter.Fill(this.dataSet.gharardadbar);
            //btnRight.Text= FreeControls.PersianDate.Now.ToString("yyyy/MM/dd");
            btnLeft.Text = Persia.Calendar.ConvertToPersian(DateTime.Now).ToString("W");
            btnCenter.Text = "مرکز پخش شیر....";

            txt2.Value = FreeControls.PersianDate.Now.Year;
        }

        private void txt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) txt2.Focus();
        }

        private void txt2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) txt3.Focus();
        }

        private void txt3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) txt4.Focus();
        }

        private void txt4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) txt5.Focus();
        }

        private void txt5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) txt6.Focus();
        }

        private void txt6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) txt7.Focus();
        }

        private void txt7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) txt8.Focus();
        }

        private void txt8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) txt9.Focus();
        }

        private void txt9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) txt10.Focus();
        }

        private void txt10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) txt11.Focus();
        }

        private void txt11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) txt12.Focus();
        }

        private void txt12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) txt13.Focus();
        }

        private void txt13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) txt14.Focus();
        }

        private void txt14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) txt15.Focus();
        }

        private void txt15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) txt16.Focus();
        }

        private void txt16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) txt2.Focus();
        }

        private void txt17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) txt18.Focus();
        }

        private void txt18_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) txt22.Focus();
        }

        private void txt22_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) btn1.Focus();
        }

        private void txt19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) txt20.Focus();
        }

        private void txt20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) txt21.Focus();
        }

        private void txt21_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13) btnAdd.Focus();
        }

        private void btnAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
        }

        private void btn1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {


            txt1.Focus();
        }
    }
}
