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
            string name;
            Console.WriteLine( "Please enter your name: " );
            name = Console.ReadLine();
            Console.WriteLine( "Hello, {0}", name );
        }
    }
}
