using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTL_SHOPPING
{
    public class Customer
    {
        private string code;
        private string name;
        private string gender;
        private string address;
        private DateTime dob;

        public Customer()
        {

        }

        public Customer(string code, string name, bool gender, string address, DateTime dob)
        {
            this.code = code;
            this.name = name;
            this.gender = gender?"Nam":"Nữ";
            this.address = address;
            this.Dob = dob;
        }

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public bool IsGender() { return gender=="Nam"; }
        public string Address { get => address; set => address = value; }
        public DateTime Dob { get => dob; set => dob = value; }
    }
}
