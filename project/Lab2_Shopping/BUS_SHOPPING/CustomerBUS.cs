using DAL_SHOPPING;
using DTL_SHOPPING;
using SERVICE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BUS_SHOPPING
{
    public class CustomerBUS
    {

        public void LoadGridView(DataGridView dataGrid)
        {
            var data = CustomerDAL.GetTable();
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

        public Customer Search(string code)
        {
            Customer c = CustomerDAL.Search(code);
            return c;
        }

        public bool Insert(string code, string name, bool gender, string dob, string address)
        {
            if (!Service.CheckCode(code))
            {
                MessageBox.Show("Mã khách hàng sai định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime DOB;
                try
                {
                    DOB = Convert.ToDateTime(dob);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ngày sinh sai định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (CustomerDAL.Search(code) == null)
                {
                    Customer c = new Customer(code, Service.Normalization(name), gender, address, DOB);
                    return CustomerDAL.Insert(c);
                }
                else
                {
                    MessageBox.Show("Mã khách hàng bị trùng lặp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return false;
        }

        public bool Update(string code, string name, bool gender, string dob, string address)
        {
            DateTime DOB;
            try
            {
                DOB = Convert.ToDateTime(dob);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ngày sinh sai định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Customer c = new Customer(code, Service.Normalization(name), gender, address, DOB);
            return CustomerDAL.Update(c);
        }

        public bool Delete(string code)
        {
            return CustomerDAL.Delete(code);
        }
    }
}
