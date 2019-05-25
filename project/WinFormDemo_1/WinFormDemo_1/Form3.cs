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
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int i = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 15)
            {
                timer1.Stop();
                label1.Text = "";
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
            label1.Text = i.ToString();
            i++;

        }
    }
}
