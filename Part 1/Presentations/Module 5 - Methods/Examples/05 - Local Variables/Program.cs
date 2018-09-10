using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module05.Slide05
{
    class Program
    {
        static int numItems = 0;

        static void Method1()
        {
            int numItems = 42;
            Console.WriteLine( numItems );
        }

        static void Method2()
        {
            int numItems = 87;
            Console.WriteLine( numItems );
        }

        static void Main( string[] args )
        {
            Console.WriteLine( numItems );
        }
    }
}
