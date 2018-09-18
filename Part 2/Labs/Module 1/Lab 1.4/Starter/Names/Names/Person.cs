using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Names
{
   public class Person
   {
      public string FirstName { get; private set; }
      public string MiddleName { get; private set; }
      public string LastName { get; private set; }

      public Person(string lastName, string firstName, string middleName = "")
      {
         LastName = lastName;
         FirstName = firstName;
         MiddleName = middleName;
      }

      public override string ToString()
      {
         return $"{FirstName} {MiddleName}{LastName}";
      }
   }
}
