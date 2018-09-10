using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module04.Slide34
{
    class Program
    {
        static void Main( string[] args )
        {
            int i = 42;

            if( i == 42 )
            {
                goto Mol;
            }
            goto End;
        Mol:
            Console.WriteLine( 42 );
            goto End;
        End:
            Console.WriteLine( "Done! :-)" );
        }
    }
}
