using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab1_Employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbRole.SelectedIndex)
            {
                case 0:
                    txtSalary.Text = "10000000";
                    break;
                case 1:
                    txtSalary.Text = "8000000";
                    break;
                case 2:
                    txtSalary.Text = "6000000";
                    break;
                case 3:
                    txtSalary.Text = "4000000";
                    break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
            txtName.Text = "";
            cmbRole.Text = "";
            txtSalary.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Add();
        }

        private bool CheckInput()
        {
            if (txtCode.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!CheckCode())
            {
                MessageBox.Show("Mã nhân viên không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!CheckName())
            {
                MessageBox.Show("Tên dài quá so với quy định", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbRole.Text.Trim() == "")
            {
                MessageBox.Show("Chọn chức vụ cho nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool CheckCode()
        {
            string code = txtCode.Text.Trim();
            return Regex.IsMatch(code, @"^SV\d{2}$");
        }

        private bool CheckName()
        {
            return txtName.Text.Length <= 15;
        }

        private void Add()
        {
            if (CheckInput()) {
                string code = txtCode.Text.Trim();
                string name = Normalization(txtName.Text);
                string gender = radMale.Checked ? radMale.Text : radFemale.Text;
                string role = cmbRole.Text;
                string salary = txtSalary.Text;
                for (int i = 0; i < listBoxInform.Items.Count; i++)
                {
                    string item = listBoxInform.Items[i].ToString();
                    if (item.Contains(code))
                    {
                        listBoxInform.Items[i] = Display(code, name, gender, role, salary);
                        return;
                    }
                }
                string log = Display(code, name, gender, role, salary);
                listBoxInform.Items.Add(log);
            }
        }

        public string Normalization(string str)
        {
            string[] subStr = Regex.Replace(str, @"\s+", " ").Trim().ToLower().Split(' ');
            return Concat(subStr, true);
        }

        public string Concat(string[] subStr, bool upperFirst = false)
        {
            string str = "";
            for (int i = 0; i < subStr.Length; i++)
            {
                if (upperFirst)
                {
                    string s = subStr[i];
                    s = s.Substring(0, 1).ToUpper() + s.Substring(1);
                    str += s + " ";
                }
                else
                {
                    str += subStr[i] + " ";
                }
            }
            return str;
        }

        private string Display (string code, string name, string gender, string role, string salary)
        {
            return code + "\t" + name + "\t" + gender + "\t" + role + "\t" + salary;
        }
        /*
         add chức vụ: giám đóc, kế toán, nhân viên, bảo vệ;
         10tr, 8,6,4
         OK - Check input
         */
    }
}
