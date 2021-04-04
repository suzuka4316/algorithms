using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    public class BinarySearch
    {
        public static int FindIndexByBinarySearch(int[] arr, int key)
        {
            int minIndex = 0;
            int maxIndex = arr.Length - 1;
            while (minIndex <= maxIndex)
            {
                int midIndex = (minIndex + maxIndex) / 2;
                if (key == arr[midIndex])
                {
                    return midIndex;
                }
                else if (key < arr[midIndex])
                {
                    maxIndex = midIndex - 1;
                }
                else
                {
                    minIndex = midIndex + 1;
                }
            }
            return -1;
        }
    }
}
