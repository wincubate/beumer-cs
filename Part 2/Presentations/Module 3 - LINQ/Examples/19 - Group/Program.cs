using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module03.Slide19
{
   class Program
   {
      static void Main( string[] args )
      {
         int[] numbers = { 42, 87, 112, 176, 255 };

         var query = from i in numbers
                     group i by i % 2;

         foreach ( var group in query )
         {
            Console.WriteLine( group.Key );

            foreach ( var i in group )
            {
               Console.WriteLine( "\t" + i );
            }
         }

         //var query = from i in numbers
         //             group i by i % 2 into j
         //             select new
         //             {
         //                Remainder = j.Key,
         //                Numbers = j
         //             };
         //foreach ( var group in query )
         //{
         //   Console.WriteLine( group.Remainder );
         //   foreach ( var i in group.Numbers )
         //   {
         //      Console.WriteLine( "\t" + i );
         //   }
         //}
      }
   }
}
