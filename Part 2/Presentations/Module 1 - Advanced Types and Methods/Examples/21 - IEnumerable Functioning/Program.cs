using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module01.Slide21
{
    class Program
    {
        static void Main( string[] args )
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            // We write:
            // Compiler does:
            IEnumerator enumerator = array.GetEnumerator();
            while( enumerator.MoveNext() )
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
