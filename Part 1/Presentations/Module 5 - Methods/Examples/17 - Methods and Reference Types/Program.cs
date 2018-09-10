using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module05.Slide20
{
    class Program
    {
        static void Increment( int[] array )
        {
            for( int i = 0; i < array.Length; i++ )
            {
                array[ i ]++;
            }
        }

        static void Main( string[] args )
        {
            int[] myArray = { 42, 87, 112, 99, 208 };

            Increment( myArray );
            Console.WriteLine( myArray[ 1 ] );
        }
    }
}
