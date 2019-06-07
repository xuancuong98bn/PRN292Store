using BUS_SHOPPING;
using DTL_SHOPPING;
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
    public partial class BillManage : Form
    {
        ProductBUS product = new ProductBUS();
        CustomerBUS customer = new CustomerBUS();
        BillBUS bill = new BillBUS();
        DetailBillBUS detailBill = new DetailBillBUS();
        public BillManage()
        {
            InitializeComponent();
        }

        private void BillManage_Load(object sender, EventArgs e)
        {
            product.LoadComboBox(comProductName);
            comProductName.SelectedIndex = 0;
            FillPrice();
        }
        private void SetEnableTextBox(bool status)
        {
            txtCustomerName.Enabled = status;
            txtAddress.Enabled = status;
        }

        private void EmptyTextBox()
        {
            txtCustomerCode.Text = "";
            txtCustomerName.Text = "";
            txtAddress.Text = "";
            txtBillCode.Text = "";
            txtDateBuy.Text = "";
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
            Customer c = customer.Search(txtCustomerCode);
            if (c != null)
            {
                txtCustomerName.Text = c.Name;
                txtAddress.Text = c.Address;
            }
        }

        private void comProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPrice();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EmptyTextBox();
        }

        private void txtBillCode_TextChanged(object sender, EventArgs e)
        {
            List<DetailBill> list = new List<DetailBill>();
            if (txtBillCode.Text != "")
            {
                list = detailBill.Search(txtBillCode);
            }
            if (list.Count == 0)
            {
                btnBuy.Enabled = true;
                btnModify.Enabled = false;
                btnDelete.Enabled = false;
                dataGridBill.DataSource = "";
                txtDateBuy.Text = "";
            }
            else
            {
                btnBuy.Enabled = false;
                btnModify.Enabled = true;
                btnDelete.Enabled = true;
                dataGridBill.DataSource = list;
                Bill b = bill.Search(txtBillCode);
                txtDateBuy.Text = b.DateBuy.ToShortDateString();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (detailBill.SearchDetail(txtBillCode, comProductName.SelectedValue.ToString()) != null)
            {
                if (detailBill.Update(txtBillCode.Text, comProductName.SelectedValue.ToString(), txtQuantity.Text))
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Cập nhật sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (detailBill.Insert(txtBillCode.Text, comProductName.SelectedValue.ToString(), txtQuantity.Text))
                {
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detailBill.Delete(txtBillCode.Text, comProductName.SelectedValue.ToString()))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var list = detailBill.Search(txtBillCode);
                dataGridBill.DataSource = list;
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
