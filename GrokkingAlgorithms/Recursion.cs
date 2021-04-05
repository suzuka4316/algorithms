using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    public class Recursion
    {
        public static int FactorialByLoop(int num)
        {
            if (num <= 0) return 1;
            int factorial = 1;
            for (int i = num; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        public static int FactorialByRecursion(int num)
        {
            //base case -- for stopping the loop
            if (num <= 0) return 1;
            //recursive case
            return num * FactorialByRecursion(num - 1);
        }

        public static int AdditionByLoop(int[] arr)
        {
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total = total + arr[i];
            }
            return total;
        }

        //int[] arr = new int[3] { 2, 4, 6 };
        public static int AdditionByRecursion(int[] arr, int count)
        {
            if (count <= 0 || count > arr.Length) return 0;
            return AdditionByRecursion(arr, count - 1) + arr[count - 1];
        }

        //public static int CountByRecursion(int[] arr)
        //{
        //    if (arr == null || arr.Length == 0) return 0;
        //    return CountByRecursion(arr) + arr.Length - 1;
        //}
    }
}
