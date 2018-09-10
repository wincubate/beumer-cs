using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwapTest
{
    class Program
    {
        static void Main( string[] args )
        {
            int a = 42;
            int b = 87;

            Console.WriteLine( "Værdierne før Swap(a,b) er: a = {0}, b = {1}", a, b );

            Swap( a, b );

            Console.WriteLine( "Værdierne efter Swap(a,b) er: a = {0}, b = {1}", a, b );
        }

        static void Swap( int i, int j )
        {
        }
    }
}
