using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1
{
    class Student
    {
        public string code { get; set; }
        public string name { get; set; }
        public Student(string c)
        {
            code = c;
        }
        public void InputInfo()
        {
            Console.WriteLine("Input name of student, please. Student name must be less than or equal 15 characters");
            string name = Console.ReadLine();
            if(name.Length > 15)
            {
                throw new IncorrectNameFormatException();
            }
            else
            {
                this.name = name;
            }
        }
        public override string ToString()
        {
            return "Student Information : Code " + code + " -Name : " + name;

        }
    }
}
