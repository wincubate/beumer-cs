using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveTypes
{
   public class Node
   {
      public object Data { get; set; }
      public Node Next { get; set; }

      public Node(object data = null)
      {
         Data = data;
      }
   }

   public class LinkedList
   {
      public Node Head { get; private set; }
      public Node Last { get; private set; }

      public LinkedList()
      {
         Head = null;
      }

      public void Add(object data)
      {
         Node node = new Node { Data = data };
         if (Head == null)
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
   }
}
