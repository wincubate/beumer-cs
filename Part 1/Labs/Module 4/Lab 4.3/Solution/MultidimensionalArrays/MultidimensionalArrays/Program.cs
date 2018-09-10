using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main( string[] args )
        {
            // Two-dimensional (with explicit size declaration)
            string[ , ] moonsOfJupiter = new string[ 2, 3 ] { { "Thebe", "Io", "Ananke" }, { "Ganymedes", "Leda", "Sinope" } };
            foreach( string s in moonsOfJupiter )
            {
                Console.WriteLine( s );
            }

            // Three-dimensional (with implicit size declaration)
            int[ , , ] cube = {
			   { { 0, 1, 2, 3 }, 
				  { 4, 5, 6, 7 },
				  { 8, 9, 10, 11 } },
			   { { 12, 13, 14, 15 },
				  { 16, 17, 18, 19 },
				  { 20, 21, 22, 23 } }
			};

            foreach( int i in cube )
            {
                Console.WriteLine( i );
            }
        }
    }
}
