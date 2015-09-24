using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstCloudWebsite.Models
{
    public static class Calculator
    {
        public static int GetPermutation(Permutation permutation)
        {
            return GetFactorial(permutation.N) / GetFactorial(permutation.N - permutation.R);
        }

        private static int GetFactorial(int n)
        {
            if (n <= 0)
                return 1;
            else
                return n * GetFactorial(n - 1);
        }
    }
}