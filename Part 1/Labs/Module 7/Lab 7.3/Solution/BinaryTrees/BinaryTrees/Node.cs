using System;

namespace BinaryTrees
{
    public class Node
    {
        protected int _value;
        protected Node _left;
        protected Node _right;

        public Node( int value )
            : this( value, null, null )
        {
        }

        public Node( int value, Node left, Node right )
        {
            _value = value;
            _left = left;
            _right = right;
        }

        public void Print()
        {
            Console.WriteLine( _value );

            if( _left != null )
            {
                _left.Print();
            }

            if( _right != null )
            {
                _right.Print();
            }
        }

        public void PrintPostfix()
        {
            if( _left != null )
            {
                _left.PrintPostfix();
            }

            if( _right != null )
            {
                _right.PrintPostfix();
            }

            Console.WriteLine( _value );
        }
    }
}
