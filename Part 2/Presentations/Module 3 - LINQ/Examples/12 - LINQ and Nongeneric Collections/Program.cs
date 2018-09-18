using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wincubate.Module03.Classes;

namespace Wincubate.Module03.Slide12
{
    class Program
    {
        static void Main( string[] args )
        {
            ArrayList cars = new ArrayList
            {
                new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW" },
                new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW" },
                new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW" },
                new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo" },
                new Car{ PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford" }
            };

            // cars. ???

            IEnumerable<Car> enumerableCars = cars.OfType<Car>();
            var query = from c in enumerableCars
                        where c.Speed > 90 && c.Make == "BMW"
                        select c;

            foreach( var i in query )
            {
                Console.WriteLine( i );
            }
        }
    }
}
