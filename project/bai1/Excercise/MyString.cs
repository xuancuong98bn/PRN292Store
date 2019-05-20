using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Excercise
{
    class MyString
    {
        //-Cắt bỏ những dấu cách thừa ở đầu và cuối chuỗi, ở giữa các từ trong chuỗi.
        //- Viết chữ hoa các chữ cái đầu từ và chữ thường với các chữ cái còn lại
        //trong xâu ký tự.         //Sau đó in xâu họ tên đã được chuẩn hóa.
        public MyString()
        {
            Console.WriteLine(Normalization("  nguyeN  xUaN   cUoNg   "));
        }


        public string Normalization(string str)
        {
            string[] subStr = Regex.Replace(str, @"\s+", " ").Trim().ToLower().Split(' ');
            return Concat(subStr, true);
        }

        public string Concat(string[] subStr, bool upperFirst = false)
        {
            string str = "";
            for (int  i = 0;  i < subStr.Length;  i++)
            {
                if (upperFirst)
                {
                    string s = subStr[i];
                    s = s.Substring(0,1).ToUpper() + s.Substring(1);
                    str += s+ " ";
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
