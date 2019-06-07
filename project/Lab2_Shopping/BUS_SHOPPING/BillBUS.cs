using DAL_SHOPPING;
using DTL_SHOPPING;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BUS_SHOPPING
{
    public class BillBUS
    {
        public Bill Search(TextBox text)
        {
            try
            {
                int code = 0;
                code = Convert.ToInt32(text.Text);
                Bill c = BillDAL.Search(code);
                return c;
            }
            catch (Exception e)
            {
                return null;
            }

        }
    }
}
