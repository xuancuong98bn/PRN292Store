using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exe_Student
{
    class Subject
    {
        public int id { get; set; }
        public string name { get; set; }

        public Subject()
        {

        }

        public Subject(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
