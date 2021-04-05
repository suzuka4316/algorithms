using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    public class Quicksort
    {
        //1. Set a pivot from array
        //2. Find a smaller value than pivot on the left side
        //3. Find a larger value than pivot on the right side
        //4. Swap the 2 values
        //5. Repeat 2 - 4 to collect smaller values to the left and larger values on the right
        //6. Repeat 1 - 5 recursively for the left and right sides
        
        public static int[] Sort(int[] arr, int left, int right)
        {
            /**************** Base case ******************/
            if (right - left <= 0) return arr;

            /**************** Recursive case ******************/
            int pivot = GetPivot(arr, left, right);

            int l = left;
            int r = right;

            while (true)
            {
                //increment left index while the element is smaller than pivot
                while (arr[l] < pivot) l++;
                //decrement right index while the element is larger than pivot
                while (pivot < arr[r]) r--;
                if (l >= r) break;

                //swap the left value and right value
                int temporary = arr[l];
                arr[l] = arr[r];
                arr[r] = temporary;
            }
            //sort the left side
            Sort(arr, left, l - 1);
            //sort the right side
            Sort(arr, r + 1, right);
            return arr;
        }


        /// <summary>
        /// Get a median from 3 values.
        /// { 4, ..., 2, ..., 9 }
        /// It returns 4 in the example above.
        /// </summary>
        static int GetPivot(int[] arr, int l, int r)
        {
            int mid = l + (r - l) / 2;
            int min = Math.Min(arr[l], arr[r]);
            int max = Math.Max(arr[l], arr[r]);
            if (arr[mid] < min) return min;
            if (arr[mid] > max) return max;
            return arr[mid];
        }
    }
}
