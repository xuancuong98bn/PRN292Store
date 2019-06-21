using DAL_PROJECT;
using DTL_PROJECT;
using SERVICE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BUS_PROJECT
{
    public class ProjectMemberBUS
    {

        //public void LoadGridView(DataGridView dataGrid)
        //{
        //    var data = ProjectMemberDAL.GetTable();
        //    dataGrid.DataSource = data;
        //}

        //public ProjectMember GetFirstCustomer(DataGridView dataGrid)
        //{
        //    ProjectMember c = null;
        //    if (dataGrid.Rows.Count > 0)
        //    {
        //        string code = dataGrid.Rows[0].Cells["Code"].Value.ToString();
        //        c = ProjectMemberDAL.Search(code);
        //    }
        //    return c;
        //}

        //public string GetNextCode()
        //{
        //    string code = ProjectMemberDAL.LastCode().Replace("KH","");
        //    int curr = Convert.ToInt32(code) + 1;
        //    string next = "KH"+ (curr >= 10 ? curr.ToString() : "0" + curr);
        //    return next;
        //}

        //public ProjectMember Search(string code)
        //{
        //    ProjectMember c = ProjectMemberDAL.Search(code);
        //    return c;
        //}

        public bool Insert(string employeeID, string projectID, TextBox position, bool isFulltime, DateTime date)
        {
            if (!Service.IsEmptyControl(position, "Position"))
            {
                try
                {
                    int EmployeeID = Convert.ToInt32(employeeID);
                    int ProjectID = Convert.ToInt32(projectID);
                    ProjectMember c = new ProjectMember(EmployeeID, ProjectID, position.Text, isFulltime, date);
                    if (ProjectMemberDAL.IsDupplicate(EmployeeID, ProjectID))
                    {
                        MessageBox.Show("This employee has been added to the project.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        ProjectMemberDAL.Insert(c);
                        MessageBox.Show("Data is saved!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            return false;
        }

        //    public bool Update(string code, string name, bool gender, string dob, string address)
        //    {
        //        DateTime DOB;
        //        try
        //        {
        //            DOB = Convert.ToDateTime(dob);
        //        }
        //        catch (Exception e)
        //        {
        //            MessageBox.Show("Ngày sinh sai định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return false;
        //        }
        //        ProjectMember c = new ProjectMember(code, Service.Normalization(name), gender, address, DOB);
        //        return ProjectMemberDAL.Update(c);
        //    }

        //    public bool Delete(string code)
        //    {
        //        return ProjectMemberDAL.Delete(code);
        //    }
    }
}
