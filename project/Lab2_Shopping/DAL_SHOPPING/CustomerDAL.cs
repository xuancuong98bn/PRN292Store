using DTL_SHOPPING;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL_SHOPPING
{
    public class CustomerDAL
    {

        public List<Customer> Load()
        {
            List<Customer> list = new List<Customer>();
            DataTable dt = DataAccess.SelectTable("tblCustomer");
            foreach (DataRow item in dt.Rows)
            {
                Object[] row = item.ItemArray;
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
    }
}
