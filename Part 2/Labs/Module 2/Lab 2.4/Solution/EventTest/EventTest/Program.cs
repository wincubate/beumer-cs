using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{
   class Program
   {
      static void Main( string[] args )
      {
         IEnumerable<Tuple<int, int>> data = new List<Tuple<int, int>>
         {
            Tuple.Create( 5, 7 ),
            Tuple.Create( 1, 0 ),
            Tuple.Create( 2, 3 )
         };

         Publisher p = new Publisher();

         // TODO: Create subscribers for +, -, *, /
         Subscriber add = new Subscriber( "+", ( x, y ) => x + y, p );
         Subscriber sub = new Subscriber( "-", ( x, y ) => x - y, p );
         Subscriber mul = new Subscriber( "*", ( x, y ) => x * y, p );
         Subscriber div = new Subscriber( "/", ( x, y ) => x / y, p );

         p.Start( data );

         Console.ReadLine();
      }
   }
}
