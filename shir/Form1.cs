using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;
using Microsoft.Win32;

namespace system
{
    public partial class Form1 : Office2007Form
    {
        
        public Form1()
        {
            InitializeComponent();
            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.VistaGlass);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        this.Opacity = 0.80;
            logon log = new logon();
            log.ShowDialog(this);
            if (log.res == 0)
            {
                this.Close();
                return;
            }
            this.Opacity = 1;
            if (!ISREG())
            {
                FMessegeBox.FarsiMessegeBox.Show("در صورت تمایل به خرید نسخه اصلی با شماره ذیل تماس حاصل فرمایید.09158362782 - شهراد");
                Application.Exit();
            }

        }

        RegistryKey regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\mnsh", false);
        private bool ISREG()
        {
            if (regKey == null)
            {
                active();
            }
            try
            {
                int regKeyReg = int.Parse(regKey.GetValue("mns").ToString());
                if (regKeyReg < 100)
                {
                    RegistryKey regp = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\mnsh", true);
                    regp.SetValue("mns", (regKeyReg+1).ToString());

                    return true;
                }
                else
                    return false;
            }
            catch { return false; }
        }

        void active()
        {
            RegistryKey reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE", true);
            reg.CreateSubKey("mnsh");
            reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\mnsh", true);
            reg.SetValue("mns", "0");
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonItem4_MouseHover(object sender, EventArgs e)
        {
            buttonItem4.Expanded = true;
        }

        private void buttonItem8_Click_1(object sender, EventArgs e)
        {
            new sghabz().ShowDialog(this);
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            new tahvileshir_list().ShowDialog(this);
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            new vshir_list().ShowDialog(this);
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            new moshtari().ShowDialog(this);
        }

        private void buttonItem19_Click(object sender, EventArgs e)
        {
            new markaz().ShowDialog(this);
        }

        private void buttonItem30_Click(object sender, EventArgs e)
        {
            new ranande().ShowDialog(this);
        }

        private void buttonItem32_Click(object sender, EventArgs e)
        {
            new karkhane().ShowDialog(this);
        }

        private void buttonItem33_Click(object sender, EventArgs e)
        {
            new forooshshir_list().ShowDialog(this);
        }

        private void buttonItem34_Click(object sender, EventArgs e)
        {
            new analizekarkhane_list().ShowDialog(this);
        }

        private void buttonItem35_Click(object sender, EventArgs e)
        {
            new gharardad_list().ShowDialog(this);
        }

        private void buttonItem36_Click(object sender, EventArgs e)
        {
            new analizeshir_list().ShowDialog(this);
        }

        private void button82_MouseHover(object sender, EventArgs e)
        {
            button82.Expanded = true;
        }

        private void buttonItem81_Click(object sender, EventArgs e)
        {
            new moshtari().ShowDialog(this);
        }

        private void buttonItem82_Click(object sender, EventArgs e)
        {
            new ranande().ShowDialog(this);
        }

        private void buttonItem12_MouseHover(object sender, EventArgs e)
        {
            buttonItem12.Expanded = true;

        }

        private void buttonItem41_MouseHover(object sender, EventArgs e)
        {
            buttonItem41.Expanded = true;

        }

        private void buttonItem22_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem13_Click(object sender, EventArgs e)
        {
            new g_morajee_bimar().ShowDialog(this);
        }

        private void buttonItem24_Click(object sender, EventArgs e)
        {
            new g_morajeen_modatdar().ShowDialog(this);
        }
    }
}