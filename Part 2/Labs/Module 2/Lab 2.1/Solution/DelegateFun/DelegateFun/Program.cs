using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateFun
{
    class Program
    {
        static void PrintInt( int i )
        {
            Console.WriteLine( i );
        }

        static void DoForAll( IntAction action, int[] integers )
        {
            foreach( int i in integers )
            {
                action( i );
            }
        }

        static void Main( string[] args )
        {
            int[] numbers = { 42, 87, 112, 176, 256 };

            DoForAll( PrintInt, numbers );
        }
    }
}
