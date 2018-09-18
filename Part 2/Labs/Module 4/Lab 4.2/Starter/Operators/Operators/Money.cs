using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operators
{
   // TODO 4: Implement IComparable<Money>
   public struct Money
   {
      public int Euro { get; }
      public int Cents { get; }

      // TODO 3: Implement total cents property

      // TODO 2: Implement cents-constructor by chaining

      public Money( int euro, int cents )
      {
         Euro = euro;
         Cents = cents;

         // TODO 1: Normalize to regular euro and cents
      }

      // TODO 5: Arithmetic operators

      // TODO 6: Override virtual methods

      // TODO 7: Override relational operators

      // TODO 8: Construct conversion operators
   }
}
