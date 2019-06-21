using DTL_PROJECT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL_SHOPPING
{
    public static class UserDAL
    {
        public static User Login(string username, string password)
        {
            List<User> list = new List<User>();
            DataTable dt = DataAccess.ExecuteQuery
                ("SELECT * FROM tblUser WHERE Username='" + username + "' AND Password='" + password + "'");
            User user = null;
            if (dt.Rows.Count != 0)
            {
                object[] row = dt.Rows[0].ItemArray;
                user = new User(row[0].ToString(), Convert.ToInt32(row[1]));
            }
            return user;
        }

    }
}
