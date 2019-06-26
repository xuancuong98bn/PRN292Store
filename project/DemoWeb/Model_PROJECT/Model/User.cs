using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model_PROJECT
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string  Name { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
        public User()
        {

        }

        public User(int id, string username, string password, string name, bool gender, string address, DateTime dob)
        {
            Id = id;
            Username = username;
            Password = password;
            Name = name;
            Gender = gender;
            Address = address;
            Dob = dob;
        }
    }
}