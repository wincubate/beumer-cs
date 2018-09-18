using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module01.Slide09
{
   public class Node
   {
      public object Data { get; set; }
      public Node Next { get; set; }

      public Node()
      {

      }
      public Node( object data ) : this()
      {
         Data = data;
      }
   }

   public class LinkedList
   {
      private Node _head;
      private Node _last;

      public LinkedList()
      {
         _head = null;
      }

      public void Add( object data )
      {
         Node node = new Node { Data = data };
         if ( _head == null )
         {
            _head = node;
            _last = node;
         }
         else
         {
            _last.Next = node;
            _last = _last.Next;
         }
      }
   }
}
