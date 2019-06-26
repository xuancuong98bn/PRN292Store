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
            List<User> list = new List<User>();
            DataTable dt = DataAccess.ExecuteQuery
                ("SELECT * FROM [User] WHERE username='" + username + "' AND password='" + password + "'");
            User user = null;
            if (dt.Rows.Count != 0)
            {
                object[] row = dt.Rows[0].ItemArray;
                int Id = Convert.ToInt32(row[0]);
                string Username = row[1].ToString();
                string Password = row[2].ToString();
                string Name = row[3].ToString();
                bool Gender = Convert.ToBoolean(row[4]);
                string Address = row[5].ToString();
                DateTime Dob = Convert.ToDateTime(row[6]);
                user = new User(Id, Username, Password, Name, Gender, Address, Dob);
            }
            return user;
        }
    }
}
