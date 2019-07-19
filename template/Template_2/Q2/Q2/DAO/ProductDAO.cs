using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Q2
{
    public static class ProductDAO
    {
        private static string TableName = "tblProduct";
        public static List<Product> Load()
        {
            List<Product> list = new List<Product>();
            DataTable dt = DataAccess.SelectTable(TableName);
            foreach (DataRow item in dt.Rows)
            {
                object[] row = item.ItemArray;
                string code = row[0].ToString();
                string name = row[1].ToString();
                string unit = row[2].ToString();
                double price = Convert.ToDouble(row[3]);
                Product c = new Product(code, name, unit, price);
                list.Add(c);
            }
            return list;
        }
        public static DataTable GetTable()
        {
            return DataAccess.SelectTable(TableName);
        }

        public static DataTable AdvancedSearch(string code, string dateForm, string dateTo)
        {
            string sql = @"SELECT        tblProduct.Code, tblProduct.Name, tblProduct.Unit, tblProduct.Price, tblDetailBill.Quantity, tblCustomer.Name AS Customer, tblBill.DateBuy
                            FROM            tblBill INNER JOIN
                                             tblCustomer ON tblBill.CustomerCode = tblCustomer.Code INNER JOIN
                                             tblDetailBill ON tblBill.Code = tblDetailBill.BillCode INNER JOIN
                                             tblProduct ON tblDetailBill.ProductCode = tblProduct.Code
                        WHERE tblProduct.Code = '" + code + "' AND tblBill.DateBuy > '" + dateForm + "' AND tblBill.DateBuy < '" + dateTo + "'";
            DataTable dt = DataAccess.ExecuteQuery(sql);
            return dt;
        }

        public static DataTable SearchByString(string field, string search)
        {
            DataTable dt = DataAccess.ExecuteQuery("SELECT * FROM " + TableName + " WHERE " + field + " LIKE '%" + search + "%'");
            return dt;
        }

        public static DataTable SearchByDouble(string field, double search)
        {
            DataTable dt = DataAccess.ExecuteQuery("SELECT * FROM " + TableName + " WHERE " + field + " = " + search);
            return dt;
        }

        public static Product Search(string code)
        {
            Product product = null;
            //code = code.Trim();
            DataTable dt = DataAccess.ExecuteQuery("SELECT * FROM " + TableName + " WHERE Code = '" + code + "'");
            if (dt.Rows.Count != 0)
            {
                object[] row = dt.Rows[0].ItemArray;
                string name = row[1].ToString();
                string unit = row[2].ToString();
                double price = Convert.ToDouble(row[3]);
                product = new Product(code, name, unit, price);
            }
            return product;
        }

        public static bool Insert(Product c)
        {
            string sql = @"INSERT INTO " + TableName + " VALUES('" + c.Code + "', '" + c.Name + "', '" + c.Unit + "', " + c.Price + ")";
            return DataAccess.ExecuteNonQuery(sql);
        }

        public static bool Update(Product c)
        {
            string sql = @"UPDATE " + TableName + " SET Name = '" + c.Name + "', Unit = '" + c.Unit + "', Price = " + c.Price + " WHERE Code = '" + c.Code + "'";
            return DataAccess.ExecuteNonQuery(sql);
        }

        public static bool Delete(Product c)
        {
            string sql = @"DELETE FROM " + TableName + " WHERE code = '" + c.Code + "'";
            return DataAccess.ExecuteNonQuery(sql);
        }
        public static bool Delete(string code)
        {
            string sql = @"DELETE FROM " + TableName + " WHERE code = '" + code + "'";
            return DataAccess.ExecuteNonQuery(sql);
        }
        public static bool IsExsist(string code)
        {
            string sql = @"SELECT * FROM " + TableName + " WHERE code = '" + code + "'";
            return DataAccess.IsExsist(sql);
        }
    }
}
