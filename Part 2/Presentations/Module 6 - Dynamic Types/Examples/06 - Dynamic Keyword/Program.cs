using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module06.Slide06
{
    class Program
    {
        static void Main( string[] args )
        {
            dynamic calculator = new Calculator();
            int result = calculator.Add( 42, 87 );

            // ...

            Console.WriteLine( result );
        }
    }

    class Calculator
    {
        public int Add( int a, int b )
        {
            return a + b;
        }
    }
}
