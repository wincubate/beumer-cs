using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module11.Slide19
{
    class Program
    {
        static void Main( string[] args )
        {
            DisplayBaseClass<string>();
            DisplayBaseClass<int>();
            //DisplayBaseClass();
        }

        static void DisplayBaseClass<T>()
        {
            Console.WriteLine( "Base class of {0} is {1}",
               typeof( T ),
               typeof( T ).BaseType
            );
        }
    }
}
