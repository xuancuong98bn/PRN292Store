using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Excercise
{
    class MyArray
    {
        public MyArray()
        {
            Console.Write("Enter number of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = GetArray(n);
            Display(arr);
            Console.WriteLine("Have {0} element(s) has index is not prime in array", CountNotPrimeIndex(arr));
            Console.WriteLine("Min of element is not square: {0}", MinNotSquare(arr));
            DNotPrimeSquareSort(arr);
        }

        //- Nhập mảng số nguyên gồm n phần tử
        public int[] GetArray(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter number {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        //- Hiện mảng số nguyên gồm n phần tử.
        public void Display(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
        }

        //- Đếm số lượng phần tử có chỉ số không phải là số nguyên tố.
        public int CountNotPrimeIndex(int[] arr)
        {
            int count = 0;
            MyFunc myFunc = new MyFunc();
            for (int i = 0; i < arr.Length; i++)
            {
                if (myFunc.IsPrime(i) == 0)
                {
                    count++;
                }
            }
            return count;
        }

        //- Tìm giá trị nhỏ nhất trong số các phần tử không phải là số chính phương.
        public int MinNotSquare(int[] arr)
        {
            int min = 1;
            MyFunc myFunc = new MyFunc();
            for (int i = 0; i < arr.Length; i++)
            {
                if (myFunc.IsSquare(arr[i]) == 0)
                {
                    if (min == 1)
                    {
                        min = arr[i];
                    }
                    else
                    {
                        min = min < arr[i] ? min : arr[i];
                    }
                }
            }
            return min;
        }

        //- Sắp xếp tăng dần những phần tử không phải là số chính phương cũng không phải là số nguyên tố trong mảng.
        public void DNotPrimeSquareSort(int[] arr)
        {
            ArrayList index = new ArrayList();
            List<int> list = new List<int>();
            MyFunc myFunc = new MyFunc();
            Console.WriteLine("List before sort:");
            Display(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if(myFunc.IsSquare(arr[i]) == 0 && myFunc.IsPrime(arr[i]) == 0)
                {
                    list.Add(arr[i]);
                    index.Add(i);
                }
            }
            list.Sort();
            int j = 0;
            for (int i = 0; i < index.Count; i++)
            {
                arr[(int)index[i]] = (int)list[j++];
            }
            Console.WriteLine("List after sort:");
            Display(arr);
        }
    }
}
