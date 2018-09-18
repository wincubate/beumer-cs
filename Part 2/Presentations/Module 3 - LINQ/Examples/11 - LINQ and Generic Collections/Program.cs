using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wincubate.Module03.Classes;

namespace Wincubate.Module03.Slide11
{
    class Program
    {
        static void Main( string[] args )
        {
            Stack<int> stack = new Stack<int>( new int[] { 10, 20, 30, 40, 0, 1, 2, 3, 8 } );

            var query = from i in stack
                        where i < 10
                        select i;

            //List<Car> cars = new List<Car>() {
            //   new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW" },
            //   new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW" },
            //   new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW" },
            //   new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo" },
            //   new Car{ PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford" }
            //};

            //var query = from c in cars
            //            where c.Speed > 90 && c.Make == "BMW"
            //            select c;

            foreach( var i in query )
            {
                Console.WriteLine( i );
            }
        }
    }
}
