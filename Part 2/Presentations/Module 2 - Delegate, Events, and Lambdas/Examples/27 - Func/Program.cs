using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module02.Slide27
{
   class Program
   {
      static void Main( string[] args )
      {
         Func<double> vat = () => 25.0;
         Console.WriteLine( "Denmarks VAT is {0}%", vat() );

         //Func<int,int,bool> lessThan = ( x, y ) => x < y;
         //int i = 42;
         //int j = 87;
         //Console.WriteLine( "{0} is {2}less than {1}",
         //   i,
         //   j,
         //   ( lessThan( i, j ) ? "" : "not " )
         //);
      }
   }
}
