using DAL_SHOPPING;
using DTL_SHOPPING;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BUS_SHOPPING
{
    public class DetailBillBUS
    {
        public void LoadGridView(DataGridView dataGrid)
        {
            DataTable data = DetailBillDAL.GetTable();
            dataGrid.DataSource = data;
        }

        public List<DetailBill> Search(string text)
        {

            List<DetailBill> list = new List<DetailBill>();
            try
            {
                int code = Convert.ToInt32(text);
                list = DetailBillDAL.Select(code);
            }
            catch (Exception ex)
            {
                //do nothing
            }
            return list;
        }

        public DataTable AdvancedSearch(string text)
        {
            try
            {
                int code = Convert.ToInt32(text);
                return DetailBillDAL.AdvancedSearch(code);
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }

        public double Total(string billCode)
        {
            try
            {
                int code = Convert.ToInt32(billCode);
                return DetailBillDAL.Total(code);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int CountPaid(string billCode, int status = 1)
        {
            try
            {
                int code = Convert.ToInt32(billCode);
                return DetailBillDAL.CountPaid(code, status);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public DetailBill SearchDetail(string bill, string product)
        {
            try
            {
                int billCode = Convert.ToInt32(bill);
                DetailBill c = DetailBillDAL.Search(billCode, product);
                return c;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public bool Pay(string billCode, string productCode)
        {
            int BillCode = 0;
            try
            {
                BillCode = Convert.ToInt32(billCode);
                return DetailBillDAL.Pay(BillCode, productCode);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Insert(string billCode, string ProductCode, string quantity)
        {
            int BillCode = 0;
            int Quantity = 0;
            try
            {
                BillCode = Convert.ToInt32(billCode);
                Quantity = Convert.ToInt32(quantity);
                if (Quantity <= 0) throw new Exception();
            }
            catch (Exception e)
            {
                MessageBox.Show("Số lượng không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            DetailBill c = new DetailBill(BillCode, ProductCode, Quantity, false);
            return DetailBillDAL.Insert(c);
        }

        public bool Update(string billCode, string ProductCode, string quantity, int oldQuantity, bool more)
        {
            int BillCode = 0;
            int Quantity = oldQuantity;
            try
            {
                BillCode = Convert.ToInt32(billCode);
                int newQuantity = Convert.ToInt32(quantity);
                if (newQuantity <= 0) throw new Exception();
                Quantity += more ? newQuantity : -newQuantity;
            }
            catch (Exception e)
            {
                MessageBox.Show("Số lượng không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            DetailBill c = new DetailBill(BillCode, ProductCode, Quantity, false);
            return DetailBillDAL.Update(c);
        }

        public bool Delete(string billCode, string productCode)
        {
            int BillCode = Convert.ToInt32(billCode);
            return DetailBillDAL.Delete(BillCode, productCode);
        }
    }
}
