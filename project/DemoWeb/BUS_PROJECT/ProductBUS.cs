using Model_PROJECT.DAO;
using Model_PROJECT.Model;
using SERVICE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_PROJECT
{
    public class ProductBUS
    {

        //public Product GetFirstProduct(DataGridView dataGrid)
        //{
        //    Product p = null;
        //    if (dataGrid.Rows.Count > 0)
        //    {
        //        string code = dataGrid.Rows[0].Cells["Code"].Value.ToString();
        //        p = ProductDAL.Search(code);
        //    }
        //    return p;
        //}

        //public Product Search(string code)
        //{
        //    Product p = ProductDAL.Search(code);
        //    return p;
        //}

        //public DataTable AdvanceSearch(string code, string dateForm, string dateTo)
        //{
        //    try
        //    {
        //        DateTime DateFrom = Convert.ToDateTime(dateForm);
        //        DateTime DateTo = Convert.ToDateTime(dateTo);
        //        return ProductDAL.AdvancedSearch(code, dateForm, dateTo);
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Sai định dạng thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return new DataTable();
        //    }
        //}

        public string Insert(string code, string name, string unit, string price,string image)
        {
            if (!Service.CheckCode(code, @"^[a-zA-Z]\d{2}$"))
            {
                return "Mã sản phẩm sai định dạng";
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
                    return "Giá không đúng định dạng";
                }
                if (ProductDAO.Search(code) == null)
                {
                    Product c = new Product(code, Service.Normalization(name), unit, Price, image);
                    ProductDAO.Insert(c);
                    return "Thêm sản phẩm thành công";
                }
                else
                {
                    return "Mã sản phẩm bị trùng lặp";
                }
            }
        }

        //public bool Update(string code, string name, string unit, string price)
        //{
        //    double Price = 0;
        //    try
        //    {
        //        Price = Convert.ToDouble(price);
        //        if (Price <= 0)
        //        {
        //            throw new Exception();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Giá không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }
        //    Product c = new Product(code, Service.Normalization(name), unit, Price);
        //    return ProductDAL.Update(c);
        //}

        //public bool Delete(string code)
        //{
        //    return ProductDAL.Delete(code);
        //}
    }
}
