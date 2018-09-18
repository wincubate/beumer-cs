using System;

namespace Wincubate.CS7.Slide19
{
    class Program
    {
        static void Main(string[] args)
        {
            _ = Add(42, 87);


        }

        static int Add( int x, int y )
        {
            Console.WriteLine( "Adding...");
            return x + y;
        }
    }
}
