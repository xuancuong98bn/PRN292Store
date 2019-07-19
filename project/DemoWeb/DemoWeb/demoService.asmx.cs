using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DemoWeb
{
    /// <summary>
    /// Summary description for demoService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class demoService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string Calculate(string aa, string bb, string opera)
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

        public string Sum(double a, double b)
        {
            return (a + b).ToString();
        }

        public string Sub(double a, double b)
        {
            return (a - b).ToString();
        }

        public string Mul(double a, double b)
        {
            return (a * b).ToString();
        }

        public string Div(double a, double b)
        {
            if (b == 0)
            {
                return "Can't devide by zero!";
            }
            return (a / b).ToString();
        }
    }
}
