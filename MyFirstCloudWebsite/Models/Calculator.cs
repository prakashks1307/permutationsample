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
            var nFact = GetFactorial(value.N);
            if (nFact >= Int32.MaxValue)
                throw new Exception("Result is too large.");
            var nrFact = GetFactorial(value.N - value.R);
            return nFact / nrFact;
        }

        public static int GetCombination(InputValues value)
        {
            return GetFactorial(value.N) / (GetFactorial(value.R) * GetFactorial(value.N - value.R));
        }

        private static int GetFactorial(int? n)
        {
            if (n.HasValue)
            {
                var factResult = (n <= 0) ? 1 : n.Value * GetFactorial(n.Value - 1);
                if (n.Value > 10 && factResult % 100 != 0)
                    throw new Exception("Result is too large to calculate.");
                return factResult;
            }
            return 1;
        }
    }
}