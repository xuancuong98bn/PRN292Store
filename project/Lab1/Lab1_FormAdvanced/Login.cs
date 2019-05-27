using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab1_FormAdvanced
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.Pink;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.Pink;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
            {
                lblRequiredUser.ForeColor = Color.Red;
            }
            else
            {
                lblRequiredUser.ForeColor = Color.Blue;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "")
            {
                lblRequiredPass.ForeColor = Color.Red;
            }
            else
            {
                lblRequiredPass.ForeColor = Color.Blue;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private bool CheckInput()
        {
            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if ("Admin".Equals(txtUsername.Text) && "123456".Equals(txtPassword.Text))
                {
                    Caculator caculator = new Caculator();
                    this.Hide();
                    caculator.Show();
                } else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void lblForgot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quên thì thôi, tự tìm đi!", "Gợi ý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
