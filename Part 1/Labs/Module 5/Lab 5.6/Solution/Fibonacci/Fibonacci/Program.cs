using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine( "Indtast nummer på det ønskede Fibonacci-tal: " );
            int number = int.Parse( Console.ReadLine() );

            //Console.WriteLine( "Det {0}. Fibonacci-tal er {1}", number, Fib( number ) );
            Console.WriteLine( "Det {0}. Fibonacci-tal er {1}", number, IterativeFib( number ) );
        }

        static int Fib( int n )
        {
            if( n <= 0 )
            {
                return 0;
            }
            else if( n == 1 )
            {
                return 1;
            }
            else
            {
                return Fib( n - 2 ) + Fib( n - 1 );
            }
        }

        static int IterativeFib( int n )
        {
            if( n < 0 )
            {
                throw new ArgumentException( "Input must be nonnegative!" );
            }

            int[] sequence = new int[ n + 1 ];

            sequence[ 0 ] = 0;

            if( n > 0 )
            {
                sequence[ 1 ] = 1;
            }

            for( int i = 2; i < n + 1; i++ )
            {
                sequence[ i ] = sequence[ i - 2 ] + sequence[ i - 1 ];
            }

            return sequence[ n ];
        }
    }
}
