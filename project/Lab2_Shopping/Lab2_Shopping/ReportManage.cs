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
    public partial class ReportManage : Form
    {
        ProductBUS product = new ProductBUS();
        public ReportManage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }

        private void ReportManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridProduct.DataSource = product.AdvanceSearch(comboBillCode.SelectedValue.ToString(), txtFrom.Text, txtTo.Text);
        }

        private void ReportManage_Load(object sender, EventArgs e)
        {
            product.LoadComboBoxStyle2(comboBillCode);
        }

        private void comboBillCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product p = product.Search(comboBillCode.Text);
            txtNameProduct.Text = p.Name;
        }
    }
}
