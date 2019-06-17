using BUS_SHOPPING;
using DTL_SHOPPING;
using SERVICE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab2_Shopping
{
    public partial class PayManage : Form
    {
        ProductBUS product = new ProductBUS();
        CustomerBUS customer = new CustomerBUS();
        BillBUS bill = new BillBUS();
        DetailBillBUS detailBill = new DetailBillBUS();
        public PayManage()
        {
            InitializeComponent();
        }

        public TextBox getTxtCustomerCode()
        {
            return txtCustomerCode;
        }

        public TextBox getTxtBillCode()
        {
            return txtBillCode;
        }

        private void BillManage_Load(object sender, EventArgs e)
        {
            product.LoadComboBox(comProductName);
            FillPrice();
        }

        private void btnPayAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thanh toán toàn bộ hóa đơn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                detailBill.PayAll(txtBillCode.Text);
            }
            dataGridBill.DataSource = detailBill.AdvancedSearch(txtBillCode.Text, false);
            btnPayAll.Enabled = false;
            DisplayDataToField();
        }

        private void FillPrice()
        {
            Product p = product.Search(comProductName.SelectedValue.ToString());
            if (p != null)
            {
                txtPrice.Text = p.Price.ToString();
            }
        }

        private void txtCustomerCode_TextChanged(object sender, EventArgs e)
        {
            Customer c = customer.Search(txtCustomerCode.Text);
            if (c != null)
            {
                txtCustomerName.Text = c.Name;
                txtAddress.Text = c.Address;
            }
            else
            {
                txtCustomerName.Text = "";
                txtAddress.Text = "";
            }
        }

        private void comProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPrice();
        }

        private void btnPayAProduct_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thanh toán mặt hàng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                detailBill.Pay(txtBillCode.Text, comProductName.SelectedValue.ToString());
            }
            dataGridBill.DataSource = detailBill.AdvancedSearch(txtBillCode.Text, false);
        }

        private void txtBillCode_TextChanged(object sender, EventArgs e)
        {
            if (txtBillCode.Text == "")
            {
                dataGridBill.DataSource = "";
                txtDateBuy.Text = "";
            }
            else
            {
                Bill b = bill.Search(txtBillCode.Text, txtCustomerCode.Text);
                if (b == null)
                {
                    dataGridBill.DataSource = "";
                    txtDateBuy.Text = DateTime.Now.ToShortDateString();
                }
                else
                {
                    dataGridBill.DataSource = detailBill.AdvancedSearch(txtBillCode.Text, false);
                    txtDateBuy.Text = b.DateBuy.ToShortDateString();
                    DisplayDataToField();
                }
            }
        }

        private void dataGridBill_DataSourceChanged(object sender, EventArgs e)
        {
            txtTotal.Text = detailBill.Total(txtBillCode.Text).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có trở về trang quản lý hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }

        private void BillManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[2].Show();
        }

        private void dataGridBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DisplayDataToField(e.RowIndex);
            }
        }

        private void DisplayDataToField(int index = 0)
        {
            DataGridViewCellCollection cell = dataGridBill.Rows[index].Cells;
            string code = cell["Code"].Value.ToString();
            string quantity = cell["Quantity"].Value.ToString();
            string amount = cell["Amount"].Value.ToString();
            bool status = Convert.ToBoolean(cell["Status"].Value);
            comProductName.SelectedValue = code;
            txtQuantity.Text = quantity;
            txtAmount.Text = amount;
            radPaidAProduct.Checked = status;
            btnPayProduct.Enabled = !status;
            SelectRow(code);
        }

        private void SelectRow(string code)
        {
            int index = 0;
            for (int i = 0; i < dataGridBill.Rows.Count; i++)
            {
                DataGridViewCellCollection cell = dataGridBill.Rows[i].Cells;
                string Code = cell["Code"].Value.ToString();
                if (code.Trim().Equals(Code.Trim()))
                {
                    index = i;
                    break;
                }
            }
            for (int i = 0; i < dataGridBill.SelectedRows.Count; i++)
            {
                dataGridBill.SelectedRows[i].Selected = false;
            }
            dataGridBill.Rows[index].Selected = true;
        }
    }
}
