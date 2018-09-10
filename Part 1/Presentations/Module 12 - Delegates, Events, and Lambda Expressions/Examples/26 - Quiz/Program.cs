using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module12.Slide26
{
    class Program
    {
        static void Main( string[] args )
        {
            List<int> list = new List<int>{ 42, 87, 112, 59, 33, 128 };

            int j = 112;
            List<int> filtered = list.FindAll( i =>
            {
                return i != j;
            } );

            foreach( int i in filtered )
            {
                Console.WriteLine( i );
            }
        }
    }
}
