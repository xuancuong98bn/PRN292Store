using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTL_PROJECT
{
    public class User
    {
        public string Username { get; set; }
        public int Password { get; set; }

        public User()
        {

        }

        public User(string username, int password)
        {
            Username = username;
            Password = password;
        }
    }
}
