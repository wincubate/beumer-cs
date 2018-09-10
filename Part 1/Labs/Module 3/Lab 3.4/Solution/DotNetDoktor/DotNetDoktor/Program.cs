using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetDoktor
{
    class Program
    {
        static void Main( string[] args )
        {
            // Time stamp for begyndelse af program
            DateTime begin = DateTime.Now;

            // Indtastning af køn
            Console.WriteLine( "Indtast dit køn ('m'/'k'): " );
            string s = Console.ReadLine();

            double k;
            if( s[ 0 ] == 'm' )
            {
                k = 0.68;
            }
            else
            {
                k = 0.55;
            }

            // Indtastning af vægt
            Console.WriteLine( "Indtast din vægt [kg]: " );
            string v = Console.ReadLine();
            double vægt = double.Parse( v );

            // Indtastning af antal genstande
            Console.WriteLine( "Indtast antal genstande: " );
            string g = Console.ReadLine();
            int genstande = int.Parse( g );

            // Beregning af promille
            double promille = ( 12 * genstande ) / ( k * vægt );
            ConsoleColor farve = Console.ForegroundColor;
            if( promille > 0.5 )
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine( "Din promille er {0:f2}", promille );
            Console.ForegroundColor = farve;

            // Time stamp for afslutning af program
            DateTime end = DateTime.Now;

            // Forløbet tid
            TimeSpan elapsed = end - begin;

            Console.WriteLine( "Programmet startede {0}", begin.ToString( "yyyy-MM-dd HH:mm:ss.fff" ) );
            Console.WriteLine( "Programmet kørte {0} millisekunder", elapsed.TotalMilliseconds );
        }
    }
}
