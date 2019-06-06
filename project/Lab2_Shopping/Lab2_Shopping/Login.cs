using BUS_SHOPPING;
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
    public partial class Login : Form
    {
        UserBUS userBUS = new UserBUS();
        public Login()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (userBUS.Login(txtUsername, txtPassword))
            {
                Hide();
                MainForm main = new MainForm();
                main.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
