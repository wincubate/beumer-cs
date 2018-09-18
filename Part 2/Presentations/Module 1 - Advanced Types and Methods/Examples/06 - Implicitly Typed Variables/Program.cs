using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module01.Slide06
{
   class Program
   {
      static void Main( string[] args )
      {
         var myInteger = 87;
         var myBoolean = true;
         var myString = "Hello, there...";

         Console.WriteLine( "myInteger is a {0}", myInteger.GetType().Name );
         Console.WriteLine( "myBoolean is a {0}", myBoolean.GetType().Name );
         Console.WriteLine( "myString is a {0}", myString.GetType().Name );
      }
   }
}
