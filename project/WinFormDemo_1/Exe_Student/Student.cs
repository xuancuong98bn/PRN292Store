using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Exe_Student
{
    class Student
    {
        public string code { get; set; }
        public string name { get; set; }
        public int idSubject { get; set; }
        public int mark { get; set; }

        public Student()
        {
        }

        public Student(string code, string name, int idSubject, int mark)
        {
            this.code = code;
            this.name = name;
            this.idSubject = idSubject;
            this.mark = mark;
        }

        public override string ToString()
        {
            return code + "\t" + name + "\t" + idSubject + "\t" + mark;
        }
    }
}
