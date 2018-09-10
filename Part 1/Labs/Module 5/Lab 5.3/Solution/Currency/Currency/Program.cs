using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Currency
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine( ComputeCurrency( 50, 5.7781 ) );

            // Optional a)
            Console.WriteLine( ComputeCurrency( 200, 8.9011 ) );

            // Optional b)
            Console.WriteLine( ComputeCurrency( 50 ) );

            // Optional c)
            Console.WriteLine( ComputeCurrency() );

            // Named a)
            Console.WriteLine( ComputeCurrency( rate: 8.9011 ) );
        }

        static string ComputeCurrency( double amount = 100.00, double rate = 7.452 )
        {
            return string.Format( "{0:c}", amount * rate );
        }
    }
}
