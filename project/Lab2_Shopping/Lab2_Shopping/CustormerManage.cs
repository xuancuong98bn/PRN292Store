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
            txtDOB.Text = c.Dob.ToLongDateString();
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

        private void dataGridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            EmptyTextBox();
        }
    }
}
