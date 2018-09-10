using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module09.Slide17
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine( "Enter a number: " );
                int i = int.Parse( Console.ReadLine() );
                Console.WriteLine( "You entered the number {0}", i );
            }
            catch( OverflowException )
            {
                Console.WriteLine( "Cannot deal with overflow here! :-(" );
                throw;
            }

            Console.ReadLine();
        }
    }
}
