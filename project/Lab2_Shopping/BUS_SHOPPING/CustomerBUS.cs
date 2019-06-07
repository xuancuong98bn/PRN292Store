using DAL_SHOPPING;
using DTL_SHOPPING;
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

        public Customer Search(TextBox text)
        {
            Customer c = CustomerDAL.Search(text.Text);
            return c;
        }

        public bool Insert(string code, string name, bool gender, string dob, string address)
        {
            if (!CheckCode(code))
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
                    Customer c = new Customer(code, Normalization(name), gender, address, DOB);
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
            Customer c = new Customer(code, Normalization(name), gender, address, DOB);
            return CustomerDAL.Update(c);
        }

        public bool Delete(string code)
        {
            return CustomerDAL.Delete(code);
        }

        private static bool CheckCode(string code)
        {
            code = code.Trim();
            return Regex.IsMatch(code, @"^KH\d{2}$");
        }

        public static string Normalization(string str)
        {
            string[] subStr = Regex.Replace(str, @"\s+", " ").Trim().ToLower().Split(' ');
            return Concat(subStr, true);
        }

        public static string Concat(string[] subStr, bool upperFirst = false)
        {
            string str = "";
            for (int i = 0; i < subStr.Length; i++)
            {
                if (upperFirst)
                {
                    string s = subStr[i];
                    s = s.Substring(0, 1).ToUpper() + s.Substring(1);
                    str += s + " ";
                }
                else
                {
                    str += subStr[i] + " ";
                }
            }
            return str;
        }
    }
}
