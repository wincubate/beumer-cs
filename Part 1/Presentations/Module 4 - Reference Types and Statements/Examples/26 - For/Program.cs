using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module04.Slide27
{
    class Program
    {
        static void Main( string[] args )
        {
            //// Note! "i" is only visible within the scope of the for loop.
            //for (int i = 0; i < 4; i++)
            //{
            //   Console.WriteLine("Number is: {0} ", i);
            //}
            //// "i" is not visible here.

            for( int i = 0, j = 10; ; i++, j -= 10 )
            {
                Console.WriteLine( "i = {0}. j = {1}", i, j );
            }
        }
    }
}
