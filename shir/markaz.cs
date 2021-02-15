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
    public partial class markaz : Office2007Form
    {
        int flag = 0;
        string sql = "";
        connect con = new connect();

        public markaz()
        {
            InitializeComponent();
        }

        private void markaz_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.markaz' table. You can move, or remove it, as needed.
            this.markazTableAdapter.Fill(this.dataSet.markaz);
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

        private void mtxt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                con.connection();
                DataTable dt = con.show_data("select * from markaz where (codemar = N'" + mtxt1.Text + "') ");
                con.Disconnect();
                if (dt.Rows.Count != 0)
                {
                    txt2.Text = dt.Rows[0].ItemArray.GetValue(1).ToString();
                    flag = 2;
                }
                txt2.Focus();
            }

            if (e.KeyValue == 27)
            {
                groupPanel1.Enabled = groupPanel3.Enabled = true;
                groupPanel2.Enabled = false;
                btn1.Focus();
            }
        }

        private void txt2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                groupPanel1.Enabled = groupPanel3.Enabled = true;
                groupPanel2.Enabled = false;
                btn1.Focus();
            }

            if (e.KeyValue == 13)
                btn0.Focus();
        }

        private void btn0_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                groupPanel1.Enabled = groupPanel3.Enabled = true;
                groupPanel2.Enabled = false;
                btn1.Focus();
            }  
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                return;
            }
            if (flag == 1)
            {
                sql = "INSERT INTO markaz(codemar, name)VALUES(N'" + mtxt1.Text + "', N'" + txt2.Text + "')";
            }
            else if (flag == 2)
            {
                sql = "UPDATE markaz SET codemar = N'" + mtxt1.Text + "', name = N'" + txt2.Text + "' WHERE(codemar = N'" + dataGridViewX1.CurrentRow.Cells[0].Value.ToString() + "')";
            }
            con.connection();
            if (con.exe_data(sql))
            {
                dataGridViewX1.DataSource = con.show_data("select * from markaz");
                FMessegeBox.FarsiMessegeBox.Show("اطلاعات با موفقیت ثبت شد");
            }
            else
                FMessegeBox.FarsiMessegeBox.Show("مشکل در ذخیره اطلاعات", "اخطار", FMessegeBox.FMessegeBoxButtons.Ok, FMessegeBox.FMessegeBoxIcons.Error);
            
            
            con.Disconnect();
            mtxt1.Text = txt2.Text = "";
            if (flag == 2)
            {
                groupPanel1.Enabled = groupPanel3.Enabled = true;
                groupPanel2.Enabled = false;
                dataGridViewX1.Focus();
            }
            else
                mtxt1.Focus();
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.RowCount == 0)
            {
                FMessegeBox.FarsiMessegeBox.Show("لطفا یک مورد را انتخاب کنید");
            }
            groupPanel2.Enabled = true;
            groupPanel1.Enabled = groupPanel3.Enabled = false;
            mtxt1.Focus();
            settxt();
            flag = 2;
        }

        private void settxt()
        {
            mtxt1.Text = dataGridViewX1.CurrentRow.Cells[0].Value.ToString();
            txt2.Text = dataGridViewX1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.RowCount == 0)
                return;

            if (FMessegeBox.FarsiMessegeBox.Show("آیا برای حذف مطمئن هستید؟", "", FMessegeBox.FMessegeBoxButtons.YesNo, FMessegeBox.FMessegeBoxIcons.Question) == DialogResult.No)
            {
                return;
            }
            sql = "DELETE FROM markaz WHERE (codemar = N'" + dataGridViewX1.CurrentRow.Cells[0].Value.ToString() + "')";
            con.connection();
            if (con.exe_data(sql))
            {
                dataGridViewX1.DataSource = con.show_data("select * from markaz");
                FMessegeBox.FarsiMessegeBox.Show("اطلاعات با موفقیت ثبت شد");
            }
            else
                FMessegeBox.FarsiMessegeBox.Show("مشکل در ذخیره اطلاعات", "اخطار", FMessegeBox.FMessegeBoxButtons.Ok, FMessegeBox.FMessegeBoxIcons.Error);
            con.Disconnect();
        }

        private void dataGridViewX1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                btn2_Click(null,null);
            }
            else if(e.KeyValue==27)
            {
                this.Close();
            }
        }

        private void btn1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==27)
            {
                this.Close();
            }
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

            printer.Title = "لیست مراکز تحویل شیر";
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
