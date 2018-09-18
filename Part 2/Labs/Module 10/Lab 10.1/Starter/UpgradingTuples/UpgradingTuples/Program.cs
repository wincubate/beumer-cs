using System;
using static System.Console;

namespace UpgradingTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            (int x, int y) tuple = (8, 4);
            var other = (a: 8, b: 4);

            WriteLine( tuple == other );
        }
    }
}
