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
    public partial class MathSolution : Form
    {
        public MathSolution()
        {
            InitializeComponent();
        }

        private void Caculate()
        {
            float a, b;
            string result = "";
            if (CheckNumber(txtA, lblA, out a) && CheckNumber(txtB, lblB, out b))
            {
                if (radLinear.Checked)
                {
                    result = LinearEquation(a, b);
                }
                if (radGCD.Checked)
                {
                    result = "Greatest Common Divisor = " + GCD((int)a, (int)b);
                }
                if (radLCM.Checked)
                {
                    result = "Least Common Denominato = " + LCM((int)a, (int)b);
                }
                lblResult.Text = result;
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

        private string LinearEquation(float a, float b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    return "Phương trình vô số nghiệm";
                } else
                {
                    return "Phương trình vô nghiệm";
                }
            }
            return "x = " + b/a;
        }

        //- Tìm ước chung lớn nhất của 2 số nguyên. (trả về)
        public int GCD(int a, int b)
        {
            if (b == 0) return a;
            return GCD(b, a % b);
        }

        //- Tìm bội chung nhỏ nhất của 2 số nguyên. (trả về)
        public int LCM(int a, int b)
        {
            return a * b / GCD(a, b);
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
            lblResult.Text = "";
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
                MyRandom myRandom = new MyRandom();
                this.Hide();
                myRandom.Show();
            }
        }
    }
}
