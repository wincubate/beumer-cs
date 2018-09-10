using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello
{
    class Program
    {
        static void Main( string[] args )
        {
            // TODO 2: Invoke overridden Hello() method
            Greetings csGreetings = new Greetings();
            Console.WriteLine( csGreetings.Hello() );
        }
    }
}
