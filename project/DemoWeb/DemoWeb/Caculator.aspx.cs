using SERVICE;
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

        demoService sv = new demoService();
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //TextBox1.Text = CalculateSV.Calculate(TextBox2.Text, TextBox3.Text, DropDownList1.SelectedValue);
            TextBox1.Text = sv.Calculate(TextBox2.Text, TextBox3.Text, DropDownList1.SelectedValue);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox1.Text = "";
        }
    }
}