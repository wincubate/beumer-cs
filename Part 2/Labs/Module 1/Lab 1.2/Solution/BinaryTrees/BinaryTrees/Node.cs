using System;

namespace BinaryTrees
{
   public class Node
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

      public void Print()
      {
         Console.WriteLine(Value);

         Left?.Print();
         Right?.Print();
      }

      public void PrintPostfix()
      {
         Left?.PrintPostfix();
         Right?.PrintPostfix();

         Console.WriteLine(Value);
      }
   }
}
