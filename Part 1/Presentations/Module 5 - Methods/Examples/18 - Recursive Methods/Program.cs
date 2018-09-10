using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module05.Slide21
{
    class Program
    {
        static int Factorial( int n )
        {
            if( n <= 1 )
            {
                return 1;
            }

            return n * Factorial( n - 1 );
        }

        static void Main()
        {
            Console.WriteLine( Factorial( 10 ) );
        }
    }
}
