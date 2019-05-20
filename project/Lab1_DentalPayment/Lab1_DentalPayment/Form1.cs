using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab1_DentalPayment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int total = 0;
                total += ckbClean.Checked ? 100000 : 0;
                total += ckbWhitening.Checked ? 1200000 : 0;
                total += ckbXRay.Checked ? 200000 : 0;
                total += (int)numFilling.Value * 80000;
                txtTotal.Text = "$" + total;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
