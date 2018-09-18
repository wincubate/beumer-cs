using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wincubate.Module01.Classes;

namespace Wincubate.Module01.Slide16
{
    class Program
    {
        static void Main( string[] args )
        {
            Queue<Car> queue = new Queue<Car>();
            queue.Enqueue( new Car( "Fred", 90 ) );
            queue.Enqueue( new Car( "Mary", 100 ) );
            queue.Enqueue( new Car( "MB", 190 ) );

            Console.WriteLine( "There are {0} cars in the queue to begin with", queue.Count );

            Car first = queue.Peek();
            Console.WriteLine( first.PetName );

            Console.WriteLine( "Enqueueing Shankly" );
            queue.Enqueue( new Car( "Shankly", 170 ) );

            Console.WriteLine( "Removing first entry" );
            Car removed = queue.Dequeue();
            Console.WriteLine( "First entry was indeed {0}", removed.PetName );

            foreach( Car c in queue )
            {
                Console.WriteLine( c.PetName );
            }
        }
    }
}
