using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module06.Slide17
{
   class Car
   {
      public string petName;
      public int currentSpeed;

      public Car()
      {
         petName = "Chuck";
         currentSpeed = 10;
      }

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

         myCar.PrintState();
      }
   }
}
