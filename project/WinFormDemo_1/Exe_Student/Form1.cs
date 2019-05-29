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

        string connectionString = ConfigurationManager.ConnectionStrings["ManagerPRN292"].ConnectionString;

        /// <summary>
        /// Cách 1 Kết nối db sử dụng sqlConnection, sqlCommand, sqlDataReader
        /// Cách này là cách truyền thống, đầy đủ các bước mở kết nối lấy data và đóng kết nối
        /// </summary>
        private void getSuject()
        {
            string sql = @"SELECT * FROM tblSubject";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Subject> list = new List<Subject>();
            while (dr.Read())
            {
                int id = Convert.ToInt32(dr["id"]);
                string name = dr["name"].ToString();
                list.Add(new Subject(id, name));
            }
            cmbSubject.DataSource = list;
            cmbSubject.DisplayMember = "name";
            cmbSubject.ValueMember = "id";
            conn.Close();
        }
        
        /// <summary>
        /// Cách 2 Kết nối db sử dụng dataAdapter
        /// Thường sử dụng cách này hơn vì nó dễ thao tác
        /// </summary>
        private void getStudent()
        {
            string sql = @"SELECT * FROM tblStudent";
            SqlDataAdapter da = new SqlDataAdapter(sql, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGrid.DataSource = ds.Tables[0];
        }

        Dictionary<string, Student> dicStudent;
        public Form1()
        {
            InitializeComponent();
            dicStudent = new Dictionary<string, Student>();
            getSuject();
            getStudent();
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
                int subject = (int) cmbSubject.SelectedValue;
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
    }
}
