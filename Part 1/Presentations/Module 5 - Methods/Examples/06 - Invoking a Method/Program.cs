using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module05.Slide06
{
    class C
    {
        public static void M()
        {
            Console.WriteLine( "C.M() invoked" );
        }
    }

    class Program
    {
        static void Main()
        {
            C.M();

            // Wait for CR
            Console.ReadLine();
        }
    }
}
