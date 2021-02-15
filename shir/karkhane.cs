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
    public partial class karkhane : Office2007Form
    {
        string sql = "", code;
        connect con = new connect();
        int flag = 0;
        

        public karkhane()
        {
            InitializeComponent();
        }

        private void karkhane_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.karkhane' table. You can move, or remove it, as needed.
            this.karkhaneTableAdapter.Fill(this.dataSet.karkhane);
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

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                mtxt1.Focus();
                return;
            }
            if (flag == 1)
            {
                sql = "INSERT INTO karkhane (codekar, name, phon, ghimat, address)" +
                    " VALUES (N'" + mtxt1.Text + "', N'" + txt2.Text + "', N'" + txt3.Text + "', N'" + txt4.Text + "', N'" + txt5.Text + "')";
            }
            else if (flag == 2)
            {
                sql = "UPDATE karkhane SET codekar = N'" + mtxt1.Text + "', name = N'" + txt2.Text + "', phon = N'" + txt3.Text + "', ghimat = N'" + txt4.Text + "', address = N'" + txt5.Text + "' " +
                   " WHERE (codekar = N'"+code+"')";
            }
            con.connection();
            if (con.exe_data(sql))
            {
                dataGridViewX1.DataSource = con.show_data("select * from karkhane");
                FMessegeBox.FarsiMessegeBox.Show("اطلاعات با موفقیت ثبت شد");
            }
            else
                FMessegeBox.FarsiMessegeBox.Show("مشکل در ذخیره اطلاعات","اخطار",FMessegeBox.FMessegeBoxButtons.Ok,FMessegeBox.FMessegeBoxIcons.Error);
            clear();
            if (flag == 2)
                key27();
            else
                mtxt1.Focus();
            con.Disconnect();
        }

        public void clear()
        {
            mtxt1.Text = txt2.Text = txt3.Text = txt4.Text = txt5.Text = "";
        }

        public void key27()
        {
            clear();
            groupPanel1.Enabled = groupPanel3.Enabled = true;
            groupPanel2.Enabled = false;
            dataGridViewX1.Focus();
        }

        private void mtxt1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 13:
                    con.connection();
                    DataTable data = con.show_data("select * from karkhane where (codekar = N'" + mtxt1.Text + "')");
                    con.Disconnect();
                    if (data.Rows.Count != 0)
                    {
                        txt2.Text = data.Rows[0].ItemArray.GetValue(1).ToString();
                        txt3.Text = data.Rows[0].ItemArray.GetValue(2).ToString();
                        txt4.Text = data.Rows[0].ItemArray.GetValue(3).ToString();
                        txt5.Text = data.Rows[0].ItemArray.GetValue(4).ToString();
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
                    btn0.Focus(); break;
                case 27:
                    key27(); break;
            }
        }

        private void dataGridViewX1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 13:
                    btn1.Focus(); break;
                case 27:
                    this.Close(); break;
            }
        }

        private void btn1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    this.Close(); break;
            }
        }

        private void buttonX1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    this.Close(); break;
            }
        }

        private void buttonX2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    this.Close(); break;
            }
        }

        private void btn2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 27:
                    this.Close(); break;
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.RowCount == 0)
            {
                return;
            }
            groupPanel2.Enabled = true;
            groupPanel1.Enabled = groupPanel3.Enabled = false;
            mtxt1.Focus();
            settxt();
            flag = 2;
        }

        private void settxt()
        {
            code = mtxt1.Text = dataGridViewX1.CurrentRow.Cells[0].Value.ToString();
            txt2.Text = dataGridViewX1.CurrentRow.Cells[1].Value.ToString();
            txt3.Text = dataGridViewX1.CurrentRow.Cells[2].Value.ToString();
            txt4.Text = dataGridViewX1.CurrentRow.Cells[3].Value.ToString();
            txt5.Text = dataGridViewX1.CurrentRow.Cells[4].Value.ToString();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.RowCount == 0)
                return;

            if (FMessegeBox.FarsiMessegeBox.Show("آیا برای حذف مطمئن هستید؟", "", FMessegeBox.FMessegeBoxButtons.YesNo, FMessegeBox.FMessegeBoxIcons.Question) == DialogResult.No)
            {
                return;
            }
            sql = "DELETE FROM karkhane WHERE (codekar = N'" + dataGridViewX1.CurrentRow.Cells[0].Value.ToString() + "')";
            con.connection();
            if (con.exe_data(sql))
            {
                dataGridViewX1.DataSource = con.show_data("select * from karkhane");
                FMessegeBox.FarsiMessegeBox.Show("اطلاعات با موفقیت ثبت شد");
            }
            else
                FMessegeBox.FarsiMessegeBox.Show("مشکل در ذخیره اطلاعات", "اخطار", FMessegeBox.FMessegeBoxButtons.Ok, FMessegeBox.FMessegeBoxIcons.Error);
            con.Disconnect();
        }

        private void buttonX3_Click_1(object sender, EventArgs e)
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

            printer.Title = "لیست کارخانه ها";
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
