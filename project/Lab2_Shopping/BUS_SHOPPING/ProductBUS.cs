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
    public class ProductBUS
    {
        public void LoadGridView(DataGridView dataGrid)
        {
            DataTable data = ProductDAL.GetTable();
            dataGrid.DataSource = data;
        }

        public void LoadComboBox(ComboBox comboBox)
        {
            DataTable data = ProductDAL.GetTable();
            comboBox.DataSource = data;
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Code";
        }

        public void LoadComboBoxStyle2(ComboBox comboBox)
        {
            DataTable data = ProductDAL.GetTable();
            comboBox.DataSource = data;
            comboBox.DisplayMember = "Code";
            comboBox.ValueMember = "Code";
        }

        public Product GetFirstProduct(DataGridView dataGrid)
        {
            Product p = null;
            if (dataGrid.Rows.Count > 0)
            {
                string code = dataGrid.Rows[0].Cells["Code"].Value.ToString();
                p = ProductDAL.Search(code);
            }
            return p;
        }

        public Product Search(string code)
        {
            Product p = ProductDAL.Search(code);
            return p;
        }

        public DataTable AdvanceSearch(string code, string dateForm, string dateTo)
        {
            try
            {
                DateTime DateFrom = Convert.ToDateTime(dateForm);
                DateTime DateTo = Convert.ToDateTime(dateTo);
                return ProductDAL.AdvancedSearch(code, dateForm, dateTo);
            }
            catch (Exception e)
            {
                MessageBox.Show("Sai định dạng thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return new DataTable();
            }
        }

        public bool Insert(string code, string name, string unit, string price)
        {
            if (!Service.CheckCode(code, @"^[a-zA-Z]\d{2}$"))
            {
                MessageBox.Show("Mã sản phẩm sai định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double Price = 0;
                try
                {
                    Price = Convert.ToDouble(price);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Giá không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (ProductDAL.Search(code) == null)
                {
                    Product c = new Product(code, Service.Normalization(name), unit, Price);
                    return ProductDAL.Insert(c);
                }
                else
                {
                    MessageBox.Show("Mã sản phẩm bị trùng lặp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return false;
        }

        public bool Update(string code, string name, string unit, string price)
        {
            double Price = 0;
            try
            {
                Price = Convert.ToDouble(price);
                if (Price <= 0)
                {
                    throw new Exception(); 
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Giá không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Product c = new Product(code, Service.Normalization(name), unit, Price);
            return ProductDAL.Update(c);
        }

        public bool Delete(string code)
        {
            return ProductDAL.Delete(code);
        }
    }
}
