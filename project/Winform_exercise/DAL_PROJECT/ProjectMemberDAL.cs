using DTL_PROJECT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL_PROJECT
{
    public static class ProjectMemberDAL
    {
        private static string TableName = "ProjectMember";
        public static List<ProjectMember> Load()
        {
            List<ProjectMember> list = new List<ProjectMember>();
            DataTable dt = DataAccess.SelectTable(TableName);
            foreach (DataRow item in dt.Rows)
            {
                object[] row = item.ItemArray;
                int employeeId = Convert.ToInt32(row[0]);
                int projectId = Convert.ToInt32(row[1]);
                string position = row[2].ToString();
                bool isFulltime = Convert.ToBoolean(row[3]);
                DateTime date = (DateTime)row[4];
                ProjectMember c = new ProjectMember(employeeId, projectId, position, isFulltime, date);
                list.Add(c);
            }
            return list;
        }

        public static DataTable GetTable()
        {
            return DataAccess.SelectTable(TableName);
        }

        public static bool IsDupplicate(int employeeId, int projectId)
        {
            return DataAccess.IsDupplicate("SELECT * FROM ProjectMember WHERE employeeId = "+ employeeId + " AND projectId = "+ projectId );
        }


        public static bool Insert(ProjectMember c)
        {
            string sql = @"INSERT INTO ProjectMember VALUES(" + c.EmployeeID + ", " + c.ProjectID + ", '" + c.Position + "', " + (c.IsFulltime?1:0) + ", '" + c.Date + "')";
            return DataAccess.ExecuteNonQuery(sql);
        }

        //public static bool Update(ProjectMember c)
        //{
        //    string sql = @"UPDATE tblCustomer SET Name = '" + c.Name + "', Gender = " + (c.IsGender()? 1 : 0) + ", Address = '" + c.Address + "', DOB = '" + c.Dob + "' WHERE code = '" + c.Code + "'";
        //    return DataAccess.ExecuteNonQuery(sql);
        //}

        //public static bool Delete(string code)
        //{
        //    string sql = @"DELETE FROM tblCustomer WHERE code = '" + code + "'";
        //    return DataAccess.ExecuteNonQuery(sql);
        //}
    }
}
