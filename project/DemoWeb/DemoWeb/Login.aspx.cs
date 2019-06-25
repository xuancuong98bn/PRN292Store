using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if ("admin".Equals(txtUsername.Text) && "admin".Equals(txtPassword.Text))
            {
                Session.Add("account", "admin");
                Response.Redirect("Home.aspx");
            }
        }
    }
}