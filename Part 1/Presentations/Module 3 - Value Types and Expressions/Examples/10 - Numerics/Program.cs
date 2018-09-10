using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Wincubate.Module03.Slide10
{
    class Program
    {
        static void Main( string[] args )
        {
            BigInteger bigFactor = new BigInteger( 87 );
            BigInteger bigInteger = BigInteger.Parse( "999999999999999999999999999999999999999999999999999999999999" );
            BigInteger bigNumber = bigFactor * bigInteger;
            Console.WriteLine( bigNumber );
        }
    }
}
