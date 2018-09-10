using System;
using Wincubate.Module11.Classes;

namespace Wincubate.Module11.Slide09
{
    public class Stack
    {
        const int DefaultSize = 100;
        readonly int m_Size;
        int m_StackPointer = 0;
        object[] m_Items;

        public Stack()
            : this( DefaultSize )
        {
        }

        public Stack( int size )
        {
            m_Size = size;
            m_Items = new object[ m_Size ];
        }

        public object Peek()
        {
            if( m_StackPointer >= m_Size )
                throw new StackOverflowException();

            if( m_StackPointer > 0 )
            {
                return m_Items[ m_StackPointer - 1 ];
            }
            else
            {
                throw new InvalidOperationException( "Cannot peek an empty stack" );
            }
        }

        public void Push( object item )
        {
            if( m_StackPointer >= m_Size )
                throw new StackOverflowException();

            m_Items[ m_StackPointer ] = item;
            m_StackPointer++;
        }

        public object Pop()
        {
            m_StackPointer--;
            if( m_StackPointer >= 0 )
            {
                return m_Items[ m_StackPointer ];
            }
            else
            {
                m_StackPointer = 0;
                throw new InvalidOperationException( "Cannot pop an empty stack" );
            }
        }

        public int Count
        {
            get
            {
                return m_StackPointer;
            }
        }
    }

    class Program
    {
        static void Main( string[] args )
        {
            Stack stack = new Stack();
            stack.Push( new Car( "Fred", 90 ) );
            stack.Push( new Car( "Mary", 100 ) );
            stack.Push( new Car( "MB", 190 ) );
            stack.Push( "Hello, World" );
            stack.Push( 87 );
            Console.WriteLine( "There are {0} cars in the queue to begin with", stack.Count );

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
