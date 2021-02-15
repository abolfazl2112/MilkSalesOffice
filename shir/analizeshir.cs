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
    public partial class analizeshir : Office2007Form
    {
        connect con;
        string sql, code, dat, nobat;
        public int type;

        public analizeshir()
        {
            InitializeComponent();
            con = new connect();
        }

        private void analizeshir_Load(object sender, EventArgs e)
        {
            //btnRight.Text= FreeControls.PersianDate.Now.ToString("yyyy/MM/dd");
            btnLeft.Text = Persia.Calendar.ConvertToPersian(DateTime.Now).ToString("W");
            btnCenter.Text = "مرکز پخش شیر....";
            txt1.Focus();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string date = Ptxt3.Value.Year.ToString() + "/" + (Ptxt3.Value.Month < 10 ? "0" + Ptxt3.Value.Month.ToString() : Ptxt3.Value.Month.ToString()) + "/" + (Ptxt3.Value.Day < 10 ? "0" + Ptxt3.Value.Day.ToString() : Ptxt3.Value.Day.ToString());
            
            if (type == 1)
                sql = "INSERT INTO analizeshir (codemosh, name, date, nobat, charbi, dama, microb, tozih)"+
                      " VALUES(N'"+txt1.Text+"', N'"+txt2.Text+"', N'"+date+"', N'"+txt3.Text+"', N'"+txt4.Text+"', N'"+txt5.Text+"', N'"+txt6.Text+"', N'"+txt7.Text+"')";

            if (type == 2)
                sql = "UPDATE analizeshir SET codemosh = N'" + txt1.Text + "', name = N'" + txt2.Text + "', date = N'"+date+"', nobat = N'" + txt3.Text + "', charbi = N'" + txt4.Text + "', dama = N'" + txt5.Text + "', microb = N'" + txt6.Text + "', tozih = N'" + txt7.Text + "' "+
                    " WHERE (codemosh = N'" + code + "' and date = N'" + dat + "' and nobat = N'" + nobat + "')";

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
            txt1.Text = txt2.Text = txt4.Text = txt5.Text = txt6.Text = txt7.Text = "";
        }

        internal void settxt(DataGridViewRow dg)
        {
            code = txt1.Text = dg.Cells[0].Value.ToString();
            txt2.Text = dg.Cells[1].Value.ToString();
            dat = dg.Cells[2].Value.ToString();
            Ptxt3.Value = FreeControls.PersianDate.Parse(dg.Cells[2].Value.ToString());

            nobat = txt3.Text = dg.Cells[3].Value.ToString();
            txt4.Text = dg.Cells[4].Value.ToString();
            txt5.Text = dg.Cells[5].Value.ToString();
            txt6.Text = dg.Cells[6].Value.ToString();
            txt7.Text = dg.Cells[7].Value.ToString();
        }

        private void btn1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
        }

        private void txt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13)
            {
                con.connection();
                DataTable dt = con.show_data("select code'کد مشتری',name+N' '+family'نام و نام خانوادگی' from moshtary where code = N'" + txt1.Text + "' AND codemar = N'" + function.Code_markaz + "' ");
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
                    sql = "select code'کد مشتری',name+N' '+family'نام و نام خانوادگی' from moshtary where (code LIKE N'" + txt1.Text + "'%) AND (codemar = N'" + function.Code_markaz + "')";
                dataGridViewX1.DataSource = con.show_data(sql);
                con.Disconnect();
            }
        }

        private void Ptxt3_KeyDown(object sender, KeyEventArgs e)
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
            if (e.KeyValue == 13) btn1.Focus();
        }

        private void txt1_Leave(object sender, EventArgs e)
        {
            if (txt1.Text == "")
                Error.Visible = true;
            else
                Error.Visible = false;
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
    }
}
