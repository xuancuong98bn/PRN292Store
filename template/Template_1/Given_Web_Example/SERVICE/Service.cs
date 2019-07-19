using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;

namespace SERVICE
{
    public static class Service
    {
        public static bool IsEmptyControl(TextBox element)
        {
            if (element.Text.Trim() == "")
            {
                //MessageBox.Show(nameElement + " không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        public static bool CheckCode(string code, string regex = @"^KH\d{2}$")
        {
            code = code.Trim();
            return Regex.IsMatch(code, regex);
        }

        public static string Normalization(string str)
        {
            string[] subStr = Regex.Replace(str, @"\s+", " ").Trim().ToLower().Split(' ');
            return Concat(subStr, true);
        }

        public static string Concat(string[] subStr, bool upperFirst = false)
        {
            string str = "";
            for (int i = 0; i < subStr.Length; i++)
            {
                if (upperFirst)
                {
                    string s = subStr[i];
                    s = s.Substring(0, 1).ToUpper() + s.Substring(1);
                    str += s + " ";
                }
                else
                {
                    str += subStr[i] + " ";
                }
            }
            return str;
        }
    }
}
