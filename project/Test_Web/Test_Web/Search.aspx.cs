using Model_PROJECT.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test_Web
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView2.DataSource = DummyDAO.AdvancedSearch(0,"");
                GridView2.DataBind();
                dropMaster.DataSource = DummyDAO.GetDummyMaster();
                dropMaster.DataTextField = "DummyName";
                dropMaster.DataValueField = "DummyID";
                dropMaster.DataBind();
            }
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            FillDataToGridView();
        }

        protected void dropMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDataToGridView();
        }

        protected void txtDetailName_TextChanged(object sender, EventArgs e)
        {
            FillDataToGridView();
        }

        private void FillDataToGridView()
        {
            int masterID = Convert.ToInt32(dropMaster.SelectedValue);
            GridView2.DataSource = DummyDAO.AdvancedSearch(masterID, txtDetailName.Text);
            GridView2.DataBind();
        }
    }
}