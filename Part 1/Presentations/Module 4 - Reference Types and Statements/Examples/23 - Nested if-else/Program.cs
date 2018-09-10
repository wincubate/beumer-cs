using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module04.Slide23
{
    class Program
    {
        static void Main( string[] args )
        {
            int i = 87;

            if( i > 100 )
            {
                Console.WriteLine( "i is really large" );
            }
            else if( i > 10 )
            {
                Console.WriteLine( "i is big" );
            }
            else if( i > 0 )
            {
                Console.WriteLine( "i is big" );
            }
            else
            {
                Console.WriteLine( "i is not much" );
            }

        }
    }
}
