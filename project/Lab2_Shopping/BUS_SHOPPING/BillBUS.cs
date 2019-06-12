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
        public Bill Search(string code)
        {
            try
            {
                int Code = 0;
                Code = Convert.ToInt32(code);
                Bill c = BillDAL.Search(Code);
                return c;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool Insert(string code, string customerCode, string dateBuy)
        {
            try
            {
                int Code = Convert.ToInt32(code);
                DateTime DateBuy = Convert.ToDateTime(dateBuy);
                Bill c = new Bill(Code, customerCode, DateBuy);
                return BillDAL.Insert(c);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(TextBox billCode, TextBox ProductCode, TextBox quantity)
        {
            int BillCode = 0;
            int Quantity = 0;
            try
            {
                BillCode = Convert.ToInt32(billCode.Text);
                Quantity = Convert.ToInt32(quantity.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Số lượng không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            DetailBill c = new DetailBill(BillCode, ProductCode.Text, Quantity);
            return DetailBillDAL.Update(c);
        }

        public bool Delete(TextBox billCode, TextBox productCode)
        {
            int BillCode = Convert.ToInt32(billCode.Text);
            return DetailBillDAL.Delete(BillCode, productCode.Text);
        }
    }
}
