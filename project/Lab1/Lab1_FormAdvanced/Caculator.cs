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
    public partial class Caculator : Form
    {
        public Caculator()
        {
            InitializeComponent();
        }

        private void Caculate()
        {
            float a, b, result = 0;
            if (CheckNumber(txtA, lblA, out a) && CheckNumber(txtB, lblB, out b) && CheckEmpty(cmbOperator, lblOperator))
            {
                switch (cmbOperator.Text)
                {
                    case "+":
                        result = Sum(a, b);
                        break;
                    case "-":
                        result = Sub(a, b);
                        break;
                    case "*":
                        result = Mul(a, b);
                        break;
                    case "/":
                        if (b == 0)
                        {
                            MessageBox.Show("Không thể chia cho 0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            result = Div(a, b);
                        }
                        break;
                }
                txtResult.Text = result.ToString();
            }
        }

        private bool CheckEmpty(Control txt, Label lbl)
        {
            if (txt.Text.Trim() == "")
            {
                MessageBox.Show(lbl.Text + " không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool CheckNumber(TextBox txt, Label lbl, out float a)
        {
            a = 0;
            if (CheckEmpty(txt, lbl))
            {
                bool rs = float.TryParse(txt.Text.Trim(), out a);
                if (!rs)
                {
                    MessageBox.Show(lbl.Text + " chỉ được nhập số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            return false;
        }

        private float Sum(float a, float b)
        {
            return a + b;
        }

        private float Sub(float a, float b)
        {
            return a - b;
        }

        private float Mul(float a, float b)
        {
            return a * b;
        }

        private float Div(float a, float b)
        {
            return a / b;
        }

        private void txtA_Enter(object sender, EventArgs e)
        {
            txtA.BackColor = Color.Pink;
        }

        private void txtA_Leave(object sender, EventArgs e)
        {
            txtA.BackColor = Color.White;
        }

        private void txtB_Enter(object sender, EventArgs e)
        {
            txtB.BackColor = Color.Pink;
        }

        private void txtB_Leave(object sender, EventArgs e)
        {
            txtB.BackColor = Color.White;
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            if (txtA.Text.Trim() == "")
            {
                lblRequiredA.ForeColor = Color.Red;
            }
            else
            {
                lblRequiredA.ForeColor = Color.Blue;
            }
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            if (txtB.Text.Trim() == "")
            {
                lblRequiredB.ForeColor = Color.Red;
            }
            else
            {
                lblRequiredB.ForeColor = Color.Blue;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            cmbOperator.Text = "";
            txtResult.Text = "";
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            Caculate();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đến với bài tiếp theo không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                MathSolution mathSolution = new MathSolution();
                this.Hide();
                mathSolution.Show();
            }
        }

        private void Caculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
}
