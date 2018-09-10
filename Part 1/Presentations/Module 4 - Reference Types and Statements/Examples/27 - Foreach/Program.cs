using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module04.Slide28
{
    enum Color
    {
        Red,
        Green,
        Blue
    }

    class Program
    {
        static void Main( string[] args )
        {
            int[] myArray = { 42, 87, 112, 99, 208 };

            foreach( int i in myArray )
            {
                Console.WriteLine( "Number is: {0} ", i );
            }
            // "i" is not visible here.

            //foreach( var i in myArray )
            //{
            //    Console.WriteLine( "{0} ", i );
            //}

            //foreach (Color c in Enum.GetValues(typeof(Color)))
            //{
            //   Console.WriteLine("{0}", c);
            //}
        }
    }
}
