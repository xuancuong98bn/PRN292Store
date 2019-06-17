using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTL_SHOPPING
{
    public class Bill
    {
        public int Code { get; set; }
        public string CustomerCode { get; set; }
        public DateTime DateBuy { get; set; }
        public int Status { get; set; }

        public Bill()
        {

        }

        public Bill(int code, string customerCode, DateTime dateBuy, int status)
        {
            Code = code;
            CustomerCode = customerCode;
            DateBuy = dateBuy;
            Status = status;
        }
    }
}
