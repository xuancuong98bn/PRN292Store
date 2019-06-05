using DAL_SHOPPING;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BUS_SHOPPING
{
    public class CustomerBUS
    {
        CustomerDAL customer = new CustomerDAL();

        public void LoadGridView(DataGridView dataGrid)
        {
            dataGrid.DataSource = customer.Load();
        }
    }
}
