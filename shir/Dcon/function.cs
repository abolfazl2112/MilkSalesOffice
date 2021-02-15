using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace system
{
    class function
    {
        static public string Code_user = "", Name_user = "", pass_user = "", Code_markaz = "";
        static public bool Is_In_month(string date, string month)
        {
            switch(month)
            {
                case "فروردین":  month = "01"; break;
                case "اردیبهشت": month = "02"; break;
                case "خرداد":    month = "03"; break;
                case "تیر":      month = "04"; break;
                case "مرداد":    month = "05"; break;
                case "شهریور":   month = "06"; break;
                case "مهر":      month = "07"; break;
                case "آبان":     month = "08"; break;
                case "آذر":      month = "09"; break;
                case "دی":       month = "10"; break;
                case "بهمن":     month = "11"; break;
                case "اسفند":    month = "12"; break;
                default: return false;
            }
            if (date.Substring(5, 2) == month) return true;
            return false;
        }
        
    }
}
