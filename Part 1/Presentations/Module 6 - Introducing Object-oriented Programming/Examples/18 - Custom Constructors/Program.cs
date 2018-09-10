using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module06.Slide18
{
   class Car
   {
      public string petName;
      public int currentSpeed;

      public Car(string pt)
      {
         petName = pt;
      }
      public Car(string pn, int cs)
      {
         petName = pn;
         currentSpeed = cs;
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
         Car chuck = new Car("Chuck");
         Car goofy = new Car("Goofy", 87);

         chuck.PrintState();
         goofy.PrintState();
      }
   }
}
