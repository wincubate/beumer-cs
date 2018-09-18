using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wincubate.Module03.Classes;

namespace Wincubate.Module03.Slide18
{
    class Program
    {
        #region Reflect Over Query
        static void ReflectOverQueryResults( object query )
        {
            Console.WriteLine();
            Console.WriteLine( "Query is of type: {0}", query.GetType().Name );
            Console.WriteLine( "Query location: {0}", query.GetType().Assembly );
        }
        #endregion

        static void Main( string[] args )
        {
            List<Car> cars = new List<Car>
            {
                new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW" },
                new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW" },
                new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW" },
                new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo" },
                new Car{ PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford" }
            };

            var query = from c in cars
                        where c.Speed >= 55
                        orderby c.PetName descending, c.Color
                        select c;

            foreach( var i in query )
            {
                Console.WriteLine( i );
            }
        }
    }
}
