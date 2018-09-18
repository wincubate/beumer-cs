using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module03.Slide26
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
            string[] xbox360Games =
            {
                "Halo", 
                "FIFA 09",
                "Guitar Hero III",
                "Banjo Kazooie"
            };

            var query = ( from g in wiiGames
                          select g ).Except( from g in xbox360Games
                                             select g );

            //var query2 = wiiGames.Except( xbox360Games );

            foreach( var i in query )
            {
                Console.WriteLine( i );
            }
        }
    }
}
