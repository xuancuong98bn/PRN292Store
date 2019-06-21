using BUS_PROJECT;
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
                CustormerManage custormer = new CustormerManage();
                custormer.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
