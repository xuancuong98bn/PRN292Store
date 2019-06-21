using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTL_PROJECT
{
    public class ProjectMember
    {
        public int EmployeeID { get; set; }
        public int ProjectID { get; set; }
        public string Position { get; set; }
        public bool IsFulltime { get; set; }
        public DateTime Date { get; set; }

        public ProjectMember()
        {
        }

        public ProjectMember(int employeeID, int projectID, string position, bool isFulltime, DateTime date)
        {
            EmployeeID = employeeID;
            ProjectID = projectID;
            Position = position;
            IsFulltime = isFulltime;
            Date = date;
        }
    }
}
