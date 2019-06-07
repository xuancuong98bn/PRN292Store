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
    public partial class CustormerManage : Form
    {
        CustomerBUS custormer = new CustomerBUS();
        public CustormerManage()
        {
            InitializeComponent();
        }

        private void CustormerManage_Load(object sender, EventArgs e)
        {
            custormer.LoadGridView(dataGridCustomer);
            dataGridCustomer.Rows[0].Cells[0].Selected = true;
            Customer c = custormer.GetFirstCustomer(dataGridCustomer);
            SetValueTextBox(c);
        }

        private void SetValueTextBox(Customer c)
        {
            SetEnableTextBox(false);
            txtCode.Text = c.Code;
            txtDOB.Text = c.Dob.ToString();
            txtAddress.Text = c.Address;
            txtName.Text = c.Name;
            radMale.Checked = c.Gender;
            radFemale.Checked = !c.Gender;
        }

        private void SetEnableTextBox(bool status)
        {
            txtCode.Enabled = status;
            txtDOB.Enabled = status;
            txtAddress.Enabled = status;
            txtName.Enabled = status;
            radMale.Enabled = status;
            radFemale.Enabled = status;
        }

        private void EmptyTextBox()
        {
            SetEnableTextBox(true);
            txtCode.Text = "";
            txtDOB.Text = "";
            txtAddress.Text = "";
            txtName.Text = "";
            radMale.Checked = true;
            radFemale.Checked = false;
        }

        private bool CheckEmpty()
        {
            if (IsEmptyTxt(txtCode, lblCode)) return false;
            if (IsEmptyTxt(txtName, lblName)) return false;
            if (IsEmptyTxt(txtDOB, lblDOB)) return false;
            if (IsEmptyTxt(txtAddress, lblAddress)) return false;
            return true;
        }

        private bool IsEmptyTxt(TextBox txt, Label lbl)
        {
            if (txt.Text.Trim() == "")
            {
                MessageBox.Show(lbl.Text + " không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void dataGridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SetEnableButton(true, false, true, false, true);
                DataGridViewCellCollection cell = dataGridCustomer.Rows[e.RowIndex].Cells;
                string code = cell["Code"].Value.ToString();
                DateTime dob = Convert.ToDateTime(cell["DOB"].Value);
                string address = cell["Address"].Value.ToString();
                string name = cell["Name"].Value.ToString();
                bool gender = Convert.ToBoolean(cell["Gender"].Value);
                Customer c = new Customer(code, name, gender, address, dob);
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
                bool gender = radMale.Checked;
                if (custormer.Insert(txtCode.Text, txtName.Text, gender, txtDOB.Text, txtAddress.Text))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    custormer.LoadGridView(dataGridCustomer);
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
                bool gender = radMale.Checked;
                if (custormer.Update(txtCode.Text, txtName.Text, gender, txtDOB.Text, txtAddress.Text))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    custormer.LoadGridView(dataGridCustomer);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (custormer.Delete(txtCode.Text))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                custormer.LoadGridView(dataGridCustomer);
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

        private void CustormerManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.OpenForms[1].Show();
        }
    }
}
