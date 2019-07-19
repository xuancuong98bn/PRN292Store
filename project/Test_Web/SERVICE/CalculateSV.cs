using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SERVICE
{
    public static class CalculateSV
    {
        public static string Calculate(string aa, string bb, string opera)
        {
            string result = "";
            try
            {
                double a = Convert.ToDouble(aa);
                double b = Convert.ToDouble(bb);
                switch (opera)
                {
                    case "+":
                        result = Sum(a, b);
                        break;
                    case "-":
                        result = Sub(a, b);
                        break;
                    case "*":
                        result = Mul(a, b);
                        break;
                    case "/":
                        result = Div(a, b);
                        break;
                }
            }
            catch (Exception ex)
            {
                result = "Error!";
            }
            return result;
        }

        public static string Sum(double a, double b)
        {
            return (a + b).ToString();
        }

        public static string Sub(double a, double b)
        {
            return (a - b).ToString();
        }

        public static string Mul(double a, double b)
        {
            return (a * b).ToString();
        }

        public static string Div(double a, double b)
        {
            if (b == 0)
            {
                return "Can't devide by zero!";
            }
            return (a / b).ToString();
        }
    }
}
