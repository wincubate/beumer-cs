using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambdas
{
    class Program
    {
        static bool FilterNameLengths( string s )
        {
            return s.Length >= 4;
        }

        static void Main( string[] args )
        {
            string[] names = { "Kim", "Mads", "Rasmus", "Bo", "Jesper" };

            // 1. Predicate
            string[] longNames1 = Array.FindAll( names, FilterNameLengths );
            foreach( string s in longNames1 )
            {
                Console.WriteLine( s );
            }

            // 2. Anonymous method
            string[] longNames2 = Array.FindAll( names, delegate( string s )
                                                       {
                                                           return s.Length >= 4;
                                                       }
            );
            foreach( string s in longNames2 )
            {
                Console.WriteLine( s );
            }

            // 3. Lambda expression
            string[] longNames3 = Array.FindAll( names, s => s.Length >= 4 );
            foreach( string s in longNames3 )
            {
                Console.WriteLine( s );
            }

            // 3': Filter and print with lambda expressions
            Array.ForEach( names, s => { if( s.Length >= 4 ) Console.WriteLine( s ); } );
        }
    }
}
