using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operators
{
   // TODO 4: Implement IComparable<Money>
   public struct Money : IComparable<Money>
   {
      public int Euro { get; }
      public int Cents { get; }

      // TODO 3: Implement total cents property
      public int TotalCents => 100 * Euro + Cents;

      // TODO 2: Implement cents-constructor by chaining
      public Money(int cents)
         : this(0, cents)
      {
      }

      public Money(int euro, int cents)
      {
         Euro = euro;
         Cents = cents;

         // TODO 1: Normalize to regular euro and cents
         if (Euro < 0 || Cents < 0)
         {
            throw new ArgumentException("Negative amounts are not allowed");
         }

         Euro += (Cents / 100);
         Cents %= 100;
      }

      public int CompareTo(Money other) => TotalCents - other.TotalCents;

      // TODO 5: Arithmetic operators
      public static Money operator +(Money lhs, Money rhs) =>
         new Money(lhs.Euro + rhs.Euro, lhs.Cents + rhs.Cents);

      public static Money operator +(Money money, int cents) =>
         money + new Money(cents);

      public static Money operator -(Money lhs, Money rhs) =>
         new Money(lhs.TotalCents - rhs.TotalCents);

      public static Money operator -(Money lhs, int cents) =>
         new Money(lhs.TotalCents - cents);

      public static Money operator ++(Money money) => money + 1;

      public static Money operator --(Money money) => money - 1;

      // TODO 6: Override virtual methods
      public override string ToString() => $"EUR {Euro}.{Cents:00}";

      public override bool Equals(object obj)
      {
         return (obj is Money) && this.CompareTo((Money)obj) == 0;
      }

      public override int GetHashCode() => TotalCents;

      // TODO 7: Override relational operators
      public static bool operator ==(Money lhs, Money rhs) =>
         lhs.CompareTo(rhs) == 0;

      public static bool operator !=(Money lhs, Money rhs) =>
         lhs.CompareTo(rhs) != 0;

      public static bool operator <(Money lhs, Money rhs) =>
         lhs.CompareTo(rhs) < 0;

      public static bool operator >(Money lhs, Money rhs) =>
         lhs.CompareTo(rhs) > 0;

      public static bool operator <=(Money lhs, Money rhs) =>
         lhs.CompareTo(rhs) <= 0;

      public static bool operator >=(Money lhs, Money rhs) =>
         lhs.CompareTo(rhs) >= 0;

      // TODO 8: Construct conversion operators
      public static explicit operator Money(int cents) =>
         new Money(0, cents);

      public static explicit operator Money(float cents) =>
         new Money(0, (int)cents);

      public static implicit operator int (Money money) => money.TotalCents;

      public static explicit operator float (Money money) => money.TotalCents;

      public static implicit operator string (Money money) => money.ToString();
   }
}
