using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module05.Slide18
{
    class Program
    {
        static int Add( int x, int y )
        {
            return x + y;
        }
        static int Add( int x, int y, int z )
        {
            return x + y + z;
        }
        static double Add( double a, double b )
        {
            return a + b;
        }

        static void Main( string[] args )
        {
            Console.WriteLine( Add( 42, 87 ) );
            Console.WriteLine( Add( 42, 87, 112 ) );
            Console.WriteLine( Add( 9.7, 0.1 ) );
        }
    }
}
