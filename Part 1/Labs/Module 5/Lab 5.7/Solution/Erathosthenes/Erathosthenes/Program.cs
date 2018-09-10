using System;

namespace Erathosthenes
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine( "Indtast et tast, der er øvre grænse for søgningen af primtal: " );
            int number = int.Parse( Console.ReadLine() );

            // Compute the primes less than or equal to n
            Erathostenes( number );
        }

        static void Erathostenes( int n )
        {
            Console.WriteLine( "Primtallene mindre end {0} er:", n );

            // Create array of candidates to be examined
            int[] list = new int[ n + 1 ];

            // Initialize list from index 2 to n
            int count = 2;
            for( int i = 2; i <= n; i++ )
            {
                list[ i ] = count++;
            }

            // Start striking out numbers (set to 0) whenever they are multiples of the counter value i. 
            // Stop when the square of the counter value reaches the number specified
            for( int i = 2; ( i * i ) <= n; i++ )
            {
                for( int j = ( i * i ); j <= n; j = j + i )
                {
                    list[ j ] = 0;
                }
            }

            // Now go back through the array and look for the values not striken out.
            // Those will be exactly the prime numbers
            foreach( int p in list )
            {
                if( p != 0 )
                {
                    Console.WriteLine( p );
                }
            }
        }
    }
}
