using System;
using static System.Console;

namespace Wincubate.CS7.Slide13
{
    class Program
    {
        static void Main(string[] args)
        {
            // ...


            #region Simple example

            int x = 42;
            ref int y = ref x;

            x = 87;
            WriteLine(y);

            #endregion
        }
    }
}
