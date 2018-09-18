using System;
using System.Collections.Generic;

namespace Wincubate.CS7.BasicTuplesLab
{
    class Program
    {
        static void Main( string[] args )
        {
            IEnumerable<decimal> numbers = new List<decimal>
            {
                4.2m, 8.7m, 17.6m, 11.2m, 25.5m, 7.5m, 11.0m
            };

            var (count, total) = Tally(numbers);
            Console.WriteLine( $"There are {count} elements with a total value of {total}");
        }

        static (int count, decimal total) Tally( IEnumerable<decimal> data )
        {
            (int count, decimal total) tuple = (0, 0);

            foreach (decimal i in data )
            {
                tuple.total += i;
                tuple.count++;
            }

            return tuple;
        }
    }
}