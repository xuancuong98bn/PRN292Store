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

        private void btnNew_Click(object sender, EventArgs e)
        {
            EmptyTextBox();
        }

        private void txtBillCode_TextChanged(object sender, EventArgs e)
        {
            Bill b = bill.Search(txtBillCode);
            if (b == null)
            {
                btnBuy.Enabled = true;
                btnModify.Enabled = false;
                btnDelete.Enabled = false;
                dataGridBill.DataSource = "";
                txtDateBuy.Text = "";
            }
            else
            {
                List<DetailBill> list = detailBill.Search(txtBillCode);
                btnBuy.Enabled = false;
                btnModify.Enabled = true;
                btnDelete.Enabled = true;
                dataGridBill.DataSource = list;
                txtDateBuy.Text = b.DateBuy.ToShortDateString();
            }
            if (txtBillCode.Text == "")
            {
                btnBuy.Enabled = false;
                btnModify.Enabled = false;
                btnDelete.Enabled = false;
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
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }

        private void BillManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.OpenForms[1].Show();
        }
    }
}
