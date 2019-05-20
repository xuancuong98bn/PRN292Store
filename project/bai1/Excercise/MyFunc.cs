using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise
{
    class MyFunc
    {
        public MyFunc()
        {
            //int[] arr = Input(5);
            //ShowPrime(arr);
            //ShowSquare(arr);
            //ShowFactorNotPrimeSquare(arr);
            //ShowMaxOf(arr);
            //ShowMinOf(arr);
            //CalSumOfFactor();
            //FindGCD(arr);
            //FindLCM(arr);
            int n = Input(0, 10);
            Console.WriteLine("S = " + SumOfEquation(n));
            DisplayIsoscelesTriangle(n);
            Console.WriteLine("Number of prime in ({0},{1}) is {2}", 20, 60, CountPrime2Digit(20, 60));
            Console.WriteLine("Sum of odd square from 1 to {0} is {1}", n, SumOddSquareTo(n));
        }

        /*Function Excercise paragraph 5*/
        //- Kiểm tra một số nguyên có phải là số nguyên tố. (trả về 1 nếu là đúng,0 là sai).
        public int IsPrime(int n)
        {
            if (n >= 2)
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) return 0;
                }
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //- Kiểm tra một số nguyên có phải là số chính phương. (trả về 1 nếu là đúng,0 là sai).
        public int IsSquare(int n)
        {
            double d = Math.Sqrt(n);
            return d % 1 == 0 ? 1 : 0;
        }

        //- Tìm ước chung lớn nhất của 2 số nguyên. (trả về)
        public int GCD(int a, int b)
        {
            if (b == 0) return a;
            return GCD(b, a % b);
        }

        //- Tìm bội chung nhỏ nhất của 2 số nguyên. (trả về)
        public int LCM(int a, int b)
        {
            return a * b / GCD(a, b);
        }

        //- Tính giai thừa. (trả về)
        public int Factorial(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }
            return f;
        }

        //- Tìm giá trị nhỏ nhất trong 2 số nguyên. (trả về)
        public int MinOf(int a, int b)
        {
            return a < b ? a : b;
        }

        //- Tìm giá trị lớn nhất trong 2 số nguyên. (trả về)
        public int MaxOf(int a, int b)
        {
            return a > b ? a : b;
        }

        /*Function Excercise paragraph 6*/
        //- Hàm kiểm tra số nguyên tố.
        //- Hàm kiểm tra số chính phương.
        //- Hàm tính giai thừa.
        //- Hàm tính S = 1 / 2! + 1/4! + … + 1/(2n)!
        public double SumOfEquation(int n)
        {
            double sum = 0.00;
            for (int i = 1; i <= n; i++)
            {
                sum += 1 / (double)Factorial(2 * i);
            }
            return sum;
        }
        //- Hàm hiện tam giác cân hình sao với số hàng = n truyền vào.
        public void DisplayIsoscelesTriangle(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(GetStart(i).PadLeft(n+i, ' '));
            }
        }

        private string GetStart(int n)
        {
            string str = "";
            for (int i = 0; i < 2 * n + 1; i++)
            {
                str += "*";
            }
            return str;
        }

        //- Hàm đếm số lượng số nguyên tố có 2 chữ số
        public int CountPrime2Digit(int from, int to)
        {
            int count = 0;
            for (int i = from; i <= to; i++)
            {
                if (IsPrime(i) == 1)
                {
                    count++;
                    //Console.Write(i + "\t");
                }
            }
            return count;
        }

        //- Hàm tính tổng các số chính phương lẻ từ 1 đến n
        public int SumOddSquareTo(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (IsSquare(i) == 1 && i % 2 == 1)
                {
                    sum += i;
                }
            }
            return sum;
        }

        //--------------------------------------------------
        public int[] Input(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter number {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        public void ShowPrime(int[] arr)
        {
            Console.WriteLine("Prime numbers in list:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]) == 1)
                {
                    Console.Write(arr[i] + "\t");
                }
            }
            Console.WriteLine();
        }

        public void ShowSquare(int[] arr)
        {
            Console.WriteLine("Square numbers in list:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsSquare(arr[i]) == 1)
                {
                    Console.Write(arr[i] + "\t");
                }
            }
            Console.WriteLine();
        }

        public void ShowFactorNotPrimeSquare(int[] arr)
        {
            Console.WriteLine("Factorial of number is not prime and square :");
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]) == 0 && IsSquare(arr[i]) == 0)
                {
                    Console.WriteLine("{0}! = {1}", arr[i], Factorial(arr[i]));
                }
            }
        }

        public void ShowMaxOf(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                max = MaxOf(max, arr[i]);
            }
            Console.WriteLine("Max of list number is " + max);
        }

        public void ShowMinOf(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                min = MinOf(min, arr[i]);
            }
            Console.WriteLine("Min of list number is " + min);
        }

        public void CalSumOfFactor()
        {
            int n;
            do
            {
                n = Input(1)[0];
                if (IsSquare(n) == 1)
                {
                    break;
                }
                Console.WriteLine("You must enter square number");
            } while (true);
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Factorial(2 * i - 1);
            }
            Console.WriteLine("S = 1! + ... + {0}! = {1}", 2 * n - 1, sum);
        }

        public void FindGCD(int[] arr)
        {
            int a = 0, b = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]) == 0)
                {
                    a = a == 0 ? arr[i] : b;
                    b = a == 0 ? 0 : arr[i];
                    if (a != 0 && b != 0)
                    {
                        b = GCD(a, b);
                    }
                }
            }
            Console.WriteLine("Greatest Common Divisor of list is " + b);
        }

        public void FindLCM(int[] arr)
        {
            int a = 0, b = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]) == 0)
                {
                    a = a == 0 ? arr[i] : b;
                    b = a == 0 ? 0 : arr[i];
                    if (a != 0 && b != 0)
                    {
                        b = LCM(a, b);
                    }
                }
            }
            Console.WriteLine("Least Common Multiple of list is " + b);
        }

        public int Input(int from, int to)
        {
            int n = 0;
            do
            {
                Console.Write("Enter number: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n >= to || n <= from)
                {
                    Console.WriteLine("Number must from {0} to {1}", from, to);
                }
                else
                {
                    break;
                }
            } while (true);
            return n;
        }
    }
}
