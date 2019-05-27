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
    public partial class MyRandom : Form
    {
        Dictionary<int, int> dic;
        int min, max;
        public MyRandom()
        {
            InitializeComponent();
            min = 1;
            max = 2;
            initList();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            while (true)
            {
                if (dic.Count > 0)
                {
                    int value = random.Next(1, max);
                    if (dic.ContainsKey(value))
                    {
                        lblResult.Text = value.ToString();
                        dic.Remove(value);
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("Đã hết số để chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }

        private void numInput_ValueChanged(object sender, EventArgs e)
        {
            max = (int)numInput.Value + 1;
            initList();
        }

        private void MyRandom_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void initList()
        {
            dic = new Dictionary<int, int>();
            for (int i = 1; i < max; i++)
            {
                dic.Add(i, i);
            }
        }
    }
}
