using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module04.Slide10
{
    class Program
    {
        static void Main( string[] args )
        {
            int[] myArray = { 42, 87, 112, 99, 208 };
            int[] myCopy = { 42, 87, 112, 99, 208 };

            Console.WriteLine( myArray == myCopy ); // ???
        }
    }
}
