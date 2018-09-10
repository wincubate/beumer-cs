using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetDoktor
{
    enum Gender
    {
        Male,
        Female
    }

    class Program
    {
        static void Main( string[] args )
        {
            // Indtastning af køn
            Console.WriteLine( "Indtast dit køn ('m'/'k'): " );
            string s = Console.ReadLine();

            double k;
            Gender gender;
            if( s[ 0 ] == 'm' )
            {
                gender = Gender.Male;
            }
            else
            {
                gender = Gender.Female;
            }

            // Indtastning af vægt
            Console.WriteLine( "Indtast din vægt [kg]: " );
            string v = Console.ReadLine();
            double vægt = double.Parse( v );

            // Beregning af konstanter og forbrænding
            double forbrænding;
            if( gender == Gender.Male )
            {
                k = 0.68;
                forbrænding = 0.151 / k;
            }
            else
            {
                k = 0.55;
                forbrænding = 0.097 / k;
            }

            // Indtastning af antal genstande
            Console.WriteLine( "Indtast antal genstande: " );
            string g = Console.ReadLine();
            int genstande = int.Parse( g );

            int timer = 0;
            double promille = ( 12 * genstande ) / ( k * vægt );
            while( promille >= 0.0 )
            {
                ConsoleColor farve = Console.ForegroundColor;
                if( promille > 0.5 )
                {
                    farve = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                // Udskriv selve teksten (i rød hvis promillen stadig er over 0.5)
                Console.WriteLine( "Din promille efter {0} timer er {1:f2}", timer, promille );

                if( promille >= 0.5 )
                {
                    Console.ForegroundColor = farve;
                }

                // Beregning af promille
                promille = promille - forbrænding;

                timer++;
            }
        }
    }
}
