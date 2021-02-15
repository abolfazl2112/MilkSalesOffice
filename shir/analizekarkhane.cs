﻿using System;
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
    public partial class analizekarkhane : Office2007Form
    {
        public int type;
        string sql, code;
        connect con;
        public analizekarkhane()
        {
            InitializeComponent();
            con = new connect();
        }

        private void analizekarkhane_Load(object sender, EventArgs e)
        {
            //btnRight.Text= FreeControls.PersianDate.Now.ToString("yyyy/MM/dd");
            btnLeft.Text = Persia.Calendar.ConvertToPersian(DateTime.Now).ToString("W");
            btnCenter.Text = "مرکز پخش شیر....";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string date = ptxt13.Value.Year.ToString() + "/" + (ptxt13.Value.Month < 10 ? "0" + ptxt13.Value.Month.ToString() : ptxt13.Value.Month.ToString()) + "/" + (ptxt13.Value.Day < 10 ? "0" + ptxt13.Value.Day.ToString() : ptxt13.Value.Day.ToString()) +
                " " + (ptxt13.Value.Hour < 10 ? "0" + ptxt13.Value.Hour.ToString() : ptxt13.Value.Hour.ToString()) + ":" + (ptxt13.Value.Minute < 10 ? "0" + ptxt13.Value.Minute.ToString() : ptxt13.Value.Minute.ToString()); 

            if (type == 1)
                sql = "INSERT INTO analizekarkhane(codemahmole, codemahersal, shirtah, charbi, proten, microb, ab, dansite, asidite, alkol, enjemad, dama, date, coderan, nameran, codemagh, namemagh, namayande, tozih)" +
                      " VALUES(N'" + txt1.Text + "', N'" + txt2.Text + "', N'" + txt3.Text + "', N'" + txt4.Text + "', N'" + txt5.Text + "', N'" + txt6.Text + "', N'" + txt7.Text + "', N'" + txt8.Text + "', N'" + txt9.Text + "', N'" + txt10.Text + "', N'"+
                      txt11.Text + "', N'" + txt12.Text + "', N'" + date + "', N'" + txt14.Text + "', N'" + txt15.Text + "', N'" + txt16.Text + "', N'" + txt17.Text + "', N'" + txt18.Text + "', N'" + txt19.Text + "')";
            if (type == 2)
                sql = "UPDATE analizekarkhane SET codemahmole = N'"+txt1.Text+"', codemahersal = N'"+txt2.Text+"', shirtah = N'"+txt3.Text+"', charbi = N'"+txt4.Text+"', proten = N'"+txt5.Text+"', microb = N'"+txt6.Text+"', ab = N'"+txt7.Text+"', dansite = N'"+txt8.Text+"', asidite = N'"+txt9.Text+"', alkol = N'"+txt10.Text+"', "+ 
                         "enjemad = N'"+txt11.Text+"', dama = N'"+txt12.Text+"', date = N'"+date+"', coderan = N'"+txt14.Text+"', nameran = N'"+txt15.Text+"', codemagh = N'"+txt16.Text+"', namemagh = N'"+txt17.Text+"', namayande = N'"+txt18.Text+"', tozih = N'"+txt19.Text+"' WHERE(codemahmole = N'"+code+"')";

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
            txt1.Text = txt2.Text = txt3.Text = txt4.Text = txt5.Text = txt6.Text = txt7.Text = txt8.Text = txt9.Text =
                txt10.Text = txt11.Text = txt12.Text = txt15.Text = txt14.Text = txt16.Text = txt17.Text = txt18.Text = txt19.Text = "";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void settxt(DataGridViewRow dg)
        {
            txt1.Text = dg.Cells[0].Value.ToString();
            txt2.Text = dg.Cells[1].Value.ToString();
            txt3.Text = dg.Cells[2].Value.ToString();
            txt4.Text = dg.Cells[3].Value.ToString();
            txt5.Text = dg.Cells[4].Value.ToString();
            txt6.Text = dg.Cells[5].Value.ToString();
            txt7.Text = dg.Cells[6].Value.ToString();
            txt8.Text = dg.Cells[7].Value.ToString();
            txt9.Text = dg.Cells[8].Value.ToString();
            txt10.Text = dg.Cells[9].Value.ToString();
            txt11.Text = dg.Cells[10].Value.ToString();
            txt12.Text = dg.Cells[11].Value.ToString();
            ptxt13.Value = FreeControls.PersianDate.Parsewh(dg.Cells[12].Value.ToString());
            txt14.Text = dg.Cells[13].Value.ToString();
            txt15.Text = dg.Cells[14].Value.ToString();
            txt16.Text = dg.Cells[15].Value.ToString();
            txt17.Text = dg.Cells[16].Value.ToString();
            txt18.Text = dg.Cells[17].Value.ToString();
        }

        private void txt1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    this.Close(); break;
                case 13:
                    con.connection();
                    DataTable data = con.show_data("select * from analizekarkhane where (codemahmole = N'" + txt1.Text + "')");
                    con.Disconnect();
                    if (data.Rows.Count != 0)
                    {
                        txt2.Text = data.Rows[0].ItemArray.GetValue(1).ToString();
                        txt3.Text = data.Rows[0].ItemArray.GetValue(2).ToString();
                        txt4.Text = data.Rows[0].ItemArray.GetValue(3).ToString();
                        txt5.Text = data.Rows[0].ItemArray.GetValue(4).ToString();
                        txt6.Text = data.Rows[0].ItemArray.GetValue(5).ToString();
                        txt7.Text = data.Rows[0].ItemArray.GetValue(6).ToString();
                        txt8.Text = data.Rows[0].ItemArray.GetValue(7).ToString();
                        txt9.Text = data.Rows[0].ItemArray.GetValue(8).ToString();
                        txt10.Text = data.Rows[0].ItemArray.GetValue(9).ToString();
                        txt11.Text = data.Rows[0].ItemArray.GetValue(10).ToString();
                        txt12.Text = data.Rows[0].ItemArray.GetValue(11).ToString();
                        ptxt13.Value = FreeControls.PersianDate.Parsewh(data.Rows[0].ItemArray.GetValue(12).ToString());
                        txt14.Text = data.Rows[0].ItemArray.GetValue(13).ToString();
                        txt15.Text = data.Rows[0].ItemArray.GetValue(14).ToString();
                        txt16.Text = data.Rows[0].ItemArray.GetValue(15).ToString();
                        txt17.Text = data.Rows[0].ItemArray.GetValue(16).ToString();
                        txt18.Text = data.Rows[0].ItemArray.GetValue(17).ToString();
                        txt19.Text = data.Rows[0].ItemArray.GetValue(18).ToString();
                        type = 2;
                    }
                    else
                    {
                        clear();
                        type = 1;
                    }
                    txt2.Focus(); break;
            }
        }

        private void txt2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    this.Close(); break;
                case 13:
                    con.connection();
                    DataTable data = con.show_data("select * from foroosheshir where (codemahmole = N'" + txt2.Text + "')");
                    con.Disconnect();
                    if (data.Rows.Count != 0)
                    {
                        lb1.Text = data.Rows[0].ItemArray.GetValue(1).ToString();
                        lb2.Text = data.Rows[0].ItemArray.GetValue(2).ToString();
                        lb3.Text = data.Rows[0].ItemArray.GetValue(3).ToString();
                        lb4.Text = data.Rows[0].ItemArray.GetValue(7).ToString();
                        lb5.Text = data.Rows[0].ItemArray.GetValue(6).ToString();
                        lb6.Text = data.Rows[0].ItemArray.GetValue(3).ToString();
                        lb7.Text = data.Rows[0].ItemArray.GetValue(4).ToString();
                        lb8.Text = data.Rows[0].ItemArray.GetValue(8).ToString();
                        lb9.Text = data.Rows[0].ItemArray.GetValue(9).ToString();
                        lb10.Text = data.Rows[0].ItemArray.GetValue(10).ToString();
                        lb11.Text = data.Rows[0].ItemArray.GetValue(13).ToString();
                        type = 2;
                    }
                    else
                    {
                        FMessegeBox.FarsiMessegeBox.Show("کد محموله ارسالی وجود ندارد");
                        clear();
                        type = 1;
                        txt2.Focus();
                        return;
                    }
                    txt3.Focus(); break;
            }
        }

        private void txt3_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    this.Close(); break;
                case 13:
                    txt4.Focus(); break;
            }
        }

        private void txt4_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    this.Close(); break;
                case 13:
                    txt5.Focus(); break;
            }
        }

        private void txt5_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    this.Close(); break;
                case 13:
                    txt6.Focus(); break;
            }
        }

        private void txt6_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    this.Close(); break;
                case 13:
                    txt7.Focus(); break;
            }
        }

        private void txt7_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    this.Close(); break;
                case 13:
                    txt8.Focus(); break;
            }
        }

        private void txt8_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    this.Close(); break;
                case 13:
                    txt9.Focus(); break;
            }
        }

        private void txt9_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    this.Close(); break;
                case 13:
                    txt10.Focus(); break;
            }
        }

        private void txt10_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    this.Close(); break;
                case 13:
                    txt11.Focus(); break;
            }
        }

        private void txt11_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    this.Close(); break;
                case 13:
                    txt12.Focus(); break;
            }
        }

        private void txt12_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    this.Close(); break;
                case 13:
                    ptxt13.Focus(); break;
            }
        }

        private void ptxt13_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    this.Close(); break;
                case 13:
                    txt14.Focus(); break;
            }
        }

        private void txt14_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    this.Close(); break;
                case 13:
                    con.connection();
                    DataTable dt = con.show_data("select coderan'کد راننده',name+N' '+family'نام و نام خانوادگی' from ranande where coderan = N'" + txt14.Text + "' ");
                    con.Disconnect();
                    if (dt.Rows.Count == 0)
                    {
                        txt15.Text = "";
                        txt14.Text = "";
                    }
                    else
                    {
                        txt14.Text = dt.Rows[0].ItemArray.GetValue(0).ToString();
                        txt15.Text = dt.Rows[0].ItemArray.GetValue(1).ToString();
                    }
                    txt16.Focus(); break;
            }
            if (e.KeyCode == Keys.Down)
            {
                dataGridViewX1.Visible = true;
                dataGridViewX1.Focus();
                con.connection();
                if (txt14.Text == "")
                    sql = "select coderan'کد راننده',name+N' '+family'نام و نام خانوادگی' from ranande";
                else
                    sql = "select coderan'کد راننده',name+N' '+family'نام و نام خانوادگی' from ranande where (coderan LIKE N'" + txt14.Text + "'%)";
                dataGridViewX1.DataSource = con.show_data(sql);
                con.Disconnect();
            }
        }

        private void txt16_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    this.Close(); break;
                case 13:
                    con.connection();
                    DataTable dt = con.show_data("select codekar'کد مقصد',name'نام مقصد' from karkhane where codekar = N'" + txt16.Text + "' ");
                    con.Disconnect();
                    if (dt.Rows.Count == 0)
                    {
                        txt17.Text = "";
                        txt16.Text = "";
                    }
                    else
                    {
                        txt16.Text = dt.Rows[0].ItemArray.GetValue(0).ToString();
                        txt17.Text = dt.Rows[0].ItemArray.GetValue(1).ToString();
                    }
                    txt18.Focus(); break;
            }
            if (e.KeyCode == Keys.Down)
            {
                dataGridViewX2.Visible = true;
                dataGridViewX2.Focus();
                con.connection();
                if (txt16.Text == "")
                    sql = "select codekar'کد مقصد',name'نام مقصد' from karkhane";
                else
                    sql = "select codekar'کد مقصد',name'نام مقصد' from karkhane where (codekar LIKE N'" + txt16.Text + "'%)";
                dataGridViewX2.DataSource = con.show_data(sql);
                con.Disconnect();
            }
        }

        private void txt18_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    this.Close(); break;
                case 13:
                    txt19.Focus(); break;
            }
        }

        private void txt19_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    this.Close(); break;
                case 13:
                    btn1.Focus(); break;
            }
        }
        int flag2 = 0, flag1 = 0;
        private void dataGridViewX2_Leave(object sender, EventArgs e)
        {
            dataGridViewX2.Visible = false;

            flag2 = 0;
            dataGridViewX2.DataSource = null;
        }

        private void dataGridViewX2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewX2.RowCount == 0)
                return;

            if (flag2 == 0)
            {
                txt16.Text = dataGridViewX2.Rows[0].Cells[0].Value.ToString();
                txt17.Text = dataGridViewX2.Rows[0].Cells[1].Value.ToString();
                flag2++;
                return;
            }
            txt16.Text = dataGridViewX2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt17.Text = dataGridViewX2.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dataGridViewX2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                dataGridViewX2.Visible = false;
                txt18.Focus();
            }
            if (e.KeyValue == 13)
            {
                dataGridViewX2.Visible = false;
                txt18.Focus();
            }
        }

        private void txt16_Leave(object sender, EventArgs e)
        {
            if (txt16.Text == "")
                Error2.Visible = true;
            else
                Error2.Visible = false;
        }

        private void dataGridViewX1_Leave(object sender, EventArgs e)
        {
            dataGridViewX1.Visible = false;

            flag1 = 0;
            dataGridViewX1.DataSource = null;
        }

        private void dataGridViewX1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewX1.RowCount == 0)
                return;

            if (flag1 == 0)
            {
                txt14.Text = dataGridViewX1.Rows[0].Cells[0].Value.ToString();
                txt15.Text = dataGridViewX1.Rows[0].Cells[1].Value.ToString();
                flag1++;
                return;
            }
            txt14.Text = dataGridViewX1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt15.Text = dataGridViewX1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dataGridViewX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                dataGridViewX1.Visible = false;
                txt16.Focus();
            }
            if (e.KeyValue == 13)
            {
                dataGridViewX1.Visible = false;
                txt16.Focus();
            }
        }

        private void txt14_Leave(object sender, EventArgs e)
        {
            if (txt14.Text == "")
                Error1.Visible = true;
            else
                Error1.Visible = false;
        }
    }
}
