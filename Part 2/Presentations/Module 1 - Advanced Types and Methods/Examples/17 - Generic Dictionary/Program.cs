using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module01.Slide17
{
    class Program
    {
        static void Main( string[] args )
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add( 11, "Peter Graulund" );
            dict.Add( 7, "Stephan Petersen" );
            dict.Add( 30, "David Devdariani" );

            Console.WriteLine( "Playing with number 11 is {0}", dict[ 11 ] );

            foreach( KeyValuePair<int, string> kv in dict )
            {
                Console.WriteLine( "Player {0} is {1}", kv.Key, kv.Value );
            }
        }
    }
}
