using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class ForDemo
    {
        public ForDemo()
        {
            Console.WriteLine("Using ForDemo");
        }

        //ktra so nguyen to
        public void Prime(int n)
        {
            if (IsPrime(n))
            {
                Console.WriteLine(n + " is prime");
            }
            else
            {
                Console.WriteLine(n + " is not prime");
            }
        }

        //bn so nguyen to tu 1 den n
        public void CPrime(int n)
        {
            Console.WriteLine("Has " + CountPrime(n) + " number(s) is prime from 1 to " + n);
        }

        //tinh n!
        public void RFactorial(int n)
        {
            Console.WriteLine(n + "! = " + Factorial(n));
        }

        //tinh 1! + 2! +..+(2n-1)!
        public void RSFactorial(int n)
        {
            Console.WriteLine("S = 1!+ ... +" + (2*n - 1) + "! = " + SumFactorial(n));
        }

        public bool IsPrime(int n)
        {
            if (n == 2 || n == 3) { return true; }
            if (n > 3)
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private int CountPrime(int n)
        {
            int count = 0;
            for (int i = 2 ; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    count++;
                }
            }
            return count;
        }

        private int Factorial(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }
            return f;
        }

        private int SumFactorial(int n)
        {
            int sum = 0;
            for (int i = 1; i < 2*n; i++)
            {
                sum += Factorial(i);
            }
            return sum;
        }
    }
}
