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
         int dividend, divisor;
         Tuple<int, int> result;

         dividend = 136945;
         divisor = 178;
         result = IntegerDivide( dividend, divisor );
         if( result != null )
         {
            Console.WriteLine( @"{0} \ {1} = {2}, remainder {3}",
               dividend,
               divisor,
               result.Item1,
               result.Item2 );
         }
         else
         {
            Console.WriteLine( @"{0} \ {1} = <Error>",
               dividend,
               divisor );
         }

         dividend = int.MaxValue;
         divisor = -2073;
         result = IntegerDivide( dividend, divisor );
         if( result != null )
         {
            Console.WriteLine( @"{0} \ {1} = {2}, remainder {3}",
               dividend,
               divisor,
               result.Item1,
               result.Item2 );
         }
         else
         {
            Console.WriteLine( @"{0} \ {1} = <Error>",
               dividend,
               divisor );
         }
      }

      private static Tuple<int, int> IntegerDivide( int dividend, int divisor )
      {
         try
         {
            int remainder;
            int quotient = Math.DivRem( dividend, divisor, out remainder );
            
            return new Tuple<int, int>( quotient, remainder );
         }
         catch( DivideByZeroException )
         {
            return null;
         }
      }
   }
}
