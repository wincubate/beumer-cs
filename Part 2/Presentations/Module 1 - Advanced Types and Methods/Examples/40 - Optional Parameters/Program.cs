using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module01.Slide40
{
    class Program
    {
        static void Main( string[] args )
        {
            FavoriteTeam( "Schalke 04", ConsoleColor.Blue, "Bundesliga" );
            FavoriteTeam( "Brøndby", ConsoleColor.Yellow );
            FavoriteTeam( "FCK" );

            // Hjørring
        }

        static void FavoriteTeam( string team, ConsoleColor color = ConsoleColor.White, string league = "Superliga" )
        {
            ConsoleColor old = Console.ForegroundColor;

            Console.ForegroundColor = color;
            Console.WriteLine( "I support {0} playing in the {1}", team, league );
            Console.ForegroundColor = old;
        }
    }
}
