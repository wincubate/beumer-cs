using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module05.Slide12
{
    class A
    {
        public A( int x )
        {
            this.X = x;
            Counter++;

            Console.WriteLine( "There are now {0} Car objects", Counter );
        }
        ~A()
        {
            Counter--;

            Console.WriteLine( "There are now {0} Car objects", Counter );
        }

        public int X { get; }
        public static int Counter { get; set; } = 0;
    }
}
