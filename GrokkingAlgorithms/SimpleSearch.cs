using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    public class SimpleSearch
    {
        public static int FindIndexBySimpleSearch(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (key == arr[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
