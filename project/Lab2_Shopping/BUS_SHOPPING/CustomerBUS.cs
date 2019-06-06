using DAL_SHOPPING;
using DTL_SHOPPING;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BUS_SHOPPING
{
    public class CustomerBUS
    {

        public void LoadGridView(DataGridView dataGrid)
        {
            DataTable data = CustomerDAL.GetTable();
            dataGrid.DataSource = data;
        }

        public Customer GetFirstCustomer(DataGridView dataGrid)
        {
            Customer c = null;
            if (dataGrid.Rows.Count > 0)
            {
                string code = dataGrid.Rows[0].Cells["Code"].Value.ToString();
                c = CustomerDAL.Search(code);
            }
            return c;
        }
    }
}
