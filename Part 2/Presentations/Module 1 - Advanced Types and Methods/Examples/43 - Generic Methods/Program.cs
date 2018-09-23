using System;

namespace Wincubate.Module01.Slide43
{
    class Program
    {
        static void Main( string[] args )
        {
            int i = 42;
            int j = 87;
            Swap( ref i, ref j );
            Console.WriteLine( "i = {0}. j = {1}", i, j );

            string s = "Hello";
            string t = "World";
            Swap( ref s, ref t );
            Console.WriteLine( "s = \"{0}\". t = \"{1}\"", s, t );
        }

        static void Swap<T>( ref T a, ref T b )
        {
            T temp = a;
            a = b;
            b = temp;

            Console.WriteLine( "You swapped two variables of type {0}", typeof( T ) );
        }
    }
}
