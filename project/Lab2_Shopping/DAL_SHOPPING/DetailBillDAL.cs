using DTL_SHOPPING;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL_SHOPPING
{
    public static class DetailBillDAL
    {
        private static string TableName = "tblDetailBill";
        public static List<DetailBill> Load()
        {
            List<DetailBill> list = new List<DetailBill>();
            DataTable dt = DataAccess.SelectTable(TableName);
            foreach (DataRow item in dt.Rows)
            {
                object[] row = item.ItemArray;
                int code = Convert.ToInt32(row[0]);
                int billCode = Convert.ToInt32(row[1]);
                string productCode = row[2].ToString();
                int quantity = Convert.ToInt32(row[3]);
                DetailBill c = new DetailBill(code, billCode, productCode, quantity);
                list.Add(c);
            }
            return list;
        }
        public static DataTable GetTable()
        {
            return DataAccess.SelectTable(TableName);
        }

        public static List<DetailBill> Select(int billCode)
        {
            List<DetailBill> list = new List<DetailBill>();
            DataTable dt = DataAccess.ExecuteQuery("SELECT * FROM " + TableName + " WHERE BillCode = " + billCode);
            foreach (DataRow item in dt.Rows)
            {
                object[] row = item.ItemArray;
                int code = Convert.ToInt32(row[0]);
                string productCode = row[2].ToString();
                int quantity = Convert.ToInt32(row[3]);
                DetailBill c = new DetailBill(code, billCode, productCode, quantity);
                list.Add(c);
            }
            return list;
        }
        public static DetailBill Search(int billCode, string productCode)
        {
            DetailBill c = null;
            //code = code.Trim();
            DataTable dt = DataAccess.ExecuteQuery("SELECT * FROM " + TableName + " WHERE BillCode = " + billCode + " AND ProductCode = '"+ productCode + "'");
            if (dt.Rows.Count != 0)
            {
                object[] row = dt.Rows[0].ItemArray;
                int code = Convert.ToInt32(row[0]);
                int quantity = Convert.ToInt32(row[3]);
                c = new DetailBill(code, billCode, productCode, quantity);
            }
            return c;
        }

        public static int Size()
        {
            return (int) DataAccess.ExecuteScalarQuery("SELECT COUNT(*) FROM tblDetailBill");
        }
        public static bool Insert(DetailBill c)
        {
            string sql = @"INSERT INTO tblDetailBill VALUES(" + c.Code + ", " + c.BillCode + ", '" + c.ProductCode + "', " + c.Quantity + ")";
            return DataAccess.ExecuteNonQuery(sql);
        }

        public static bool Update(DetailBill c)
        {
            string sql = @"UPDATE tblDetailBill SET Quantity = " + c.Quantity + " WHERE BillCode = " + c.BillCode + " AND ProductCode = '" + c.ProductCode + "'";
            return DataAccess.ExecuteNonQuery(sql);
        }

        public static bool Delete(int BillCode, string ProductCode)
        {
            string sql = @"DELETE FROM tblDetailBill WHERE BillCode = " + BillCode + " AND ProductCode = '" + ProductCode + "'";
            return DataAccess.ExecuteNonQuery(sql);
        }
    }
}
