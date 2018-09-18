using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module03.Slide40
{
   class Program
   {
      static void Main( string[] args )
      {
         Func<int, int, int> add = ( x, y ) => x + y;
         Console.WriteLine( add );
      }
   }
}
