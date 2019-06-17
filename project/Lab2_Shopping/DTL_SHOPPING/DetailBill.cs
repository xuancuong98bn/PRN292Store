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
        public bool Status { get; set; }

        public DetailBill()
        {

        }

        public DetailBill(int billCode, string productCode, int quantity, bool status)
        {
            BillCode = billCode;
            ProductCode = productCode;
            Quantity = quantity;
            Status = status;
        }
    }
}
