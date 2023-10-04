using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaSchool
{
    public static class Helper
    {
        public static bool IsFilled(Control[] controls)
        {
            var res = true;

            foreach (var control in controls)
            {
                if (control is TextBox)
                {
                    if (String.IsNullOrWhiteSpace(control.Text))
                    {
                        res = false;
                    }
                }
                else if (control is ComboBox)
                {
                    
                }
            }
            return res;
        }

        public static void Clear(Control[] controls)
        {
            foreach (var control in controls)
            {
                control.Text = "";
            }
        }

        public static bool IsValidEmail(string email)
        {
            Regex regex = new Regex(@"@");
            return regex.IsMatch(email);
        }
    }
}
