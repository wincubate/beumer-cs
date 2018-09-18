using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module01.Slide41
{
    class Program
    {
        static void Main( string[] args )
        {
            //FavoriteTeam( "Schalke 04", ConsoleColor.Blue, "Bundesliga" );
            //FavoriteTeam( "Brøndby", ConsoleColor.Yellow );
            //FavoriteTeam( "FCK" );

            // AGF?
            FavoriteTeam( "Hjørring", league: "1. division" );

            //Bizarre( x4: 87 );
        }

        static void FavoriteTeam( string team, ConsoleColor color = ConsoleColor.White, string league = "Superliga" )
        {
            ConsoleColor old = Console.ForegroundColor;

            Console.ForegroundColor = color;
            Console.WriteLine( "I support {0} playing in the {1}", team, league );
            Console.ForegroundColor = old;
        }

        static void Bizarre( int x0 = 0, int x1 = 1, int x2 = 2, int x3 = 3, int x4 = 4, int x5 = 5 )
        {
            Console.WriteLine( "(x0,x1,x2,x3,x4,x5) = ({0},{1},{2},{3},{4},{5})", x0, x1, x2, x3, x4, x5 );
        }
    }
}
