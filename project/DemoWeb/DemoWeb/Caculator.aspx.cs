using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string result = "";
            try
            {
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
            } catch (Exception ex)
            {
                result = "Error!";
            }
            TextBox1.Text = result;
        }

        private string Sum(double a, double b)
        {
            return (a + b).ToString();
        }

        private string Sub(double a, double b)
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox1.Text = "";
        }
    }
}