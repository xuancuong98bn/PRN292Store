using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class IfDemo
    {
        public IfDemo()
        {
            Console.WriteLine("Using IfDemo");
        }

        public void TestNumber(int n)
        {
            if (n < 0)
            {
                Console.WriteLine(n + " is nagative number");
            } else if (n > 0)
            {
                Console.WriteLine(n + " is positive number");
            }
            else
            {
                Console.WriteLine(n + " is zero");
            }
        }

        public void Check7Last(int n)
        {
            string result = n % 10 == 7 ? n + " has last number is 7" : n + " has not last number is 7";
            Console.WriteLine(result);
        }

        public void CheckSquare(int n)
        {
            double d = Math.Sqrt(n);
            if (d % 1 == 0)
            {
                Console.WriteLine(n + " is quare of " + (int)d);
            }
            else
            {
                Console.WriteLine(n + " is not quare");
            }
        }
    }
}
