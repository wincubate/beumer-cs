using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module01.Slide07
{
    class Program
    {
        static void Main( string[] args )
        {
            int? i = 87;
            int? j = null;
            if( i.HasValue )
            {
                int k = i.Value + ( j.GetValueOrDefault( 42 ) );
                Console.WriteLine( k );
            }
        }
    }
}
