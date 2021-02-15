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
    public partial class forooshshir_list : Office2007Form
    {
        string sql;
        connect con;
        public forooshshir_list()
        {
            InitializeComponent();
            con = new connect();
        }

        private void forooshshir_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.foroosheshir' table. You can move, or remove it, as needed.
            this.foroosheshirTableAdapter.Fill(this.dataSet.foroosheshir);
            //btnRight.Text= FreeControls.PersianDate.Now.ToString("yyyy/MM/dd");
            btnLeft.Text = Persia.Calendar.ConvertToPersian(DateTime.Now).ToString("W");
            btnCenter.Text = "مرکز پخش شیر....";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            foroosheshir fsh = new foroosheshir();
            fsh.type = 1;
            fsh.ShowDialog(this);

            con.connection();
            dataGridViewX1.DataSource = con.show_data("select * from foroosheshir");
            con.Disconnect();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.RowCount == 0) return;
            foroosheshir fsh = new foroosheshir();
            fsh.type = 2;
            fsh.settxt(dataGridViewX1.CurrentRow);
            fsh.ShowDialog(this);

            con.connection();
            dataGridViewX1.DataSource = con.show_data("select * from foroosheshir");
            con.Disconnect();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.RowCount == 0)
                return;

            if (FMessegeBox.FarsiMessegeBox.Show("آیا برای حذف مطمئن هستید؟", "", FMessegeBox.FMessegeBoxButtons.YesNo, FMessegeBox.FMessegeBoxIcons.Question) == DialogResult.No)
            {
                return;
            }
            sql = "DELETE FROM foroosheshir WHERE (codemah = N'" + dataGridViewX1.CurrentRow.Cells[0].Value.ToString() + "')";
            con.connection();
            if (con.exe_data(sql))
            {
                dataGridViewX1.DataSource = con.show_data("select * from foroosheshir");
                FMessegeBox.FarsiMessegeBox.Show("اطلاعات با موفقیت ثبت شد");
            }
            else
                FMessegeBox.FarsiMessegeBox.Show("مشکل در ذخیره اطلاعات", "اخطار", FMessegeBox.FMessegeBoxButtons.Ok, FMessegeBox.FMessegeBoxIcons.Error);
            con.Disconnect();
        }

        private void btnRight_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 27)
                this.Close();
        }

        private void dataGridViewX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();

            if (e.KeyValue == 13)
                buttonX1_Click(null, null);
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

            printer.Title = "لیست فروش شیر";
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
