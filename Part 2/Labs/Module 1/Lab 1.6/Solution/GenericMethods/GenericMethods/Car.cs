using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericMethods
{
   public class Car : IComparable<Car>
   {
      public const int MaxSpeed = 100;

      public int Speed { get; set; }
      public string PetName { get; set; }

      public string ID { get; }
      public Car(string petName, int speed, string id)
      {
         Speed = speed;
         PetName = petName;
         ID = id;
      }

      public int CompareTo(Car obj)
      {
         return (ID.CompareTo(obj.ID));
      }
   }
}
