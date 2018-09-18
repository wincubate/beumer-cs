using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module03.Slide25
{
    class Program
    {
        #region Reflect Over Query
        static void ReflectOverQueryResults( object query )
        {
            Console.WriteLine();
            Console.WriteLine( "Query is of type: {0}", query.GetType().Name );
            Console.WriteLine( "Query location: {0}", query.GetType().Assembly );
        }
        #endregion

        static void Main( string[] args )
        {
            string[] wiiGames =
            {
                "Super Mario Galaxy", 
                "FIFA 09",
                "Guitar Hero III",
                "Wii Sports",
                "Wii Fit",
                "Legend of Zelda: Twilight Princess"
            };

            var query = ( from g in wiiGames select g ).Reverse();

            // wiiGames[ 1 ] = "FIFA 10";

            foreach( var i in query )
            {
                Console.WriteLine( i );
            }
        }
    }
}
