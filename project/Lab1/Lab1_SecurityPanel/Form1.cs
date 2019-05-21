using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab1_SecurityPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputCode(object sender)
        {
            string code = txtSecurityCode.Text;
            string number = ((Button)sender).Text;
            code += number;
            txtSecurityCode.Text = code;
        }

        private void AccessLog()
        {
            string log = DateTime.Now.ToString() + "\t";
            string code = txtSecurityCode.Text;
            switch (code)
            {
                case "1645":
                case "1689":
                    log += "Technicians";
                    break;
                case "8345":
                    log += "Custodians";
                    break;
                case "9998":
                case "1006":
                case "1008":
                    log += "Scientist";
                    break;
                default:
                    log += "Restricted Access!";
                    break;
            }
            listBoxAccessLog.Items.Add(log);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            InputCode(sender);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            InputCode(sender);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            InputCode(sender);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            InputCode(sender);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            InputCode(sender);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            InputCode(sender);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            InputCode(sender);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            InputCode(sender);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            InputCode(sender);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            InputCode(sender);
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            AccessLog();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text = "";
        }
    }
}
