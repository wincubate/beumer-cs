using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module01.Slide19
{
    class Program
    {
        static void Main( string[] args )
        {
            List<int> list = new List<int> { 42, 87, 112 };

            //List<string> list = new List<string> { "Hello", "World" };

            //SortedSet<int> set = new SortedSet<int> { 87, 42, 87, 176, 112, 87, 176 };

            foreach( var element in list )
            {
                Console.WriteLine( element );
            }
        }
    }
}
