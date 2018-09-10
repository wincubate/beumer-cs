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

            Swap( ref a, ref b );

            Console.WriteLine( "Værdierne efter Swap(a,b) er: a = {0}, b = {1}", a, b );

            // Vat
            double[] ds = { 100.0, 695.0, 7500.0 };

            Vat( ds );

            foreach( double d in ds )
            {
                Console.WriteLine( d );
            }
        }

        static void Swap( ref int i, ref int j )
        {
            int temp = i;
            i = j;
            j = temp;
        }

        static void Vat( double[] prices )
        {
            for( int i = 0; i < prices.Length; i++ )
            {
                prices[ i ] *= 1.25;
            }
        }
    }
}
