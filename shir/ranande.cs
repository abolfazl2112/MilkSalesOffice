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
    public partial class ranande : Office2007Form
    {
        string sql = "";
        connect con = new connect();
        int flag = 0;

        public ranande()
        {
            InitializeComponent();
        }

        private void ranande_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.ranande' table. You can move, or remove it, as needed.
            this.ranandeTableAdapter.Fill(this.dataSet.ranande);
            //btnRight.Text= FreeControls.PersianDate.Now.ToString("yyyy/MM/dd");
            btnLeft.Text = Persia.Calendar.ConvertToPersian(DateTime.Now).ToString("W");
            btnCenter.Text = "مرکز پخش شیر....";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                mtxt1.Focus();
                return;
            }
            if (flag == 1)
            {
                sql = "INSERT INTO ranande(coderan, name, family, phon, shmashin, shhesab, address)"+
                      "VALUES(N'" + mtxt1.Text + "', N'" + txt2.Text + "', N'" + txt3.Text + "', N'" + txt4.Text + "', N'" + txt5.Text + "', N'" + txt6.Text + "', N'" + txt7.Text + "')";
            }
            else if (flag == 2)
            {
                sql = "UPDATE ranande SET "+
                    "coderan = N'"+mtxt1.Text+"', name = N'"+txt2.Text+"', family = N'3', phon = N'4', shmashin = N'5', "+
                    "shhesab = N'6', address = N'7' WHERE (coderan = N'"+dataGridViewX1.CurrentRow.Cells[0].Value.ToString()+"')";
            }
            con.connection();
            if (con.exe_data(sql))
            {
                FMessegeBox.FarsiMessegeBox.Show("اطلاعات با موفقیت ثبت شد");
            }
            else
                FMessegeBox.FarsiMessegeBox.Show("مشکل در ذخیره اطلاعات", "اخطار", FMessegeBox.FMessegeBoxButtons.Ok, FMessegeBox.FMessegeBoxIcons.Error);
            clear();
            dataGridViewX1.DataSource = con.show_data("select * from ranande");
            if (flag == 2)
                key27();
            else
                mtxt1.Focus();
            con.Disconnect();
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
            mtxt1.Text = txt2.Text = txt3.Text = txt4.Text = txt5.Text = txt6.Text = txt7.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            groupPanel2.Enabled = true;
            groupPanel1.Enabled = groupPanel3.Enabled = false;
            mtxt1.Focus();
            flag = 1;
        }

        private void mtxt1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 13:
                    con.connection();
                    DataTable data = con.show_data("select * from ranande where (coderan = N'" + mtxt1.Text + "')");
                    con.Disconnect();
                    if (data.Rows.Count != 0)
                    {
                        txt2.Text = data.Rows[1].ItemArray.GetValue(1).ToString();
                        txt3.Text = data.Rows[2].ItemArray.GetValue(2).ToString();
                        txt4.Text = data.Rows[3].ItemArray.GetValue(3).ToString();
                        txt5.Text = data.Rows[4].ItemArray.GetValue(4).ToString();
                        txt6.Text = data.Rows[5].ItemArray.GetValue(5).ToString();
                        txt7.Text = data.Rows[6].ItemArray.GetValue(6).ToString();
                        flag = 2;
                    }
                    txt2.Focus(); break;
                case 27:
                    key27(); break;
            }
        }

        private void txt2_KeyDown(object sender, KeyEventArgs e)
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

        private void btn2_Click(object sender, EventArgs e)
        {
            groupPanel2.Enabled = true;
            groupPanel1.Enabled = groupPanel3.Enabled = false;
            settxt();
            mtxt1.Focus();
            flag = 2;
        }

        private void settxt()
        {
            mtxt1.Text = dataGridViewX1.CurrentRow.Cells[0].Value.ToString();
            txt2.Text = dataGridViewX1.CurrentRow.Cells[1].Value.ToString();
            txt3.Text = dataGridViewX1.CurrentRow.Cells[2].Value.ToString();
            txt4.Text = dataGridViewX1.CurrentRow.Cells[3].Value.ToString();
            txt5.Text = dataGridViewX1.CurrentRow.Cells[4].Value.ToString();
            txt6.Text = dataGridViewX1.CurrentRow.Cells[5].Value.ToString();
            txt7.Text = dataGridViewX1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.RowCount == 0)
                return;

            if (FMessegeBox.FarsiMessegeBox.Show("آیا برای حذف مطمئن هستید؟", "", FMessegeBox.FMessegeBoxButtons.YesNo, FMessegeBox.FMessegeBoxIcons.Question) == DialogResult.No)
            {
                return;
            }
            sql = "DELETE FROM ranande WHERE (coderan = N'" + dataGridViewX1.CurrentRow.Cells[0].Value.ToString() + "')";
            con.connection();
            if (con.exe_data(sql))
            {
                dataGridViewX1.DataSource = con.show_data("select * from ranande");
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

            printer.Title = "لیست کلیه رانندگان";
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
