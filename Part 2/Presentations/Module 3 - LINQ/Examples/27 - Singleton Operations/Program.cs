using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module03.Slide27
{
    class Program
    {
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
                //"Halo", 
                //"FIFA 09",
                //"Guitar Hero III",
                "Banjo Kazooie"
            };

            var query = wiiGames.Intersect( xbox360Games );

            var first = query.First();
            var last = query.Last();
            var theOnlyOne = query.Single();

            Console.WriteLine( first );
            Console.WriteLine( last );
            Console.WriteLine( theOnlyOne );

            //var firstOrNone = query.FirstOrDefault();
            //var lastOrNone = query.LastOrDefault();
            //var theOnlyOneOrNone = query.SingleOrDefault();

            //Console.WriteLine( firstOrNone );
            //Console.WriteLine( lastOrNone );
            //Console.WriteLine( theOnlyOneOrNone );
        }
    }
}
