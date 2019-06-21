using DAL_PROJECT;
using DTL_PROJECT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BUS_PROJECT
{
    public class EmployeeBUS
    {
        public void LoadDataToListBox(ListBox listBox)
        {
            var data = EmployeeDAL.GetTable();
            listBox.DataSource = data;
            listBox.DisplayMember = "name";
            listBox.ValueMember = "id";
        }
    }
}
