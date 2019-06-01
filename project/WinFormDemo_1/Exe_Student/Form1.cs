using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Exe_Student
{
    public partial class Form1 : Form
    {
        bool loadDone = false;
        private void getSuject()
        {
            cmbSubject.DataSource = DataAccess.ExecuteQuery("SELECT * FROM tblSubject");
            cmbSubject.DisplayMember = "name";
            cmbSubject.ValueMember = "id";
        }

        private void getStudent()
        {
            listBoxInform.DataSource = DataAccess.ExecuteQuery("SELECT code, name FROM tblStudent");
            listBoxInform.DisplayMember = "name";
            listBoxInform.ValueMember = "code";
        }

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
                MessageBox.Show("Chọn môn học cần thêm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool CheckName()
        {
            return txtName.Text.Trim().Length <= 15;
        }

        private void Add()
        {
            if (CheckInput())
            {
                string code = txtCode.Text.Trim();
                string name = Normalization(txtName.Text);
                int subject = (int)cmbSubject.SelectedValue;
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
                    Updatee();
                }

            }
        }

        private void Updatee()
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

        private void listBoxInform_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadDone)
            {
                DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM tblStudent WHERE code = '" + listBoxInform.SelectedValue + "'");
                object[] row = dt.Rows[0].ItemArray;
                txtCode.Text = row[0].ToString().Trim();
                txtName.Text = row[1].ToString().Trim();
                cmbSubject.SelectedValue = Convert.ToUInt32(row[2]);
                numMark.Value = Convert.ToUInt32(row[3]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getSuject();
            getStudent();
            loadDone = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (!DataAccess.IsDupplicate("SELECT code FROM tblStudent WHERE code = '" + txtCode.Text + "'"))
                {
                    string sql = "INSERT INTO tblStudent VALUES ('" + txtCode.Text + "', '" + txtName.Text + "', " + cmbSubject.SelectedValue + ", " + numMark.Value + ")";
                    DataAccess.ExecuteNonQuery(sql);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getStudent();
                }
                else
                {
                    MessageBox.Show("Mã sinh viên bị trùng lặp", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (txtCode.Text.Trim().Equals(listBoxInform.SelectedValue.ToString().Trim()))
                {
                    string sql = "UPDATE tblStudent SET name = '" + txtName.Text + "', idSubject = " + cmbSubject.SelectedValue + ", mark = " + numMark.Value + " WHERE code ='" + listBoxInform.SelectedValue + "'";
                    DataAccess.ExecuteNonQuery(sql);
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getStudent();
                }
                else
                {
                    if (!DataAccess.IsDupplicate("SELECT code FROM tblStudent WHERE code = '" + txtCode.Text + "'"))
                    {
                        string sql = "UPDATE tblStudent SET code = '" + txtCode.Text + "', name = '" + txtName.Text + "', idSubject = " + cmbSubject.SelectedValue + ", mark = " + numMark.Value + " WHERE code ='" + listBoxInform.SelectedValue + "'";
                        DataAccess.ExecuteNonQuery(sql);
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getStudent();
                    }
                    else
                    {
                        MessageBox.Show("Mã sinh viên bị trùng lặp", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM tblStudent WHERE code = '" + listBoxInform.SelectedValue + "'";
            DataAccess.ExecuteNonQuery(sql);
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            getStudent();
        }
    }
}
