using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module02.Slide28
{
   class Program
   {
      static void Main( string[] args )
      {
         Action show = () => { Console.WriteLine( "Hello, world" ); };
         show();

         //Action<string,DateTime> showMessage = ( message, dt ) => { Console.WriteLine( dt + " : " + message ); };
         //showMessage( "Hello, world!", DateTime.Now );
      }
   }
}
