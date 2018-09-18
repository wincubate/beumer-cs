using System;

namespace Wincubate.CS7x.Slide17
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 42;
            int y = 87;
            bool b = false;

            ref int z = ref (b ? ref x : ref y);

            z = 112;

            Console.WriteLine( $"x={x}, y={y}, z={z}");
        }
    }
}
