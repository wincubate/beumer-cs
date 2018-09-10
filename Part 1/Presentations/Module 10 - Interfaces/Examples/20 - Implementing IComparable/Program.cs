using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module11.Slide24
{
    class Program
    {
        static void Main( string[] args )
        {
            Car[] cars = { new Car("Rusty", 80, 1), 
                       new Car("Mary", 40, 234),
                       new Car("Viper", 40, 34),
                       new Car("Mel", 40, 4),
                       new Car("Chucky", 40, 5)
         };

            Console.WriteLine( "Unsorted cars:" );
            foreach( Car c in cars )
            {
                Console.WriteLine( "{0}:\t{1}", c.ID, c.PetName );
            }

            Array.Sort( cars );

            Console.WriteLine( "Sorted cars:" );
            foreach( Car c in cars )
            {
                Console.WriteLine( "{0}:\t{1}", c.ID, c.PetName );
            }
        }
    }
}
