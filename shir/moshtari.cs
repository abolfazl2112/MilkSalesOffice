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
    public partial class moshtari : Office2007Form
    {
        string sql = "";
        DataTable data;
        connect con = new connect();
        int flag = 0;

        public moshtari()
        {
            InitializeComponent();
        }

        private void moshtari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.moshtary' table. You can move, or remove it, as needed.
            this.moshtaryTableAdapter.Fill(this.dataSet.moshtary);
            //btnRight.Text= FreeControls.PersianDate.Now.ToString("yyyy/MM/dd");
            btnLeft.Text = Persia.Calendar.ConvertToPersian(DateTime.Now).ToString("W");
            btnCenter.Text = "مرکز پخش شیر....";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            groupPanel2.Enabled = true;
            groupPanel1.Enabled = groupPanel3.Enabled = false;
            mtxt1.Focus();
            flag = 1;
        }

        public void key27()
        {
            clear();
            groupPanel1.Enabled = groupPanel3.Enabled = true;
            groupPanel2.Enabled = false;
            dataGridViewX1.Focus();
        }

        public void clear()
        {
            mtxt1.Text = mtxt2.Text = txt3.Text = txt4.Text = txt5.Text = txt6.Text = txt7.Text = txt8.Text = "";
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                mtxt1.Focus();
                return;
            }
            if (flag == 1)
            {
                sql = "INSERT INTO moshtary(code, codemar, name, family, phon, kosoorat, shhesab, address)"+
                      "VALUES(N'" + mtxt1.Text + "', N'" + mtxt2.Text + "', N'" + txt3.Text + "', N'" + txt4.Text + "', N'" + txt5.Text + "', N'" + txt6.Text + "', N'" + txt7.Text + "', N'" + txt8.Text + "')";
            }
            else if (flag == 2)
            {
                sql = "UPDATE moshtary "+
                "SET code = N'"+mtxt1.Text+"', codemar = N'"+mtxt2.Text+"', name = N'"+txt3.Text+"', family = N'"+txt4.Text+"', "+
                "phon = N'"+txt5.Text+"', kosoorat = N'"+txt6.Text+"', shhesab = N'"+txt7.Text+"', address = N'"+txt8.Text+"' "+
                " WHERE (code = N'"+dataGridViewX1.CurrentRow.Cells[0].Value.ToString()+"')";
            }
            con.connection();
            
            if (con.exe_data(sql))
            {
                dataGridViewX1.DataSource = con.show_data("select * from moshtary");
                FMessegeBox.FarsiMessegeBox.Show("اطلاعات با موفقیت ثبت شد");
            }
            else
                FMessegeBox.FarsiMessegeBox.Show("مشکل در ذخیره اطلاعات", "اخطار", FMessegeBox.FMessegeBoxButtons.Ok, FMessegeBox.FMessegeBoxIcons.Error);
            clear();
            if (flag == 2)
                key27();
            else
                mtxt1.Focus();
            con.Disconnect();
        }

        private void mtxt1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 13:
                    mtxt2.Text = function.Code_markaz;
                    con.connection();
                    data = con.show_data("select * from moshtary where (code = N'" + mtxt1.Text + "') AND (codemar = N'" + mtxt2.Text + "')");
                    con.Disconnect();
                    if (data.Rows.Count != 0)
                    {
                        txt3.Text = data.Rows[0].ItemArray.GetValue(2).ToString();
                        txt4.Text = data.Rows[0].ItemArray.GetValue(3).ToString();
                        txt5.Text = data.Rows[0].ItemArray.GetValue(4).ToString();
                        txt6.Text = data.Rows[0].ItemArray.GetValue(5).ToString();
                        txt7.Text = data.Rows[0].ItemArray.GetValue(6).ToString();
                        txt8.Text = data.Rows[0].ItemArray.GetValue(7).ToString();
                        flag = 2;
                    }
                    txt3.Focus(); 
                    break;

                case 27:
                    key27(); break;
            }
        }

        private void mtxt2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 13:
                    txt3.Focus(); break;
                case 27:
                    key27(); break;
            }
        }

        private void txt3_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 13:
                    txt4.Focus(); break;
                case 27:
                    key27(); break;
            }
        }

        private void txt4_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 13:
                    txt5.Focus(); break;
                case 27:
                    key27(); break;
            }
        }

        private void txt5_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 13:
                    txt6.Focus(); break;
                case 27:
                    key27(); break;
            }
        }

        private void txt6_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 13:
                    txt7.Focus(); break;
                case 27:
                    key27(); break;
            }
        }

        private void txt7_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 13:
                    txt8.Focus(); break;
                case 27:
                    key27(); break;
            }
        }

        private void txt8_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 13:
                    btn0.Focus(); break;
                case 27:
                    key27(); break;
            }
        }

        private void btn0_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    key27(); break;
            }
        }

        private void btn1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void dataGridViewX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btn2_Click(null, null);
            }
            else if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            groupPanel2.Enabled = true;
            groupPanel1.Enabled = groupPanel3.Enabled = false;
            mtxt1.Focus();
            settxt();
            flag = 2;
        }

        private void settxt()
        {
            mtxt1.Text = dataGridViewX1.CurrentRow.Cells[0].Value.ToString();
            mtxt2.Text = dataGridViewX1.CurrentRow.Cells[1].Value.ToString();
            txt3.Text = dataGridViewX1.CurrentRow.Cells[2].Value.ToString();
            txt4.Text = dataGridViewX1.CurrentRow.Cells[3].Value.ToString();
            txt5.Text = dataGridViewX1.CurrentRow.Cells[4].Value.ToString();
            txt6.Text = dataGridViewX1.CurrentRow.Cells[5].Value.ToString();
            txt7.Text = dataGridViewX1.CurrentRow.Cells[6].Value.ToString();
            txt8.Text = dataGridViewX1.CurrentRow.Cells[7].Value.ToString();
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.RowCount == 0)
                return;

            if (FMessegeBox.FarsiMessegeBox.Show("آیا برای حذف مطمئن هستید؟", "", FMessegeBox.FMessegeBoxButtons.YesNo, FMessegeBox.FMessegeBoxIcons.Question) == DialogResult.No)
            {
                return;
            }
            sql = "DELETE FROM moshtary WHERE (code = N'" + dataGridViewX1.CurrentRow.Cells[0].Value.ToString() + "')";
            con.connection();
            if (con.exe_data(sql))
            {
                dataGridViewX1.DataSource = con.show_data("select * from moshtary");
                FMessegeBox.FarsiMessegeBox.Show("اطلاعات با موفقیت ثبت شد");
            }
            else
                FMessegeBox.FarsiMessegeBox.Show("مشکل در ذخیره اطلاعات", "اخطار", FMessegeBox.FMessegeBoxButtons.Ok, FMessegeBox.FMessegeBoxIcons.Error);
            con.Disconnect();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            key27();
        }

        private void buttonX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) key27();
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

            printer.Title = "لیست مشتریان";
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

            printer.PrintPreviewDataGridView(dataGridViewX1);

            this.Cursor = Cursors.Default;
        }
    }
}
