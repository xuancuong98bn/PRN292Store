﻿using DTL_SHOPPING;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL_SHOPPING
{
    public static class BillDAL
    {
        private static string TableName = "tblBill";
        public static List<Bill> Load()
        {
            List<Bill> list = new List<Bill>();
            DataTable dt = DataAccess.SelectTable(TableName);
            foreach (DataRow item in dt.Rows)
            {
                object[] row = item.ItemArray;
                int code = Convert.ToInt32(row[0]);
                string customerCode = row[1].ToString();
                DateTime dateBuy = Convert.ToDateTime(row[2]);
                int status = Convert.ToInt32(row[3]);
                Bill c = new Bill(code, customerCode, dateBuy, status);
                list.Add(c);
            }
            return list;
        }
        public static DataTable GetTable()
        {
            return DataAccess.SelectTable(TableName);
        }

        public static Bill Search(int code, string customerCode)
        {
            Bill c = null;
            //code = code.Trim();
            DataTable dt = DataAccess.ExecuteQuery("SELECT * FROM " + TableName + " WHERE Code = " + code + " AND CustomerCode = '" + customerCode + "'");
            if (dt.Rows.Count != 0)
            {
                object[] row = dt.Rows[0].ItemArray;
                DateTime dateBuy = Convert.ToDateTime(row[2]);
                int status = Convert.ToInt32(row[3]);
                c = new Bill(code, customerCode, dateBuy, status);
            }
            return c;
        }

        public static bool Insert(Bill c)
        {
            string sql = @"INSERT INTO tblBill VALUES(" + c.Code + ",'" + c.CustomerCode + "', '" + c.DateBuy + "'," + 0 + ")";
            return DataAccess.ExecuteNonQuery(sql);
        }

        public static bool Update(Bill c)
        {
            string sql = @"UPDATE tblBill SET CustomerCode = '" + c.CustomerCode + "', DateBuy = '" + c.DateBuy + "' WHERE code = " + c.Code;
            return DataAccess.ExecuteNonQuery(sql);
        }

        public static bool ChangeStatus(int status, int code)
        {
            string sql = @"UPDATE tblBill SET Status = " + status + ", WHERE code = " + code;
            return DataAccess.ExecuteNonQuery(sql);
        }

        public static bool Delete(int code)
        {
            string sql = @"DELETE FROM tblBill WHERE Code = " + code;
            return DataAccess.ExecuteNonQuery(sql);
        }
    }
}
