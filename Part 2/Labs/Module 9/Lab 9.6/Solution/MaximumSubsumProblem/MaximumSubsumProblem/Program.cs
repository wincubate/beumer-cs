using System;
using System.Collections.Generic;
using System.Linq;
using static System.Math;

namespace Wincubate.CS7.MaximumSubsumProblemLab
{
    class Program
    {
        static void Main( string[] args )
        {
            IEnumerable<int> sequence = new List<int> { 2, -3, 7, 1, 4, -6, 9, -8 };

            int result = sequence
                .Aggregate(
                    (maxEndingHere: 0, maxSoFar: 0),
                    ( state, i ) => (
                        Max(i, state.maxEndingHere + i),
                        Max(state.maxSoFar, Max(i, state.maxEndingHere + i))
                    ),
                x => x.maxSoFar
            );

            Console.WriteLine( $"Maximum subsum is {result}");
        }
    }
}
