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
                int billCode = Convert.ToInt32(row[0]);
                string productCode = row[1].ToString();
                int quantity = Convert.ToInt32(row[2]);
                bool status = Convert.ToBoolean(row[3]);
                DetailBill c = new DetailBill(billCode, productCode, quantity, status);
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
                string productCode = row[1].ToString();
                int quantity = Convert.ToInt32(row[2]);
                bool status = Convert.ToBoolean(row[3]);
                DetailBill c = new DetailBill(billCode, productCode, quantity, status);
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
                int quantity = Convert.ToInt32(row[2]);
                bool status = Convert.ToBoolean(row[3]);
                c = new DetailBill(billCode, productCode, quantity, status);
            }
            return c;
        }

        public static DataTable AdvancedSearch(int billCode, int status = 0)
        {
            DataTable dt = DataAccess.ExecuteQuery
                (@"SELECT        tblCustomer.Name, tblProduct.Name AS ProductName, tblProduct.Unit, tblProduct.Price, tblDetailBill.Quantity, tblProduct.Price *tblDetailBill.Quantity Amount, tblBill.DateBuy 
                    FROM            tblBill INNER JOIN
                                                tblCustomer ON tblBill.CustomerCode = tblCustomer.Code INNER JOIN
                                                tblDetailBill ON tblBill.Code = tblDetailBill.BillCode INNER JOIN
                                                tblProduct ON tblDetailBill.ProductCode = tblProduct.Code
                    WHERE tblBill.Code = " + billCode + " AND tblDetailBill.Status = " + status);
            return dt;
        }

        public static double Total(int billCode, int status = 0)
        {
            double total = 0;
            total = (double)DataAccess.ExecuteScalarQuery
                (@"SELECT        SUM(tblProduct.Price *tblDetailBill.Quantity)
                    FROM            tblBill INNER JOIN
                                                tblCustomer ON tblBill.CustomerCode = tblCustomer.Code INNER JOIN
                                                tblDetailBill ON tblBill.Code = tblDetailBill.BillCode INNER JOIN
                                                tblProduct ON tblDetailBill.ProductCode = tblProduct.Code
                    WHERE tblBill.Code = " + billCode + " AND tblDetailBill.Status = " + status);
            return total;
        }

        public static int CountPaid(int billCode, int status = 1)
        {
            int count = 0;
            count = (int)DataAccess.ExecuteScalarQuery
                (@"SELECT        COUNT(tblDetailBill.Status)
                    FROM            tblBill INNER JOIN
                                                tblCustomer ON tblBill.CustomerCode = tblCustomer.Code INNER JOIN
                                                tblDetailBill ON tblBill.Code = tblDetailBill.BillCode INNER JOIN
                                                tblProduct ON tblDetailBill.ProductCode = tblProduct.Code
                    WHERE tblBill.Code = " + billCode + " AND tblDetailBill.Status = " + status);
            return count;
        }

        public static int Size()
        {
            return (int) DataAccess.ExecuteScalarQuery("SELECT COUNT(*) FROM tblDetailBill");
        }
        public static bool Insert(DetailBill c)
        {
            string sql = @"INSERT INTO tblDetailBill VALUES(" + c.BillCode + ", '" + c.ProductCode + "', " + c.Quantity + ","+ 0 +")";
            return DataAccess.ExecuteNonQuery(sql);
        }

        public static bool Update(DetailBill c)
        {
            string sql = @"UPDATE tblDetailBill SET Quantity = " + c.Quantity + " WHERE BillCode = " + c.BillCode + " AND ProductCode = '" + c.ProductCode + "'";
            return DataAccess.ExecuteNonQuery(sql);
        }

        public static bool Pay(int billCode, string productCode)
        {
            string sql = @"UPDATE tblDetailBill SET Status = " + 1 + " WHERE BillCode = " + billCode + " AND ProductCode = '" + productCode + "'";
            return DataAccess.ExecuteNonQuery(sql);
        }

        public static bool Delete(int BillCode, string ProductCode)
        {
            string sql = @"DELETE FROM tblDetailBill WHERE BillCode = " + BillCode + " AND ProductCode = '" + ProductCode + "'";
            return DataAccess.ExecuteNonQuery(sql);
        }
    }
}
