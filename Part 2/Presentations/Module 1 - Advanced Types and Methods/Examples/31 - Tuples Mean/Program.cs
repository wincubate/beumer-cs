using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module01.Slide31
{
   class Program
   {
      public static void Main()
      {
         Tuple<string, int?>[] scores = 
         {
            new Tuple<string, int?>( "Jack", 768 ),
            new Tuple<string, int?>( "Abbey", 592 ), 
            new Tuple<string, int?>( "Dave", 988 ),
            new Tuple<string, int?>( "Sam", 891 ), 
            new Tuple<string, int?>( "Ed", null ),
            new Tuple<string, int?>( "Penelope", 482 ),
            new Tuple<string, int?>( "Linda", 799 ),
            new Tuple<string, int?>( "Judith", 784 )
         };

         int number;
         double mean = ComputeMean( scores, out number );

         Console.WriteLine( "Average test score is {0:N2} (n={1})", mean, number );
      }

      private static double ComputeMean( Tuple<string, int?>[] scores, out int n )
      {
         n = 0;
         int sum = 0;
         foreach( var score in scores )
         {
            if( score.Item2.HasValue )
            {
               n += 1;
               sum += score.Item2.Value;
            }
         }

         if( n > 0 )
         {
            return sum / (double) n;
         }
         else
         {
            return 0;
         }
      }
   }
}