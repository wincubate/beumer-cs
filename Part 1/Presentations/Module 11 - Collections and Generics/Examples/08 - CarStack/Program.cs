using System;
using System.Collections;
using Wincubate.Module11.Classes;

namespace Wincubate.Module11.Slide08
{
    class CarStack // : IEnumerable
    {
        private Stack m_Stack;

        public CarStack()
        {
            m_Stack = new Stack();
        }

        public Car Peek()
        {
            return m_Stack.Peek() as Car;
        }

        public void Push( Car c )
        {
            m_Stack.Push( c );
        }

        public Car Pop()
        {
            return m_Stack.Pop() as Car;
        }

        //public int Count
        //{
        //   get
        //   {
        //      return m_Stack.Count;
        //   }
        //}

        //public IEnumerator GetEnumerator()
        //{
        //   return m_Stack.GetEnumerator();
        //}
    }

    class Program
    {
        static void Main( string[] args )
        {
            CarStack stack = new CarStack();
            stack.Push( new Car( "Fred", 90 ) );
            stack.Push( new Car( "Mary", 100 ) );
            stack.Push( new Car( "MB", 190 ) );
            //stack.Push( "Hello, World" );
            //stack.Push( 87 );
            //Console.WriteLine( "There are {0} cars in the queue to begin with", stack.Count );

            Car top = stack.Peek() as Car;
            Console.WriteLine( top.PetName );

            Console.WriteLine( "Pushing Shankly" );
            stack.Push( new Car( "Shankly", 170 ) );

            Console.WriteLine( "Pushing Goofy" );
            stack.Push( new Car( "Goofy", 128 ) );

            Console.WriteLine( "Removing top entry" );
            Car removed = stack.Pop() as Car;
            Console.WriteLine( "Top entry was {0}", removed.PetName );

            //foreach( Car c in stack )
            //{
            //   Console.WriteLine( c.PetName );
            //}
        }
    }
}
