using System;

namespace Wincubate.CS7x.Slide11
{
    class Program
    {
        static void Main( string[] args )
        {
            int x = 42;
            Twice(x);
            Console.WriteLine($"x={x}");
        }

        static void Twice( int x )
        {
            x = 2 * x;
        }
    }
}
