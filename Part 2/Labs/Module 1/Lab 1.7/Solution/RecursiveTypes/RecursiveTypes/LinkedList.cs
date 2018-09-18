using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveTypes
{
   public class Node<T>
   {
      public T Data { get; set; }
      public Node<T> Next { get; set; }

      public Node( T data = default(T) )
      {
         Data = data;
      }
   }

   public class LinkedList<T> : IEnumerable<T>
   {
      public Node<T> Head { get; private set; }
      public Node<T> Last { get; private set; }


      public LinkedList()
      {
         Head = null;
      }

      public void Add( T data )
      {
         Node<T> node = new Node<T> { Data = data };
         if ( Head == null )
         {
            Head = node;
            Last = node;
         }
         else
         {
            Last.Next = node;
            Last = Last.Next;
         }
      }

      #region IEnumerable<T> Members

      public IEnumerator<T> GetEnumerator()
      {
         Node<T> current = Head;
         while ( current != null )
         {
            yield return current.Data;
            current = current.Next;
         }
      }

      #endregion

      #region IEnumerable Members

      System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
      {
         return ( this as IEnumerable<T> ).GetEnumerator();
      }

      #endregion
   }
}
