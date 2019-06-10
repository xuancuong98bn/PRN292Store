using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTL_SHOPPING
{
    public class DetailBill
    {
        public int BillCode { get; set; }
        public string ProductCode { get; set; }
        public int Quantity { get; set; }

        public DetailBill()
        {

        }

        public DetailBill(int billCode, string productCode, int quantity)
        {
            BillCode = billCode;
            ProductCode = productCode;
            Quantity = quantity;
        }
    }
}
