using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            /************** Selection Sort **************/
            //SelectionSort a = new SelectionSort(5);
            //a.SortPractice();

            int[] arr = new int[10] { 1, 6, 9, 15, 69, 71, 78, 89, 99, 102 };

            /************** Simple Search **************/
            //int key = 15;
            //int index = SimpleSearch.FindIndexBySimpleSearch(arr, key);
            //if (index < 0) Console.WriteLine($"{key} not found in the array");
            //else Console.WriteLine($"{key} found at index {index}");

            /************** Binary Search **************/
            //int key = 89;
            //int index = BinarySearch.FindIndexByBinarySearch(arr, key);
            //if (index < 0) Console.WriteLine($"{key} not found in the array");
            //else Console.WriteLine($"{key} found at index {index}");

            /************** Recursion **************/
            //Console.Write("Enter a positive number: ");
            //int num = int.Parse(Console.ReadLine());
            //int factorial = Recursion.FactorialByRecursion(num);
            //Console.WriteLine($"Factorial of {num} is {factorial}");

            //Console.WriteLine($"Addition of the array is {Recursion.AdditionByLoop(arr)}");
            //Console.WriteLine($"Addition of the array is {Recursion.AdditionByRecursion(arr, 10)}");

            int[] arr1 = new int[10] { 58, -2, 5, 89, 78, 105, -16, 257, 19, 57 };
            int[] newArr = Quicksort.Sort(arr1, 0, arr.Length - 1);
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
