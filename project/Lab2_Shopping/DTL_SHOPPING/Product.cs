using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTL_SHOPPING
{
    public class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string code, string name, string unit, double price)
        {
            Code = code;
            Name = name;
            Unit = unit;
            Price = price;
        }
    }
}
