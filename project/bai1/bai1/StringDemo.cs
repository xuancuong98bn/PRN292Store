using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class StringDemo
    {
        public StringDemo()
        {
            Console.WriteLine("Using StringDemo");
            string str = "FPT University";
            string[] astr = str.Split(" ");
            foreach (var item in astr)
            {
                Console.WriteLine(item);
            }

            string name = "Nguyen Xuan Cuong    ";
            name = name.Trim();
            string[] narr = name.Split(" ");
            string result = narr[narr.Length - 1] + " " + narr[0];
            Console.WriteLine(result);

            string user = "admin";
            string pass = "123";

            if ("admin".Equals(user.Trim()) && "123".Equals(pass))
            {
                Console.WriteLine("Login successfully!");
            }
            else
            {
                Console.WriteLine("Login Failed");
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Car");
            sb.AppendLine("Bike");
            sb.AppendLine("Plane");
            sb.AppendLine("Train");
            sb.AppendFormat("{0}", "9");
            Console.WriteLine(sb.ToString());

            int second = 123000;
            string fo = "";
            fo = (second / 60 / 60 % 24).ToString().PadLeft(2, '0') + ":" + (second / 60 % 60).ToString().PadLeft(2, '0') + ":" + (second % 60).ToString().PadLeft(2, '0');
            Console.WriteLine(fo);
        }
    }
}
