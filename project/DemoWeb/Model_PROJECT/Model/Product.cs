using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_PROJECT.Model
{
    public class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

        public Product()
        {

        }

        public Product(string code, string name, string unit, double price, string image)
        {
            Code = code;
            Name = name;
            Unit = unit;
            Price = price;
            Image = image;
        }
    }
}
