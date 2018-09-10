using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module06.Slide16
{
   class Car
   {
      public string petName;
      public int currentSpeed;

      public void PrintState()
      {
         Console.WriteLine("{0} is going {1} km/h", petName, currentSpeed);
      }

      public void SpeedUp(int delta)
      {
         currentSpeed += delta;
      }
   }

   class Program
   {
      static void Main()
      {
         Car myCar = new Car();
         myCar.petName = "Goofy";

         // Speed up the car a few times and print out state
         for (int i = 0; i <= 5; i++)
         {
            myCar.SpeedUp(10);
            myCar.PrintState();
         }
      }
   }
}
