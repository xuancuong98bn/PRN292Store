using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class Example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // moi load web, khoi tao gia tri ban dau
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string result = "";
            double a = Convert.ToDouble(TextBox2.Text);
            double b = Convert.ToDouble(TextBox3.Text);
            switch (DropDownList1.SelectedValue)
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
            TextBox1.Text = result;
        }

        private string Sum(double a, double b)
        {
            return (a + b).ToString();
        }

        private string Sub (double a, double b)
        {
            return (a - b).ToString();
        }

        private string Mul(double a, double b)
        {
            return (a * b).ToString();
        }

        private string Div(double a, double b)
        {
            if (b == 0)
            {
                return "Can't devide by zero!";
            }
            return (a / b).ToString();
        }
    }
}