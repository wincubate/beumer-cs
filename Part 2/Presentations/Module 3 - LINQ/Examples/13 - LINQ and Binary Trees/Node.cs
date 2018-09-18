using System;
using System.Collections.Generic;

namespace Wincubate.Module03.Slide13
{
    class Node<T> : IEnumerable<T>
    {
        protected T _value;

        protected Node<T> _left;
        protected Node<T> _right;

        public Node( T value )
            : this( value, null, null )
        {
        }

        public Node( T value, Node<T> left, Node<T> right )
        {
            _value = value;
            _left = left;
            _right = right;
        }


        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
           return ( this as IEnumerable<T> ).GetEnumerator();
        }

        #endregion

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            yield return _value;

            if( _left != null )
            {
                foreach( T t in _left )
                {
                    yield return t;
                }
            }

            if( _right != null )
            {
                foreach( T t in _right )
                {
                    yield return t;
                }
            }
        }

        #endregion

        public IEnumerable<T> Postfix()
        {
            if( _left != null )
            {
                foreach( T t in _left.Postfix() )
                {
                    yield return t;
                }
            }

            if( _right != null )
            {
                foreach( T t in _right.Postfix() )
                {
                    yield return t;
                }
            }

            yield return _value;
        }
    }
}
