﻿using DAL_SHOPPING;
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

        public List<DetailBill> Search(TextBox text)
        {
            int code = Convert.ToInt32(text.Text);
            List<DetailBill> list = DetailBillDAL.Select(code);
            return list;
        }

        public DetailBill SearchDetail(TextBox bill, string product)
        {
            try
            {
                int billCode = Convert.ToInt32(bill.Text);
                DetailBill c = DetailBillDAL.Search(billCode, product);
                return c;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public bool Insert(string billCode, string ProductCode, string quantity)
        {
            int BillCode = 0;
            int Quantity = 0;
            int code = 0;
            try
            {
                code = DetailBillDAL.Size() + 1;
                BillCode = Convert.ToInt32(billCode);
                Quantity = Convert.ToInt32(quantity);
            }
            catch (Exception e)
            {
                MessageBox.Show("Số lượng không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            DetailBill c = new DetailBill(code, BillCode, ProductCode, Quantity);
            return DetailBillDAL.Insert(c);
        }

        public bool Update(string billCode, string ProductCode, string quantity)
        {
            int BillCode = 0;
            int Quantity = 0;
            int code = 0;
            try
            {
                BillCode = Convert.ToInt32(billCode);
                Quantity = Convert.ToInt32(quantity);
            }
            catch (Exception e)
            {
                MessageBox.Show("Số lượng không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            DetailBill c = new DetailBill(code, BillCode, ProductCode, Quantity);
            return DetailBillDAL.Update(c);
        }

        public bool Delete(string billCode, string productCode)
        {
            int BillCode = Convert.ToInt32(billCode);
            return DetailBillDAL.Delete(BillCode, productCode);
        }
    }
}
