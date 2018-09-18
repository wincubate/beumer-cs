using System;
using static System.Console;

namespace Wincubate.CS7x.Slide07
{
    class Program
    {
        static void Main( string[] args )
        {
            bool flag = false;
            int i = flag ? 87 : default(int);

            WriteLine(i);
        }

        static void DoStuff( int x, int y = default(int), bool z = default(bool) )
        {
            WriteLine($"x={x}\ty={y}\tz={z}");
        }
    }
}
