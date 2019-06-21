using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTL_PROJECT
{
    public class Customer
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
        public Customer()
        {

        }

        public Customer(string code, string name, bool gender, string address, DateTime dob)
        {
            this.Code = code;
            this.Name = name;
            this.Gender = gender ? "Nam" : "Nữ";
            this.Address = address;
            this.Dob = dob;
        }

        public bool IsGender() { return Gender == "Nam"; }
    }
}
