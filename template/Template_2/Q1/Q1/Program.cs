using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student s = new Student("SE05715");
                s.InputInfo();
                Console.WriteLine(s.ToString());
                Console.ReadKey();
            }
            catch (IncorrectNameFormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
