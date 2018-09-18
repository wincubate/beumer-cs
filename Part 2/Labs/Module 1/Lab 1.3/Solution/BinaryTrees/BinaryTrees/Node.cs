using System;
using System.Collections;
using System.Linq;

namespace BinaryTrees
{
   class Node : IEnumerable
   {
      public int Value { get; protected set; }
      public Node Left { get; protected set; }
      public Node Right { get; protected set; }

      public Node(int value, Node left = null, Node right = null)
      {
         Value = value;
         Left = left;
         Right = right;
      }

      public IEnumerator GetEnumerator()
      {
         yield return Value;

         if (Left != null)
         {
            foreach (int i in Left)
            {
               yield return i;
            }
         }

         if (Right != null)
         {
            foreach (int i in Right)
            {
               yield return i;
            }
         }
      }

      public IEnumerable Postfix()
      {
         if (Left != null)
         {
            foreach (int i in Left.Postfix())
            {
               yield return i;
            }
         }

         if (Right != null)
         {
            foreach (int i in Right.Postfix())
            {
               yield return i;
            }
         }

         yield return Value;
      }
   }
}
