using System;
using System.Linq;
using System.Text;
using Wincubate.Module01.Classes;
using System.Collections;

namespace Wincubate.Module01.Slide11
{
    class Program
    {
        static void Main( string[] args )
        {
            Stack stack = new Stack();
            stack.Push( new Car( "Fred", 90 ) );
            stack.Push( new Car( "Mary", 100 ) );
            stack.Push( new Car( "MB", 190 ) );

            Console.WriteLine( "There are {0} cars in the stack to begin with", stack.Count );

            Car top = stack.Peek() as Car;
            Console.WriteLine( top.PetName );

            Console.WriteLine( "Pushing Shankly" );
            stack.Push( new Car( "Shankly", 170 ) );

            Console.WriteLine( "Pushing Goofy" );
            stack.Push( new Car( "Goofy", 128 ) );

            Console.WriteLine( "Removing top entry" );
            Car removed = stack.Pop() as Car;
            Console.WriteLine( "Top entry was {0}", removed.PetName );

            foreach( Car c in stack )
            {
                Console.WriteLine( c.PetName );
            }
        }
    }
}
