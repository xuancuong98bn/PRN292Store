using DTL_PROJECT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL_PROJECT
{
    public static class EmployeeDAL
    {
        private static string TableName = "Employee";
        public static List<Employee> Load()
        {
            List<Employee> list = new List<Employee>();
            DataTable dt = DataAccess.SelectTable(TableName);
            foreach (DataRow item in dt.Rows)
            {
                object[] row = item.ItemArray;
                int id = Convert.ToInt32(row[0]);
                string name = row[1].ToString();
                Employee p = new Employee(id, name);
                list.Add(p);
            }
            return list;
        }

        public static DataTable GetTable()
        {
            return DataAccess.SelectTable(TableName);
        }

    }
}
