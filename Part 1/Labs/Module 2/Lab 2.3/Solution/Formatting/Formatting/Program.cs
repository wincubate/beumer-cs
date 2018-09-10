using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formatting
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine( "Please enter a number: " );
            string number = Console.ReadLine();
            int i = int.Parse( number );

            Console.WriteLine( "The entered number is decimal {0:d}", i );
            Console.WriteLine( "The entered number is the number {0:n}", i );
            Console.WriteLine( "The entered number is the currency amount {0:c}", i );
        }
    }
}
