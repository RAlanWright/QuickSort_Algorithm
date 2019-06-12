using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Implementation of Quick Sort algorithm in C# 
 * Generates an array of random integers
 * Outputs the randomized array
 * Performs quick sort on the array
 * Outputs the sorted array
 */


namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] SortList = new int[100];
            byte i = 0;
            Random random = new Random();
            bool addToArray = true;
            while (i < 100)
            {
                int randomNumber = random.Next(1, 101);
                addToArray = true;
                for (int j = 0; j < i; j++)
                {
                    if (SortList[j] == randomNumber)
                    {
                        addToArray = false;
                        break;
                    }
                }
                if (addToArray == true)
                {
                    SortList[i] = randomNumber;
                    i++;
                }
            }
            Console.WriteLine(Environment.NewLine + "Unsorted: " + Environment.NewLine);
            int count = 1;
            foreach (int k in SortList)
            {
                if (count == SortList.Length)
                {
                    Console.Write($"{k}. ");  // Add period at the end
                }
                else
                {
                    Console.Write($"{k}, ");  // Add comma after each item
                    count++;
                }
            }
            Console.WriteLine(Environment.NewLine + Environment.NewLine + "Press ENTER");
            Console.ReadLine();
            quickSort(SortList, 0, SortList.Length - 1);
            Console.WriteLine("Sorted: " + Environment.NewLine);
            foreach (int m in SortList)
            {
                if (m == SortList.Length)
                {
                    Console.Write($"{m}. ");  // Add period at the end of SortList
                }
                else
                {
                    Console.Write($"{m}, ");  // Add period after each item in SortList
                }
            }
            Console.WriteLine(Environment.NewLine + Environment.NewLine);
        }


        public static void quickSort(int[] SortList, int left, int right)
        {
            int l = left;
            int r = right;
            int Pivot = SortList[(l + r) / 2];

            while (l <= r)  // loop until l is equal to r
            {
                while (SortList[l] < Pivot) // move l up one
                {
                    l++;
                }
                while (Pivot < SortList[r]) // move r down one
                {
                    r--;
                }
                if (l <= r) // swapping numbers
                {
                    int temp = SortList[l];
                    SortList[l] = SortList[r];
                    SortList[r] = temp;
                    l++;
                    r--;
                }
                if (left < r)
                {
                    quickSort(SortList, left, r);  // call quickSort
                }
                if (l < right)
                {
                    quickSort(SortList, l, right);
                }
            }
        }
    }
}
