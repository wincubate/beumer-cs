using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module01.Slide31
{
   class Program
   {
      static void Main( string[] args )
      {
         Tuple<int, int> point1 = Tuple.Create( 1, 3 );
         Tuple<int, int> point2 = Tuple.Create( 2, 2 );
         Tuple<int, int> point3 = Tuple.Create( 1, 4 );

         //Console.WriteLine( "The point is {0}", point1 );

         //Console.WriteLine( point1.Equals( point2 ) );
         //Console.WriteLine( ( point1 as IComparable ).CompareTo( point2 ) );
      }
   }
}
