using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module04.Slide09
{
    class Program
    {
        static void Main( string[] args )
        {
            int[] myArray = new int[ 5 ] { 42, 87, 112, 99, 208 };
            int[] myCopy = myArray;

            myArray[ 1 ] = 0;

            Console.WriteLine( myCopy[ 1 ] );
        }
    }
}
