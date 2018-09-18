using System;
using static System.Console;

namespace Wincubate.CS7x.Slide23
{
    class Program
    {
        static void Main( string[] args )
        {
            var t0 = (4, 8);

            var t1 = (a: 8, b: 4);
            var t2 = (8, 4);
            (int x, int y) t3 = (8, 4);
            (double p, double q) t4 = (8, 4);

            WriteLine(t0 != t1);

            WriteLine(t1 == t2);
            WriteLine(t1 == t3);
            WriteLine(t2 == t3);
            WriteLine(t3 == t4);
        }
    }
}
