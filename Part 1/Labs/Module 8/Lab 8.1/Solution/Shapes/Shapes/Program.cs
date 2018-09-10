using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    class Program
    {
        static void Main( string[] args )
        {
            Shape[] all = { new Circle( 3 ), new Rectangle( 4, 5 ), new Square( 6 ), new Square( 7 ) };

            foreach( Shape s in all )
            {
                Console.WriteLine( "Arealet af {0} er {1}",
                   s,
                   s.Area );
            }
        }
    }
}
