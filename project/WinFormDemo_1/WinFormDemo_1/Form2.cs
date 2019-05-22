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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public bool Input(TextBox textBox, Label label, ref double a)
        {
            try
            {
                a = Convert.ToDouble(textBox.Text.Trim());
            }
            catch (Exception e)
            {
                MessageBox.Show(label.Text + " invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public void Caculation()
        {
            double a = 0;
            double b = 0;

            if (Input(txtA, label2, ref a) && Input(txtB, label3, ref b))
            {
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

        public double Sum(double a, double b)
        {
            return a + b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }
        public double Mul(double a, double b)
        {
            return a * b;
        }
        public double Div(double a, double b)
        {
            return a / b;
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
