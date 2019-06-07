using DTL_SHOPPING;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL_SHOPPING
{
    public static class CustomerDAL
    {
        private static string TableName = "tblCustomer";
        public static List<Customer> Load()
        {
            List<Customer> list = new List<Customer>();
            DataTable dt = DataAccess.SelectTable(TableName);
            foreach (DataRow item in dt.Rows)
            {
                object[] row = item.ItemArray;
                string code = row[0].ToString();
                string name = row[1].ToString();
                bool gender = Convert.ToBoolean(row[2]);
                string address = row[3].ToString();
                DateTime dob = (DateTime)row[4];
                Customer c = new Customer(code, name, gender, address, dob);
                list.Add(c);
            }
            return list;
        }

        public static DataTable GetTable()
        {
            return DataAccess.SelectTable("tblCustomer");
        }

        public static Customer Search(string code)
        {
            Customer customer = null;
            //code = code.Trim();
            DataTable dt = DataAccess.ExecuteQuery("SELECT * FROM " + TableName + " WHERE Code = '" + code + "'");
            if (dt.Rows.Count != 0)
            {
                object[] row = dt.Rows[0].ItemArray;
                string name = row[1].ToString();
                bool gender = Convert.ToBoolean(row[2]);
                string address = row[3].ToString();
                DateTime DOB = Convert.ToDateTime(row[4]);
                customer = new Customer(code, name, gender, address, DOB);
            }
            return customer;
        }

        public static bool Insert(Customer c)
        {
            string sql = @"INSERT INTO tblCustomer VALUES('" + c.Code + "', '" + c.Name + "', " + (c.Gender?1:0) + ", '" + c.Address + "', '" + c.Dob + "')";
            return DataAccess.ExecuteNonQuery(sql);
        }

        public static bool Update(Customer c)
        {
            string sql = @"UPDATE tblCustomer SET Name = '" + c.Name + "', Gender = " + (c.Gender ? 1 : 0) + ", Address = '" + c.Address + "', DOB = '" + c.Dob + "' WHERE code = '" + c.Code + "'";
            return DataAccess.ExecuteNonQuery(sql);
        }

        public static bool Delete(string code)
        {
            string sql = @"DELETE FROM tblCustomer WHERE code = '" + code + "'";
            return DataAccess.ExecuteNonQuery(sql);
        }
    }
}
