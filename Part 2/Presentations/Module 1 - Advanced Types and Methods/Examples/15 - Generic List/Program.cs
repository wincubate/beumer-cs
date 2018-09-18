using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module01.Slide15
{
    class Program
    {
        static void Main( string[] args )
        {
            List<int> list = new List<int>();
            list.Add( 42 );
            list.Add( 87 );
            list.Add( 112 );

            //list.Add( "Hello, World" );

            foreach( int i in list )
            {
                Console.WriteLine( i );
            }
        }
    }
}
