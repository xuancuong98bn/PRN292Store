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
            FillPrice();
        }

        private void EmptyTextBox()
        {
            txtCustomerCode.Text = "";
            txtCustomerName.Text = "";
            txtAddress.Text = "";
            txtBillCode.Text = "";
            txtDateBuy.Text = "";
        }

        private bool CheckInput()
        {
            if (Service.IsEmptyControl(txtCustomerCode, lblCode.Text))
            {
                return false;
            }
            if (customer.Search(txtCustomerCode.Text) == null)
            {
                MessageBox.Show("Người dùng không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (Service.IsEmptyControl(txtDateBuy, lblBillDate.Text))
            {
                return false;
            }
            return true;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (bill.Insert(txtBillCode.Text, txtCustomerCode.Text, txtDateBuy.Text))
                {
                    MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetEnableButton(false, true, true);
                    dataGridBill.DataSource = detailBill.AdvancedSearch(txtBillCode.Text);
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            EmptyTextBox();
        }

        private void SetEnableButton(bool b1, bool b2, bool b3)
        {
            btnBuy.Enabled = b1;
            btnModify.Enabled = b2;
            btnDelete.Enabled = b3;
        }

        private void txtBillCode_TextChanged(object sender, EventArgs e)
        {
            if (txtBillCode.Text == "")
            {
                SetEnableButton(false, false, false);
                dataGridBill.DataSource = "";
                txtDateBuy.Text = "";
            }
            else
            {
                Bill b = bill.Search(txtBillCode.Text);
                if (b == null)
                {
                    SetEnableButton(true, false, false);
                    dataGridBill.DataSource = "";
                    txtDateBuy.Text = DateTime.Now.ToShortDateString();
                }
                else
                {
                    SetEnableButton(false, true, true);
                    dataGridBill.DataSource = detailBill.AdvancedSearch(txtBillCode.Text);
                    txtDateBuy.Text = b.DateBuy.ToShortDateString();
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (detailBill.SearchDetail(txtBillCode.Text, comProductName.SelectedValue.ToString()) != null)
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
            dataGridBill.DataSource = detailBill.AdvancedSearch(txtBillCode.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DetailBill detail = detailBill.SearchDetail(txtBillCode.Text, comProductName.SelectedValue.ToString());
            if (detail != null)
            {
                if (detailBill.Delete(txtBillCode.Text, comProductName.SelectedValue.ToString()))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var list = detailBill.AdvancedSearch(txtBillCode.Text);
                    dataGridBill.DataSource = list;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Sản phẩm không tồn tại trong hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            Application.OpenForms[1].Show();
        }

        
    }
}
