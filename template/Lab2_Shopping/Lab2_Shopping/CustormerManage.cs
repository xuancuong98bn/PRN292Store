using BUS_PROJECT;
using DTL_PROJECT;
using SERVICE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MAIN_PROJECT
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
            SetEnableTextBox(false);
        }

        private void SetValueTextBox(Customer c)
        {
            txtCode.Text = c.Code;
            txtDOB.Text = c.Dob.ToString();
            txtAddress.Text = c.Address;
            txtName.Text = c.Name;
            radMale.Checked = c.IsGender();
            radFemale.Checked = !c.IsGender();
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

        private void EmptyTextBox(bool checkCode)
        {
            SetEnableTextBox(true);
            txtCode.Text = checkCode?"": txtCode.Text;
            txtDOB.Text = DateTime.Now.ToString();
            txtAddress.Text = "";
            txtName.Text = "";
            radMale.Checked = true;
            radFemale.Checked = false;
        }

        private bool CheckEmpty()
        {
            if (Service.IsEmptyControl(txtCode, lblCode.Text)) return false;
            if (Service.IsEmptyControl(txtName, lblName.Text)) return false;
            if (Service.IsEmptyControl(txtDOB, lblDOB.Text)) return false;
            if (Service.IsEmptyControl(txtAddress, lblAddress.Text)) return false;
            return true;
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
                //bool gender = cell["Gender"].Value.Equals("Nam");
                Customer c = new Customer(code, name, gender, address, dob);
                SetValueTextBox(c);
                SetEnableTextBox(false);
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

        private void SelectRow(string code)
        {
            int index = 0;
            for (int i = 0; i < dataGridCustomer.Rows.Count; i++)
            {
                DataGridViewCellCollection cell = dataGridCustomer.Rows[i].Cells;
                string Code = cell["Code"].Value.ToString();
                if (code.Trim().Equals(Code.Trim()))
                {
                    index = i;
                    break;
                }
            }
            for (int i = 0; i < dataGridCustomer.SelectedRows.Count; i++)
            {
                dataGridCustomer.SelectedRows[i].Selected = false;
            }
            dataGridCustomer.Rows[index].Selected = true;
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            Customer c = custormer.Search(txtCode.Text);
            if (c != null)
            {
                SetValueTextBox(c);
                SetEnableTextBox(false);
                txtCode.Enabled = true;
                btnAdd.Enabled = false;
                SelectRow(c.Code);
            }
            else
            {
                btnAdd.Enabled = true;
                EmptyTextBox(false);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EmptyTextBox(true);
            txtCode.Text = custormer.GetNextCode();
            txtCode.ReadOnly = true;
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
            Application.OpenForms[0].Show();
        }
    }
}
