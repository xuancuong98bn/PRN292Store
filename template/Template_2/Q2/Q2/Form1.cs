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
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductDAO.GetTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Service.IsEmptyControl(new TextBox[] { textBox1, textBox2, textBox3, textBox4 }))
            {
                string Code = textBox1.Text;
                if (ProductDAO.IsExsist(Code))
                {
                    MessageBox.Show("Dupplicated!");
                    return;
                }

                try
                {
                    string Name = textBox2.Text;
                    string Unit = textBox3.Text;
                    double Price = Convert.ToDouble(textBox4.Text);
                    Product p = new Product(Code, Name, Unit, Price);
                    if (ProductDAO.Insert(p))
                    {
                        MessageBox.Show("Insert successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Insert fail!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Price must be number!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Input must be not empty!");
            }
            dataGridView1.DataSource = ProductDAO.GetTable();
        }
    }
}
