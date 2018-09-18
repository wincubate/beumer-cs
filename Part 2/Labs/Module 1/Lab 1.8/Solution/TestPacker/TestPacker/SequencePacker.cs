using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TestPacker
{
   public class SequencePacker<T> : IEnumerable<T> where T : IEquatable<T>
   {
      private class Node<T>
      {
         public Node(T t)
         {
            Element = t;
            Count = 1;
         }

         public T Element { get; set; }
         public int Count { get; set; }
      }

      List<Node<T>> _nodes;

      public SequencePacker()
      {
         _nodes = new List<Node<T>>();
      }

      public void Clear()
      {
         _nodes.Clear();
      }

      public void Add(T t)
      {
         bool handled = false;
         if (_nodes.Count > 0)
         {
            Node<T> lastNode = _nodes[_nodes.Count - 1];
            if (lastNode.Element.Equals(t))
            {
               lastNode.Count++;
               handled = true;
            }
         }

         if (handled == false)
         {
            _nodes.Add(new Node<T>(t));
         }
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
         return GetEnumerator();
      }

      public IEnumerator<T> GetEnumerator()
      {
         foreach (Node<T> node in _nodes)
         {
            for (int i = 0; i < node.Count; i++)
            {
               yield return node.Element;
            }
         }
      }
   }
}
