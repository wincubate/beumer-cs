using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module10.Slide29
{
    class Program
    {
        static void Main()
        {
            bool b = true;
            A longLivingVariable;

            if( b )
            {
                int i = 0;
                while( true )
                {
                    for( int counter = 0; counter < 1000; counter++ )
                    {
                        A a = new A( i );
                        i++;

                        if( i % 100 == 0 )
                        {
                            longLivingVariable = a;
                        }
                    }
                    Console.Write( A.counter );

                    // Wait for next <ENTER>
                    Console.ReadLine();
                }
            }
        }
    }
}
