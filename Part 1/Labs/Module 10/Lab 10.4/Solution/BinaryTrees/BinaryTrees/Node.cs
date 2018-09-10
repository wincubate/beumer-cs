using System;
using System.Collections;

namespace BinaryTrees
{
    class Node : IEnumerable
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

        public IEnumerator GetEnumerator()
        {
            yield return _value;

            if( _left != null )
            {
                foreach( int i in _left )
                {
                    yield return i;
                }
            }

            if( _right != null )
            {
                foreach( int i in _right )
                {
                    yield return i;
                }
            }
        }

        public IEnumerable Postfix()
        {
            if( _left != null )
            {
                foreach( int i in _left.Postfix() )
                {
                    yield return i;
                }
            }

            if( _right != null )
            {
                foreach( int i in _right.Postfix() )
                {
                    yield return i;
                }
            }

            yield return _value;
        }
    }
}
