using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module05.Slide11
{
    class Program
    {
        static void Twice( int x )
        {
            x = 2 * x;
        }

        static void Main()
        {
            int i = 42;
            Twice( i );
            Console.WriteLine( i );
        }
    }
}
