using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Wincubate.Module07.Slide11
{
    class Program
    {
        static void Main( string[] args )
        {
            IEnumerable<int> numbers = Enumerable.Range( 1, 100 );

            var even = from i in numbers //.AsParallel()
                       where Filter( i )
                       select i;

            foreach( int i in even )
            {
                Console.WriteLine( i );
            }
        }

        static private bool Filter( int i )
        {
            Random r = new Random();
            Thread.SpinWait( r.Next( 10000000 ) );

            return i % 2 == 0;
        }
    }
}
