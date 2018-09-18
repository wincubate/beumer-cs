using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module01.Slide28
{
   class Program
   {
      #region Type investigation
      static void ReflectOverAnonymousType(object obj)
      {
         Console.WriteLine();
         Console.WriteLine("obj is an instance of: {0}", obj.GetType().Name);
         Console.WriteLine("Base class of {0} is {1}",
         obj.GetType().Name,
         obj.GetType().BaseType);
         Console.WriteLine("obj.ToString() = {0}", obj.ToString());
         Console.WriteLine("obj.GetHashCode() = {0}", obj.GetHashCode());
      }
      #endregion

      static void Main(string[] args)
      {
         var first = new
         {
            Manufacturer = "Nintendo",
            Make = "Wii",
            Controllers = 4
         };
         var second = new
         {
            Manufacturer = "Nintendo",
            Make = "Wii",
            Controllers = 4
         };

         Console.WriteLine("first.Equals( second )                       : {0}", first.Equals(second));
         Console.WriteLine("first                == second               : {0}", first == second);
         Console.WriteLine("first.GetType().Name == second.GetType().Name: {0}", first.GetType().Name == second.GetType().Name);

         //ReflectOverAnonymousType( first );
         //ReflectOverAnonymousType( second );
      }
   }
}
