using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class ArrDemo
    {
        public ArrDemo()
        {
            Console.WriteLine("Using Array");
        }

        //bn so chia het cho 2, khong chia het cho 2
        public void CountDevided2(int[] arr)
        {
            arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int devide = 0;
            int notDevide = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                devide += arr[i] % 2 == 0 ? 1 : 0;
                notDevide += arr[i] % 2 != 0 ? 1 : 0;
            }
            Console.WriteLine("Has " + devide + " number devided 2");
            Console.WriteLine("Has " + notDevide + " number not devided 2");
        }

        //hien thi so chan trong mang
        public void DisplayEven(int[] arr)
        {
            Console.WriteLine("List of event in array:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + "\t");
                }
            }
            Console.WriteLine();
        }

        //tinh tong cac so chinh phuong
        public void SumPrime(int[] arr)
        {
            int sum = 0;
            ForDemo forDemo = new ForDemo();
            for (int i = 0; i < arr.Length; i++)
            {
                if (forDemo.IsPrime(arr[i]))
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine("Sum of prime numbers in array: " + sum);
        }

        //tb ca co co chi so le
        public void AverageOddIndex(int[] arr)
        {
            int sumOI = 0;
            for (int i = 1; i < arr.Length; i += 2)
            {
                sumOI += arr[i];
            }
            Console.WriteLine("Average of numbers in Odd index in array: " + sumOI / (arr.Length / 2));
        }

        //max trong so phan tu chia het cho 3
        public void MaxNumberDevide3(int[] arr)
        {
            int max = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0)
                {
                    if (max == 1)
                    {
                        max = arr[i];
                    }
                    else
                    {
                        max = max > arr[i] ? max : arr[i];
                    }
                }
            }
            if (max != 1)
            {
                Console.WriteLine("Max number devide 3 in array: " + max);
            }
            else
            {
                Console.WriteLine("No number devide 3");
            }
        }

        private void Display(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
        }
        //sap xep mang tang dan cac phan tu chan
        public void DSort(int[] arr)
        {
            ArrayList odd = new ArrayList();
            ArrayList even = new ArrayList();
            Console.WriteLine("List before sort:");
            Display(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(arr[i]);
                }
                else
                {
                    odd.Add(arr[i]);
                }
            }
            even.Sort();
            for (int i = 0; i < arr.Length; i += 2)
            {
                arr[i] = (int)even[i / 2];
            }
            Console.WriteLine("List after sort:");
            Display(arr);
        }

        public void DEvenElementSort(int[] arr)
        {
            ArrayList index = new ArrayList();
            List<int> even = new List<int>();
            Console.WriteLine("List before sort:");
            Display(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even.Add(arr[i]);
                    index.Add(i);
                }
            }
            even.Sort();
            int j = 0;
            for (int i = 0; i < index.Count; i++)
            {
                arr[(int)index[i]] = (int)even[j++];
            }
            Console.WriteLine("List after sort:");
            Display(arr);
        }

        //co bn phan tu chan trong mang tinh den so nguyen to dau tien
        public void CountEvenToPrime(int[] arr)
        {
            ForDemo forDemo = new ForDemo();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (forDemo.IsPrime(arr[i]))
                {
                    break;
                }
                if (arr[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Has " + count + " even number to first prime in array");
        }
    }
}
