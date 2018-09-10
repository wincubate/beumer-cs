using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module11.Slide14
{
    class Program
    {
        static void Main( string[] args )
        {
            Dictionary<int, string> lineUp = new Dictionary<int, string>();
            lineUp.Add( 19, "Kim Aabech" );
            lineUp.Add( 11, "Jesper Lange" );
            lineUp.Add( 7, "Stephan Petersen" );
            lineUp.Add( 4, "Daniel A. Pedersen" );

            Console.WriteLine( "Playing with number 11 is {0}", lineUp[ 11 ] );

            foreach( KeyValuePair<int, string> kv in lineUp )
            {
                Console.WriteLine( "Player {0} is {1}", kv.Key, kv.Value );
            }
        }
    }
}
