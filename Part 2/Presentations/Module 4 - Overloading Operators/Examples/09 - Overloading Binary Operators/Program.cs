using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module04.Slide09
{
   struct Point
   {
      public int x, y;

      public Point(int x, int y)
      {
         this.x = x;
         this.y = y;
      }

      public override string ToString()
      {
         return string.Format("({0},{1})", x, y);
      }

      public static Point operator +(Point p1, Point p2)
      {
         return new Point(p1.x + p2.x, p1.y + p2.y);
      }

      //public static Point operator -( Point p1, Point p2 )
      //{
      //   return new Point( p1.x - p2.x, p1.y - p2.y );
      //}

      //public static Point operator +(Point p1, int delta)
      //{
      //   return new Point(p1.x + delta, p1.y + delta);
      //}
   }

   class Program
   {
      static void Main(string[] args)
      {
         Point P = new Point(1, 2);
         Point Q = new Point(3, 4);
         Point R = P + Q;
         Console.WriteLine(R);

         //Point P = new Point(1, 2);
         //Point Q = P + 10;
         //Console.WriteLine(Q);

         //Point Q = 10 + P;
         //Point Q = P - 10
      }
   }
}
