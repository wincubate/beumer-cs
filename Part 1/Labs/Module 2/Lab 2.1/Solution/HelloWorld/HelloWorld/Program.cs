using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main( string[] args )
        {
            if( args.Length > 0 )
            {
                Console.WriteLine( "Hello, {0}", args[ 0 ] );
            }
        }
    }
}
