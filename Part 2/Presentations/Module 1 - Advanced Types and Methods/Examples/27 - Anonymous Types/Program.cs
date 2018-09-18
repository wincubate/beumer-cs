using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module01.Slide27
{
   class Program
   {
      #region Type investigation
      static void ReflectOverAnonymousType(object obj)
      {
         Console.WriteLine("obj is an instance of: {0}", obj.GetType().Name);
         Console.WriteLine("Base class of {0} is {1}",
         obj.GetType().Name,
         obj.GetType().BaseType);
         Console.WriteLine("obj.ToString() = {0}", obj.ToString());
         Console.WriteLine("obj.GetHashCode() = {0}", obj.GetHashCode());
         Console.WriteLine();
      }
      #endregion

      static void Main(string[] args)
      {
         var myEquipment =
            new { Manufacturer = "Nintendo", Make = "Wii", Controllers = 4 };

         Console.WriteLine("My gaming device is a {0} {1} with {2} controllers",
            myEquipment.Manufacturer,
            myEquipment.Make,
            myEquipment.Controllers);

         //myEquipment.Controllers = 5;

         //ReflectOverAnonymousType( myEquipment );
      }
   }
}
