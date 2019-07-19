using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_PROJECT.DAO
{
    public static class UserDAO
    {
        public static User LoginVal(string username, string password)
        {
            DataTable dt = DataAccess.ExecuteQuery
                ("SELECT * FROM tblUser WHERE username='" + username + "' AND password=" + password);
            User user = null;
            if (dt.Rows.Count != 0)
            {
                object[] row = dt.Rows[0].ItemArray;
                string Username = row[0].ToString();
                int Password = Convert.ToInt32(row[1]);
                user = new User(Username, Password);
            }
            return user;
        }
    }
}
