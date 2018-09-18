using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module05.Slide12
{
    class Program
    {
        static void Main( string[] args )
        {
            for( int i = 0; i < 1000; i++ )
            {
                A a = new A( i );
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            // Wait
            Console.ReadLine();
        }
    }
}
