using DAO;
using DTO;
using SERVICE;
using System;
using System.Web.UI;

namespace Given_Web_Example
{
    public partial class SearchProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCode.DataSource = ProductDAO.GetTable();
                ddlCode.DataTextField = "Code";
                ddlCode.DataValueField = "Code";
                ddlCode.DataBind();
                gvProduct.DataSource = ProductDAO.GetTable();
                gvProduct.DataBind();

            }
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Success');location.href='';", true);
        }

        protected void btnFilter2_Click(object sender, EventArgs e)
        {
            gvProduct.DataSource = ProductDAO.SearchByString("Name", txtName.Text);
            gvProduct.DataBind();
        }

        protected void btnFilter0_Click(object sender, EventArgs e)
        {
            gvProduct.DataSource = ProductDAO.SearchByString("Image", txtImage.Text);
            gvProduct.DataBind();
        }

        protected void ddlCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvProduct.DataSource = ProductDAO.SearchByString("Code", ddlCode.SelectedValue.ToString());
            gvProduct.DataBind();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtImage.Text = "";
            txtName.Text = "";
            txtNew.Text = "";
            txtOld.Text = "";
            txtUnit.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!(Service.IsEmptyControl(txtName) || Service.IsEmptyControl(txtUnit) || Service.IsEmptyControl(txtNew)
                 || Service.IsEmptyControl(txtImage)))
            {
                Product p = new Product(ddlCode.SelectedValue.ToString(), txtName.Text, txtUnit.Text, Convert.ToDouble(txtNew.Text), txtImage.Text);
                if (ProductDAO.Update(p))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Success');", true);
                } else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Fail');", true);
                }
            }
            gvProduct.DataSource = ProductDAO.GetTable();
            gvProduct.DataBind();
        }
    }
}