using DTL_SHOPPING;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL_SHOPPING
{
    public static class ProductDAL
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
                double price = Convert.ToDouble(row[4]);
                Product c = new Product(code, name, unit, price);
                list.Add(c);
            }
            return list;
        }
        public static DataTable GetTable()
        {
            return DataAccess.SelectTable(TableName);
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
            string sql = @"INSERT INTO tblProduct VALUES('" + c.Code + "', '" + c.Name + "', '" + c.Unit + "', " + c.Price + ")";
            return DataAccess.ExecuteNonQuery(sql);
        }

        public static bool Update(Product c)
        {
            string sql = @"UPDATE tblProduct SET Name = '" + c.Name + "', Unit = '" + c.Unit + "', Price = " + c.Price + " WHERE code = '" + c.Code + "'";
            return DataAccess.ExecuteNonQuery(sql);
        }

        public static bool Delete(string code)
        {
            string sql = @"DELETE FROM tblProduct WHERE code = '" + code + "'";
            return DataAccess.ExecuteNonQuery(sql);
        }
    }
}
