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

            Console.WriteLine( "Indtast din vægt [kg]: " );
            string v = Console.ReadLine();
            double vægt = double.Parse( v );

            Console.WriteLine( "Indtast antal genstande: " );
            string g = Console.ReadLine();
            int genstande = int.Parse( g );

            double promille = ( 12 * genstande ) / ( k * vægt );
            Console.WriteLine( "Din promille er {0:f2}", promille );
        }
    }
}
