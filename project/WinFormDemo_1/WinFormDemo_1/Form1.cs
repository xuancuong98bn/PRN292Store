using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormDemo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool IsLegal()
        {
            try
            {
                int a = Convert.ToInt32(txtA.Text);
                int b = Convert.ToInt32(txtB.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Input invalid", "Error");
                return false;
            }
            return true;
        }

        public void Caculation()
        {
            if (IsLegal())
            {
                int a = Convert.ToInt32(txtA.Text);
                int b = Convert.ToInt32(txtB.Text);

                switch (cmbCal.Text)
                {
                    case "+":
                        txtResult.Text = Sum(a, b).ToString();
                        break;
                    case "-":
                        txtResult.Text = Sub(a, b).ToString();
                        break;
                    case "*":
                        txtResult.Text = Mul(a, b).ToString();
                        break;
                    case "/":
                        if (b == 0)
                        {
                            MessageBox.Show("Can't divide to zero", "Error");
                        }
                        else
                        {
                            txtResult.Text = Div(a, b).ToString();
                        }
                        break;
                    default:
                        MessageBox.Show("Enter Oprator", "Error");
                        txtResult.Text = "Nothing";
                        break;
                }
            }
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
        public double Div(int a, int b)
        {
            return a / (double)b;
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            Caculation();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            cmbCal.Text = "";
            txtResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            };
        }

        private void txtA_Enter(object sender, EventArgs e)
        {
            txtA.BackColor = Color.Violet;
        }

        private void txtA_Leave(object sender, EventArgs e)
        {
            txtA.BackColor = Color.White;
        }

        private void txtB_Enter(object sender, EventArgs e)
        {
            txtB.BackColor = Color.Violet;
        }

        private void txtB_Leave(object sender, EventArgs e)
        {
            txtB.BackColor = Color.White;
        }
    }
}
