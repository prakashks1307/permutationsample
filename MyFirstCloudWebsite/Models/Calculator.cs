using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstCloudWebsite.Models
{
    public static class Calculator
    {
        public static int GetPermutation(InputValues value)
        {
            return GetFactorial(value.N) / GetFactorial(value.N - value.R);
        }

        public static int GetCombination(InputValues value)
        {
            return GetFactorial(value.N) / (GetFactorial(value.R) * GetFactorial(value.N - value.R));
        }

        private static int GetFactorial(int? n)
        {
            if (n.HasValue)
            {
                if (n <= 0)
                    return 1;
                else
                    return n.Value * GetFactorial(n.Value - 1);
            }
            return 1;
        }
    }
}