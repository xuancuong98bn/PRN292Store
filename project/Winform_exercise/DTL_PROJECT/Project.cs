using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTL_PROJECT
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Project()
        {

        }

        public Project(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
