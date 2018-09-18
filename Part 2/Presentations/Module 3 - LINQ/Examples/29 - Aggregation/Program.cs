using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module03.Slide29
{
   class Program
   {
      static void Main( string[] args )
      {
         int[] numbers = { 42, 87, 112, 176, 255 };

         var result = numbers.Aggregate( 1, ( product, i ) => product * i );
         Console.WriteLine( "The product of numbers is " + result );
      }
   }
}
