using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module01.Slide29
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

      enum MembershipType
      {
         Gold,
         Silver,
         Free
      };

      static void Main(string[] args)
      {
         var myFancyEquipment = new
         {
            Manufacturer = "Xbox",
            Make = "360",
            XboxLiveIdentity = new
            {
               Name = "Komatoze",
               Membership = MembershipType.Gold
            }
         };

         Console.WriteLine(myFancyEquipment);

         //ReflectOverAnonymousType( myFancyEquipment );
      }
   }
}
