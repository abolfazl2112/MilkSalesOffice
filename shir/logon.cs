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
    public partial class logon : Office2007Form
    {
        public int res = 0;
        public logon()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            /*conterol con = new conterol();
            if (!con.check_pass(this, textBoxX1.Text, textBoxX2.Text))
                return;
            */
            function.Code_markaz = textBoxX3.Text;
            res = 1;
            this.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            res = 0;
            this.Close();
        }

        private void textBoxX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                textBoxX2.Focus();
            if (e.KeyValue == 27)
                buttonX2_Click(null, null);
        }

        private void textBoxX2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                textBoxX3.Focus();
            if (e.KeyValue == 27)
                buttonX2_Click(null, null);
        }

        private void textBoxX3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                buttonX1.Focus();
            if (e.KeyValue == 27)
                buttonX2_Click(null, null);
        }
    }
}
