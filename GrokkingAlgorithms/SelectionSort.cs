using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    public class SelectionSort
    {
        private int[] arr;
        private static Random random = new Random();
        public SelectionSort(int arrSize)
        {
            arr = new int[arrSize];
            for (int i = 0; i < arrSize; i++)
            {
                arr[i] = random.Next(1, 100);
                Console.Write(arr[i] + ", ");
            }
        }

        public void Sort()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                //first element's index within unsorted elements
                int minNumIndex = i;
                //compare the first element with the rest of the unsorted elements
                for (int j = i + 1; j < arr.Length; j++)
                {
                    //if one of the unsorted elements is smaller than the first element
                    if (arr[j] < arr[minNumIndex])
                    {
                        //minimal number index is j
                        minNumIndex = j;
                    }
                }
                //swapping the value of the first index and the minimal number value
                Swap(i, minNumIndex);
            }
            DisplaySortedArr(arr);
        }

        public void Swap(int first, int second)
        {
            int temporary = arr[first];
            arr[first] = arr[second];
            arr[second] = temporary;
        }

        public void DisplaySortedArr(int[] arr)
        {
            Console.WriteLine("\nSorted: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.ReadLine();
        }

        public void SortPractice()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minNumIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minNumIndex])
                    {
                        minNumIndex = j;
                    }
                }
                int temporary = arr[i];
                arr[i] = arr[minNumIndex];
                arr[minNumIndex] = temporary;
            }
            DisplaySortedArr(arr);
        }
    }
}
