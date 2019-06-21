using BUS_PROJECT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MAIN_PROJECT
{
    public partial class Exercise : Form
    {
        ProjectBUS project = new ProjectBUS();
        EmployeeBUS employee = new EmployeeBUS();
        ProjectMemberBUS ProjectMember = new ProjectMemberBUS();

        public Exercise()
        {
            InitializeComponent();
        }

        private void Exercise_Load(object sender, EventArgs e)
        {
            project.LoadDataToListBox(listProject);
            employee.LoadDataToListBox(listEmployee);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProjectMember.Insert(listEmployee.SelectedValue.ToString(), listProject.SelectedValue.ToString(), txtPosition, ckbIsFulltime.Checked, datetimeJoinDate.Value);
        }
    }
}
