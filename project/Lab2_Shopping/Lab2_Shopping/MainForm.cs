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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mitemUpdateCustomer_Click(object sender, EventArgs e)
        {
            Hide();
            CustormerManage custormer = new CustormerManage();
            custormer.Show();
        }

        private void mitemUpdateProduct_Click(object sender, EventArgs e)
        {
            Hide();
            ProductManage product = new ProductManage();
            product.Show();
        }

        private void mitemShoppingSolution_Click(object sender, EventArgs e)
        {
            Hide();
            BillManage bill = new BillManage();
            bill.Show();
        }

        private void mitemReport_Click(object sender, EventArgs e)
        {
            Hide();
            ReportManage report = new ReportManage();
            report.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
}
