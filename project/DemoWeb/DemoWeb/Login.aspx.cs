using Model_PROJECT;
using Model_PROJECT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
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
            User user = UserDAO.LoginVal(txtUsername.Text, txtPassword.Text);
            if ( user != null)
            {
                Session.Add("account", user.Username);
                Response.Redirect("Home.aspx");
            }
        }
    }
}