using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module03.Slide24
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

            var query = from g in wiiGames
                        where g.Length >= 18
                        select g;
            Console.WriteLine( "{0} games match the query", query.Count() );

            //var query = ( from g in wiiGames
            //            where g.Length >= 18
            //            select g ).Count();
            //Console.WriteLine("{0} games match the query", query );

            //foreach (var i in query)
            //{
            //   Console.WriteLine(i);
            //}
        }
    }
}
