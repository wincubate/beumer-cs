using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wincubate.Module07.Slide17
{
    public static class PrimeHelper
    {
        // Naive prime factoring :-)
        public static List<int> GetPrimeFactors(int n)
        {
            if (n < 2)
            {
                throw new ArgumentOutOfRangeException("Numbers less than 2 don't have prime factors");
            }

            List<int> result = new List<int>();

            int divisor = 2;

            while (divisor <= n)
            {
                if (n % divisor == 0)
                {
                    result.Add(divisor);
                    n /= divisor;
                }
                else
                {
                    divisor++;
                }

                Thread.SpinWait(300);
            }

            return result;
        }
    }
}
