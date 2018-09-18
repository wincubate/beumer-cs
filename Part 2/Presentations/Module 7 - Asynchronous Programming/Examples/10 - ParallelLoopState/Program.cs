using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module07.Slide10
{
   class Program
   {
      static void Main(string[] args)
      {
         ParallelLoopResult result = Parallel.For(0, 1000, (i, state) =>
        {
           if (i == 87)
           {
              state.Break();
           }
           else
           {
              Console.WriteLine($"Executing number {i,4}...");
           }
        });

         if (result.IsCompleted == false && result.LowestBreakIteration.HasValue)
         {
            Console.WriteLine("Loop encountered a break at index {0}",
                result.LowestBreakIteration.Value);
         }
      }
   }
}
