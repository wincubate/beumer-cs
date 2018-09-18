using System;
using static System.Console;

namespace Wincubate.CS7x.Slide24
{
    class Program
    {
        static void Main( string[] args )
        {
            // ...

            #region Simple Example

            int x = 42;
            int y = 87;
            ref int z = ref x;

            x = 112;
            WriteLine($"z = {z}");

            z = ref y;
            //y = 176;
            WriteLine($"z = {z}");

            #endregion
        }
    }
}
