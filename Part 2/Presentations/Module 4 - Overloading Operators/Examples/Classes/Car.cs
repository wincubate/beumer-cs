using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module04.Classes
{
   public class Car
   {
      public const int MaxSpeed = 100;

      private int currSpeed;
      private string petName;

      public Car(string name, int currSp)
      {
         currSpeed = currSp;
         petName = name;
      }

      public int Speed
      {
         get
         {
            return currSpeed;
         }
         set
         {
            currSpeed = value;
         }
      }
      public string PetName
      {
         get
         {
            return petName;
         }
         set
         {
            petName = value;
         }
      }

      public override string ToString()
      {
         return string.Format("{0} going {1}", PetName, currSpeed);
      }
   }
}
