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
            if (num <= 0) return 1;
            return num * FactorialByRecursion(num - 1);
        }
    }
}
