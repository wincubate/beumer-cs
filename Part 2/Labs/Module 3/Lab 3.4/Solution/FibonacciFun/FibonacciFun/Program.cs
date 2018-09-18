using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciFun
{
    class Fibonacci : IEnumerable<BigInteger>
    {
        public IEnumerator<BigInteger> GetEnumerator()
        {
            BigInteger f1 = 1;
            BigInteger f2 = 1;

            yield return f1;
            yield return f2;

            while ( true )
            {
                BigInteger f = f1 + f2;
                yield return f;

                f1 = f2;
                f2 = f;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fib = new Fibonacci();

            var query = fib
                .Where(f => f % 4 == 0)
                .Take(25);

            foreach (var f in query)
            {
                Console.WriteLine( f );
            }
        }
    }
}
