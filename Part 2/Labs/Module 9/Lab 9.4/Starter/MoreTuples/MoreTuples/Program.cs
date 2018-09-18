using System;
using System.Collections.Generic;

namespace Wincubate.CS7.MoreTuplesLab
{
    class Program
    {
        static void Main( string[] args )
        {
            IEnumerable<object> numbers = new List<object>
            {
                4.2m, 8.7m, new object[]{ 17.6m, 11.2m, 25.5m }, 7.5m, new List<object>{ 11.0m }
            };

            var (count, total) = Tally(numbers);
            Console.WriteLine( $"There are {count} elements with a total value of {total}");
        }

        static (int count, decimal total) Tally( IEnumerable<object> data )
        {
            (int count, decimal total) tuple = (0, 0);

            // TODO

            return tuple;
        }
    }
}