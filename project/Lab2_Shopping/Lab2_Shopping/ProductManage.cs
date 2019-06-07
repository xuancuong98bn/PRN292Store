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
    public partial class ProductManage : Form
    {
        ProductBUS product = new ProductBUS();
        public ProductManage()
        {
            InitializeComponent();
        }

        private void ProductManage_Load(object sender, EventArgs e)
        {
            product.LoadGridView(dataGridProduct);
            Product p = product.GetFirstProduct(dataGridProduct);
            SetValueTextBox(p);
        }

        private void SetValueTextBox(Product c)
        {
            SetEnableTextBox(false);
            txtCode.Text = c.Code;
            txtName.Text = c.Name;
            comboUnit.Text = c.Unit;
            txtPrice.Text = c.Price.ToString();
        }

        private void SetEnableTextBox(bool status)
        {
            txtCode.Enabled = status;
            txtName.Enabled = status;
            comboUnit.Enabled = status;
            txtPrice.Enabled = status;
        }

        private void EmptyTextBox()
        {
            SetEnableTextBox(true);
            txtCode.Text = "";
            txtName.Text = "";
            comboUnit.Text = "";
            txtPrice.Text = "";
        }

        private bool CheckEmpty()
        {
            if (IsEmptyTxt(txtCode, lblCode)) return false;
            if (IsEmptyTxt(txtName, lblName)) return false;
            if (IsEmptyTxt(comboUnit, lblUnit)) return false;
            if (IsEmptyTxt(txtPrice, lblPrice)) return false;
            return true;
        }

        private bool IsEmptyTxt(Control txt, Label lbl)
        {
            if (txt.Text.Trim() == "")
            {
                MessageBox.Show(lbl.Text + " không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void dataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SetEnableButton(true, false, true, false, true);
                DataGridViewCellCollection cell = dataGridProduct.Rows[e.RowIndex].Cells;
                string code = cell["Code"].Value.ToString();
                string name = cell["Name"].Value.ToString();
                string unit = cell["Unit"].Value.ToString();
                double price = Convert.ToDouble(cell["Price"].Value);
                Product c = new Product(code, name, unit, price);
                SetValueTextBox(c);
            }
        }

        private void SetEnableButton(bool b1, bool b2, bool b3, bool b4, bool b5)
        {
            btnNew.Enabled = b1;
            btnAdd.Enabled = b2;
            btnModify.Enabled = b3;
            btnUpdate.Enabled = b4;
            btnDelete.Enabled = b5;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EmptyTextBox();
            SetEnableButton(true, true, false, false, false);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
            {
                if (product.Insert(txtCode.Text, txtName.Text, comboUnit.Text, txtPrice.Text))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    product.LoadGridView(dataGridProduct);
                    SetEnableButton(true, false, false, true, true);
                    txtCode.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            SetEnableButton(true, false, false, true, true);
            SetEnableTextBox(true);
            txtCode.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
            {
                if (product.Update(txtCode.Text, txtName.Text, comboUnit.Text, txtPrice.Text))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    product.LoadGridView(dataGridProduct);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (product.Delete(txtCode.Text))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                product.LoadGridView(dataGridProduct);
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
    }
}
