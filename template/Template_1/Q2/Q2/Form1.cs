using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "SE05392";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ColorDialog MyDialog = new ColorDialog();
            //// Keeps the user from selecting a custom color.
            //MyDialog.AllowFullOpen = false;
            //// Allows the user to get help. (The default is false.)
            //MyDialog.ShowHelp = true;
            //// Sets the initial color select to the current text color.
            //MyDialog.Color = textBox3.ForeColor;
            //// Update the text box color if the user clicks OK 
            //if (MyDialog.ShowDialog() == DialogResult.OK)
            //    textBox3.ForeColor = MyDialog.Color;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox3.BackColor = colorDialog1.Color;
        }

        private bool CheckEmpty()
        {
            string s = textBox2.Text.Trim();
            string t = textBox4.Text.Trim();
            string r = textBox5.Text.Trim();
            return s != null && s != "" && t != null && t != "" && r != null && r != "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
            {
                Button b = new Button();
                b.Text = textBox2.Text;
                b.BackColor = textBox3.BackColor;
                b.Location = new Point(Convert.ToInt32(textBox4.Text),Convert.ToInt32(textBox5.Text));
                byte R = b.BackColor.R;
                byte G = b.BackColor.G;
                byte B = b.BackColor.B;
                panel1.Controls.Add(b);
                MessageBox.Show("Label:" + b.Text + "\nColor:RGB(" + R + "," + G + "," + B + ")", "", MessageBoxButtons.OK);
            }
        }

        bool locked = false;
        private void button4_Click(object sender, EventArgs e)
        {
            locked = !locked;
            if (locked)
            {
                label7.Text = "The locked mode is enabled";
            } else
            {
                label7.Text = "The locked mode is disabled";
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (locked)
            {
                locked = false;
                label7.Text = "";
                textBox4.Text = e.X.ToString();
                textBox5.Text = e.Y.ToString();
            }
        }
    }
}
