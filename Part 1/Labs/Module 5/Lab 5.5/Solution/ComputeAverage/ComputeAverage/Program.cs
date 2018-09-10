using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputeAverage
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine( Average( 42, 87, 112, 176 ) );
            Console.WriteLine( Average( 1.76, 3.14 ) );
            Console.WriteLine( Average() );
        }

        static double Average( params double[] numbers )
        {
            double sum = 0.0;

            if( numbers.Length == 0 )
            {
                return sum;
            }

            foreach( double d in numbers )
            {
                sum += d;
            }

            return sum / numbers.Length;
        }
    }
}
