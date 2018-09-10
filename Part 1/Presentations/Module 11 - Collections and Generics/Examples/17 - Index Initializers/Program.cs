using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module11.Slide17
{
    class Program
    {
        static void Main( string[] args )
        {
            Dictionary<int, string> lineUp = new Dictionary<int, string>
            {
                [19] = "Kim Aabech",
                [11] = "Jesper Lange",
                [7] = "Stephan Petersen",
                [4] = "Daniel A. Pedersen"
            };

            Console.WriteLine( "Playing with number 11 is {0}", lineUp[11] );

            foreach (KeyValuePair<int, string> kv in lineUp)
            {
                Console.WriteLine( "Player {0} is {1}", kv.Key, kv.Value );
            }
        }
    }
}
