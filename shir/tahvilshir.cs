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
    public partial class tahvilshir : Office2007Form
    {
        string sql, code, date, nobat,name_mosh;
        public int type;
        connect con;

        public tahvilshir()
        {
            InitializeComponent();
            con = new connect();
        }

        private void tahvilshir_Load(object sender, EventArgs e)
        {
            //btnRight.Text= FreeControls.PersianDate.Now.ToString("yyyy/MM/dd");
            btnLeft.Text = Persia.Calendar.ConvertToPersian(DateTime.Now).ToString("W");
            btnCenter.Text = "مرکز پخش شیر....";
            txt1.Focus();
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13)
            {
                con.connection();
                DataTable dt = con.show_data("select code'کد مشتری',name+N' '+family'نام و نام خانوادگی' from moshtary where code = N'" + txt1.Text + "' AND codemar = N'"+function.Code_markaz+"' ");
                con.Disconnect();
                if (dt.Rows.Count == 0)
                {
                    txt2.Text = "";
                    txt1.Text = "";
                }
                else
                {
                    txt1.Text = dt.Rows[0].ItemArray.GetValue(0).ToString();
                    txt2.Text = dt.Rows[0].ItemArray.GetValue(1).ToString();
                }
                Ptxt3.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                dataGridViewX1.Visible = true;
                dataGridViewX1.Focus();
                con.connection();
                if (txt1.Text == "")
                    sql = "select code'کد مشتری',name+N' '+family'نام و نام خانوادگی' from moshtary";
                else
                    sql = "select code'کد مشتری',name+N' '+family'نام و نام خانوادگی' from moshtary where (code LIKE N'" + txt1.Text + "%') AND (codemar = N'" + function.Code_markaz + "')";
                dataGridViewX1.DataSource = con.show_data(sql);
                con.Disconnect();
            }
        }

        private void PDTP1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13)
                txt4.Focus();
        }

        private void cBE1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13)
                txt5.Focus();
        }

        private void mTB2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13)
                txt6.Focus();
        }

        private void mTB3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13)
                txt7.Focus();
        }

        private void intI1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13)
                txt8.Focus();
        }

        private void mTB4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13)
                txt9.Focus();
        }

        private void mTB5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13)
                txt10.Focus();
        }

        private void cBE2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13)
                txt11.Focus();
        }

        private void mTB6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13)
                txt12.Focus();
        }

        private void mTB7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13)
                txt13.Focus();
        }

        private void mTB8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13)
                txt14.Focus();
        }

        private void cBE3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13)
                txt15.Focus();
        }

        private void tB2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13)
                btn1.Focus();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            string date = Ptxt3.Value.Year.ToString() + "/" + (Ptxt3.Value.Month < 10 ? "0" + Ptxt3.Value.Month.ToString() : Ptxt3.Value.Month.ToString()) + "/" + (Ptxt3.Value.Day < 10 ? "0" + Ptxt3.Value.Day.ToString() : Ptxt3.Value.Day.ToString());
            if (type == 1)
                sql = "INSERT INTO tahvilshir(codemosh, name, tarikh, nobat, shirtahvili, ab, jarime, dansite, asidite, alkol, ph, enjemad, dama, joosh, tozih)" +
                      " VALUES(N'" + txt1.Text + "', N'" + txt2.Text + "', N'" + date + "', N'" + txt4.Text + "', N'" + txt5.Text + "', N'" + txt6.Text + "', N'" + 
                      txt7.Value.ToString() + "', N'" + txt8.Text + "', N'" + txt9.Text + "', N'" + txt10.Text + "', N'" + txt11.Text + "', N'" + txt12.Text + "', N'" + txt13.Text + "', N'" + txt14.Text + "', N'" + txt15.Text + "')";
            if (type == 2)
                sql = "UPDATE tahvilshir SET codemosh = N'" + txt1.Text + "', name = N'" + txt2.Text + "', tarikh = N'" + date + "', nobat = N'" + txt4.Text + "', shirtahvili = N'" + txt5.Text + "', ab = N'" + txt6.Text + "', jarime = N'" + txt7.Value.ToString() + 
                    "', dansite = N'" + txt8.Text + "', asidite = N'" + txt9.Text + "', alkol = N'" + txt10.Text + "', ph = N'" + txt11.Text + "', " +
                    " enjemad = N'" + txt15.Text + "', dama = N'" + txt15.Text + "', joosh = N'" + txt15.Text + "', tozih = N'" + txt15.Text + "' WHERE (codemosh = N'" + code + "') AND (tarikh = N'" + date + "') AND (nobat = N'" + nobat + "')";

            con.connection();

            if (con.exe_data(sql))
            {
                FMessegeBox.FarsiMessegeBox.Show("اطلاعات با موفقیت ثبت شد");

            }
            else
            {
                FMessegeBox.FarsiMessegeBox.Show("مشکل در ذخیره اطلاعات", "خطا", FMessegeBox.FMessegeBoxButtons.Ok, FMessegeBox.FMessegeBoxIcons.Error);

            }
            if (type == 2) this.Close();
            clear();
            txt1.Focus();
            con.Disconnect();
        }

        private void clear()
        {
            txt1.Text = txt11.Text = txt12.Text = txt13.Text = txt15.Text =
                txt2.Text = txt5.Text = txt6.Text = txt8.Text = txt9.Text = "";
            txt7.Value = 0;
        }



        internal void settxt(DataGridViewRow dg)
        {
            code = txt1.Text = dg.Cells[0].Value.ToString();
            txt2.Text = dg.Cells[1].Value.ToString();
            Ptxt3.Value = FreeControls.PersianDate.Parse(dg.Cells[2].Value.ToString());
            txt4.Text = dg.Cells[3].Value.ToString();
            txt5.Text = dg.Cells[4].Value.ToString();
            txt6.Text = dg.Cells[5].Value.ToString();
            txt7.Value = int.Parse(dg.Cells[6].Value.ToString());
            txt8.Text = dg.Cells[7].Value.ToString();
            txt9.Text = dg.Cells[8].Value.ToString();
            txt10.Text = dg.Cells[9].Value.ToString();
            txt11.Text = dg.Cells[10].Value.ToString();
            txt12.Text = dg.Cells[11].Value.ToString();
            txt13.Text = dg.Cells[12].Value.ToString();
            txt14.Text = dg.Cells[13].Value.ToString();
            txt15.Text = dg.Cells[14].Value.ToString();
        }

        private void txt1_Leave(object sender, EventArgs e)
        {
            if (txt1.Text == "")
                Error.Visible = true;
            else
                Error.Visible = false;
        }

        private void dataGridViewX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                dataGridViewX1.Visible = false;
                Ptxt3.Focus();
            }
            if (e.KeyValue == 13)
            {
                dataGridViewX1.Visible = false;
                Ptxt3.Focus();
            }
        }
        int flag = 0;
        private void dataGridViewX1_Leave(object sender, EventArgs e)
        {
            dataGridViewX1.Visible = false;

            flag = 0;
            dataGridViewX1.DataSource = null;
        }

        private void dataGridViewX1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewX1.RowCount == 0)
                return;

            if (flag == 0)
            {
                txt1.Text = dataGridViewX1.Rows[0].Cells[0].Value.ToString();
                txt2.Text = dataGridViewX1.Rows[0].Cells[1].Value.ToString();
                flag++;
                return;
            }
            txt1.Text = dataGridViewX1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt2.Text = dataGridViewX1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
