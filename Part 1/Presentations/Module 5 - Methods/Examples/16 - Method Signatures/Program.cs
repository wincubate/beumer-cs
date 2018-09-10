using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module05.Slide19
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

        static void M( int x )
        {
            x = 87;
        }

        static void M( ref int x )
        {
            x = 87;
        }

        static void Main( string[] args )
        {
        }
    }
}
