using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module04.Slide17
{
   struct Point : IComparable
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

      public static Point operator -(Point p1, Point p2)
      {
         return new Point(p1.x - p2.x, p1.y - p2.y);
      }

      public static Point operator +(Point p1, int delta)
      {
         return new Point(p1.x + delta, p1.y + delta);
      }

      public static Point operator +(int delta, Point p1)
      {
         return new Point(p1.x + delta, p1.y + delta);
      }

      public static Point operator -(Point p1, int delta)
      {
         return new Point(p1.x - delta, p1.y - delta);
      }

      public static Point operator -(int delta, Point p1)
      {
         return new Point(p1.x - delta, p1.y - delta);
      }

      public static Point operator ++(Point p1)
      {
         return p1 + 1;
      }

      public static Point operator --(Point p1)
      {
         return p1 - 1;
      }

      public override bool Equals(object obj)
      {
         return this.ToString() == obj.ToString();
      }

      public override int GetHashCode()
      {
         return this.ToString().GetHashCode();
      }

      public static bool operator ==(Point p1, Point p2)
      {
         return p1.Equals(p2);
      }

      public static bool operator !=(Point p1, Point p2)
      {
         return !p1.Equals(p2);
      }

      public int CompareTo(object obj)
      {
         if (obj is Point)
         {
            Point p = (Point)obj;
            if (this.x > p.x && this.y > p.y)
            {
               return 1;
            }
            else if (this.x < p.x && this.y < p.y)
            {
               return -1;
            }
            else
            {
               return 0;
            }
         }
         else
         {
            throw new ArgumentException();
         }
      }

      public static bool operator <(Point p1, Point p2)
      {
         return (p1.CompareTo(p2) < 0);
      }

      public static bool operator >(Point p1, Point p2)
      {
         return (p1.CompareTo(p2) > 0);
      }

      public static bool operator <=(Point p1, Point p2)
      {
         return (p1.CompareTo(p2) <= 0);
      }

      public static bool operator >=(Point p1, Point p2)
      {
         return (p1.CompareTo(p2) >= 0);
      }

      public static explicit operator int(Point p1)
      {
         if (p1.x >= 0 && p1.y >= 0)
         {
            return p1.x * p1.y;
         }

         string error = string.Format("Point {0} does not correspond to a well-defined area", p1);
         throw new InvalidCastException(error);
      }

      public static implicit operator string(Point p1)
      {
         return p1.ToString();
      }
   }

   class Program
   {
      static void Main(string[] args)
      {
         string s = new Point(1, 2);
         string t = new Point(-2, 3);

         Console.WriteLine(s);
         Console.WriteLine(t);
      }
   }
}
