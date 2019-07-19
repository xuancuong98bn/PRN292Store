using BUS_PROJECT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb.product
{
    
    public partial class Create : System.Web.UI.Page
    {
        ProductBUS product = new ProductBUS();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            lblStatus.Text = product.Insert(txtCode.Text, txtName.Text, dropUnit.SelectedValue, txtPrice.Text, txtLinkImage.Text);
        }
    }
}