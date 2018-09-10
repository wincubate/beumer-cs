using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module04.Slide32
{
    class Program
    {
        static void Main( string[] args )
        {
            int[] myArray = { 42, 87, 112, 99, 208 };

            foreach( int i in myArray )
            {
                if( i != 87 )
                {
                    continue;
                }
                Console.WriteLine( "Number is: {0} ", i );
            }
        }
    }
}
