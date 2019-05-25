using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Exe_Student
{
    public partial class Form1 : Form
    {
        Dictionary<string, Student> dicStudent;
        public Form1()
        {
            InitializeComponent();
            dicStudent = new Dictionary<string, Student>();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
            txtName.Text = "";
            cmbSubject.Text = "";
            numMark.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private bool CheckInput()
        {
            if (txtCode.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!CheckCode(txtCode.Text))
            {
                MessageBox.Show("Mã sinh viên không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Tên sinh viên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!CheckName())
            {
                MessageBox.Show("Tên dài quá so với quy định", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbSubject.Text.Trim() == "")
            {
                MessageBox.Show("Chọn môn học cho nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }



        private bool CheckName()
        {
            return txtName.Text.Length <= 15;
        }

        private void Add()
        {
            if (true) {
                string code = txtCode.Text.Trim();
                string name = Normalization(txtName.Text);
                string subject = cmbSubject.Text;
                int mark = Convert.ToInt32(numMark.Text);
                Student student = new Student(code, name, subject, mark);
                if (!dicStudent.ContainsKey(code))
                {
                    dicStudent.Add(code, student);
                    listBoxInform.Items.Add(student.ToString());
                }
                else
                {
                    dicStudent[code] = student;
                    Update();
                }
                
            }
        }

        private void Update()
        {
            listBoxInform.Items.Clear();
            foreach (var item in dicStudent)
            {
                listBoxInform.Items.Add(item.Value.ToString());
            }
        }

        private bool CheckCode(string code)
        {
            code = code.Trim();
            return Regex.IsMatch(code, @"^SV\d{2}$");
        }

        public string Normalization(string str)
        {
            string[] subStr = Regex.Replace(str, @"\s+", " ").Trim().ToLower().Split(' ');
            return Concat(subStr, true);
        }

        public string Concat(string[] subStr, bool upperFirst = false)
        {
            string str = "";
            for (int i = 0; i < subStr.Length; i++)
            {
                if (upperFirst)
                {
                    string s = subStr[i];
                    s = s.Substring(0, 1).ToUpper() + s.Substring(1);
                    str += s + " ";
                }
                else
                {
                    str += subStr[i] + " ";
                }
            }
            return str;
        }
    }
}
