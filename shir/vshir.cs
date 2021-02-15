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
    public partial class vshir : Office2007Form
    {
        public int typ;
        connect con;
        string sql, codemar, day, nobat, name_mar;
        
        public vshir()
        {
            InitializeComponent();
            con = new connect();
        }

        private void vshir_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.markaz' table. You can move, or remove it, as needed.
            this.markazTableAdapter.Fill(this.dataSet.markaz);
            //btnRight.Text= FreeControls.PersianDate.Now.ToString("yyyy/MM/dd");
            btnLeft.Text = Persia.Calendar.ConvertToPersian(DateTime.Now).ToString("W");
            btnCenter.Text = "مرکز پخش شیر....";
        }

        public void setstr(DataGridViewRow dr)
        {
            codemar = mtxt1.Text = dr.Cells[0].Value.ToString();
            txt2.Text = dr.Cells[1].Value.ToString();
            PDtxt3.Value = FreeControls.PersianDate.Parse(dr.Cells[2].Value.ToString());
            day = dr.Cells[2].Value.ToString();
            
            nobat = cbtxt4.Text = dr.Cells[3].Value.ToString();
            mtxt5.Text = dr.Cells[4].Value.ToString();
            mTxt6.Text = dr.Cells[5].Value.ToString();
            mtxt7.Text = dr.Cells[6].Value.ToString();
            mtxt8.Text = dr.Cells[7].Value.ToString();
            mtxt9.Text = dr.Cells[8].Value.ToString();
            mtxt10.Text = dr.Cells[9].Value.ToString();
            cbtxt11.Text = dr.Cells[10].Value.ToString();
            mtxt12.Text = dr.Cells[11].Value.ToString();
            mtxt13.Text = dr.Cells[12].Value.ToString();
            mtxt14.Text = dr.Cells[13].Value.ToString();
            txt15.Text = dr.Cells[14].Value.ToString();
            mtxt16.Text = dr.Cells[15].Value.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //string date = PDtxt3.Value.Year.ToString() + "/" + (PDtxt3.Value.Month < 10 ? "0" + PDtxt3.Value.Month.ToString() : PDtxt3.Value.Month.ToString()) + "/" + (PDtxt3.Value.Day < 10 ? "0" + PDtxt3.Value.Day.ToString() : PDtxt3.Value.Day.ToString()) + " " + (PDtxt3.Value.Hour < 10 ? "0" + PDtxt3.Value.Hour.ToString() : PDtxt3.Value.Hour.ToString()) + ":" + (PDtxt3.Value.Minute < 10 ? "0" + PDtxt3.Value.Minute.ToString() : PDtxt3.Value.Minute.ToString());
            string date = PDtxt3.Value.Year.ToString() + "/" + (PDtxt3.Value.Month < 10 ? "0" + PDtxt3.Value.Month.ToString() : PDtxt3.Value.Month.ToString()) + "/" + (PDtxt3.Value.Day < 10 ? "0" + PDtxt3.Value.Day.ToString() : PDtxt3.Value.Day.ToString());
             
            if (typ == 1)
            {
                sql = "INSERT INTO vshir(codemar, namemar, date, nobat, tshir, charbi, dansite, proten, ab, asidite, alkol, enjemad, dama, mikrob, tozihat, barname) "+
                      "VALUES(N'"+mtxt1.Text+"', N'"+txt2.Text+"', N'"+date+"', N'"+cbtxt4.Text+"', N'"+mtxt5.Text+"', N'"+mTxt6.Text+"', N'"+mtxt7.Text+"', N'"+mtxt8.Text+"', N'"+mtxt9.Text+"', N'"+mtxt10.Text+"', N'"+cbtxt11.Text+"', N'"+mtxt12.Text+"', N'"+mtxt13.Text+"', N'"+mtxt14.Text+"', N'"+txt15.Text+"', N'"+mtxt16.Text+"')";
            }
            else if (typ == 2)
            {
                sql = "UPDATE vshir SET codemar = N'"+mtxt1.Text+"', namemar = N'"+txt2.Text+"', date = N'"+date+"', nobat = N'"+cbtxt4.Text+"', tshir = N'"+mtxt5.Text+"', charbi = N'"+mTxt6.Text+"', dansite = N'"+mtxt7.Text+"', proten = N'"+mtxt8.Text+"', ab = N'"+mtxt9.Text+"', asidite = N'"+mtxt10.Text+"', alkol = N'"+cbtxt11.Text+
                    "',enjemad = N'"+mtxt12.Text+"', dama = N'"+mtxt13.Text+"', mikrob = N'"+mtxt14.Text+"', tozihat = N'"+txt15.Text+"', barname = N'"+mtxt16.Text+"' "+
                    " WHERE (codemar = N'"+codemar+"') AND (date = N'"+day+"') AND (nobat = N'"+nobat+"')";
            }
            con.connection();
            if (con.exe_data(sql))
                FMessegeBox.FarsiMessegeBox.Show("اطلاعات با موفقیت ثبت شد");
            else
                FMessegeBox.FarsiMessegeBox.Show("مشکل در ذخیره اطلاعات", "اخطار", FMessegeBox.FMessegeBoxButtons.Ok, FMessegeBox.FMessegeBoxIcons.Error);

            con.Disconnect();

            if (typ == 2)
                this.Close();
            
            cleartxt();
            mtxt1.Focus();
        }

        private void cleartxt()
        {
            mtxt1.Text = mtxt10.Text = mtxt12.Text = mtxt13.Text = mtxt14.Text = mtxt16.Text = mTxt6.Text = mtxt5.Text = mtxt7.Text
                = mtxt8.Text = mtxt9.Text = txt15.Text = txt2.Text = "";
        }

        private void mtxt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) this.Close();
            if (e.KeyValue == 13)
            {
                con.connection();
                DataTable dt = con.show_data("select codemar'کد مرکز',name'نام مرکز' from markaz where code = N'" + mtxt1.Text + "' ");
                con.Disconnect();
                if (dt.Rows.Count == 0)
                {
                    txt2.Text = "";
                    mtxt1.Text = "";
                }
                else
                {
                    mtxt1.Text = dt.Rows[0].ItemArray.GetValue(0).ToString();
                    txt2.Text = dt.Rows[0].ItemArray.GetValue(1).ToString();
                }
                PDtxt3.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                dataGridViewX1.Visible = true;
                dataGridViewX1.Focus();
                con.connection();
                if (mtxt1.Text == "")
                    sql = "select codemar'کد مرکز',name'نام مرکز' from markaz";
                else
                    sql = "select codemar'کد مرکز',name'نام مرکز' from markaz where (codemar LIKE N'" + mtxt1.Text + "'%)";
                dataGridViewX1.DataSource = con.show_data(sql);
                con.Disconnect();
            }
        }

        private void PDtxt3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                cbtxt4.Focus();
            if (e.KeyValue == 27)
                this.Close();
        }

        private void cbtxt4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                mtxt5.Focus();
            if (e.KeyValue == 27)
                this.Close();
        }

        private void mtxt5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                mTxt6.Focus();
            if (e.KeyValue == 27)
                this.Close();
        }

        private void mTxt6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                mtxt7.Focus();
            if (e.KeyValue == 27)
                this.Close();
        }

        private void mtxt7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                mtxt8.Focus();
            if (e.KeyValue == 27)
                this.Close();
        }

        private void mtxt8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                mtxt9.Focus();
            if (e.KeyValue == 27)
                this.Close();
        }

        private void mtxt9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                mtxt10.Focus();
            if (e.KeyValue == 27)
                this.Close();
        }

        private void mtxt10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                cbtxt11.Focus();
            if (e.KeyValue == 27)
                this.Close();
        }

        private void cbtxt11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                mtxt12.Focus();
            if (e.KeyValue == 27)
                this.Close();
        }

        private void mtxt12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                mtxt13.Focus();
            if (e.KeyValue == 27)
                this.Close();
        }

        private void mtxt13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                mtxt14.Focus();
            if (e.KeyValue == 27)
                this.Close();
        }

        private void mtxt14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                txt15.Focus();
            if (e.KeyValue == 27)
                this.Close();
        }

        private void txt15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                mtxt16.Focus();
            if (e.KeyValue == 27)
                this.Close();
        }

        private void mtxt16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btn1.Focus();
            if (e.KeyValue == 27)
                this.Close();
        }

        private void btn1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                mtxt1.Focus();
            if (e.KeyValue == 27)
                this.Close();
        }

        private void mtxt1_Leave(object sender, EventArgs e)
        {
            if (mtxt1.Text == "")
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
                mtxt1.Text = dataGridViewX1.Rows[0].Cells[0].Value.ToString();
                txt2.Text = dataGridViewX1.Rows[0].Cells[1].Value.ToString();
                flag++;
                return;
            }
            mtxt1.Text = dataGridViewX1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt2.Text = dataGridViewX1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dataGridViewX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                dataGridViewX1.Visible = false;
                PDtxt3.Focus();
            }
            if (e.KeyValue == 13)
            {
                dataGridViewX1.Visible = false;
                PDtxt3.Focus();
            }
        }
    }
}
