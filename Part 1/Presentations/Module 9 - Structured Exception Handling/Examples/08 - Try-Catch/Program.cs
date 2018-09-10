using System;

namespace Wincubate.Module09.Slide08
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
            catch( FormatException exception )
            {
                Console.WriteLine( exception );
            }
        }
    }
}
