using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module01.Slide46
{
   static class MyExtensions
   {
      public static string ToMyTimestamp(this DateTime dt)
      {
         return dt.ToString("yyyy-MM-dd HH:mm:ss.fff");
      }
   }

   class Program
   {
      static void Main(string[] args)
      {
         DateTime dt = DateTime.Now;
         Console.WriteLine(dt.ToMyTimestamp());
      }
   }
}
