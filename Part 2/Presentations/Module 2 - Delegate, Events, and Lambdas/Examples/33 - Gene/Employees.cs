using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module02.Data
{
   public class Employee : IComparable<Employee>
   {
      public string Name
      {
         get;
         set;
      }

      public override string ToString()
      {
         return Name;
      }

      #region IComparable<Employee> Members

      public int CompareTo( Employee other )
      {
         return this.Name.CompareTo( other.Name );
      }

      #endregion
   }

   public class Manager : Employee
   {
      public int StockOptions
      {
         get;
         set;
      }
   }

   public enum Language
   {
      CSharp,
      Vb
   }

   public class Developer : Employee
   {
      public Language FavoriteLanguage
      {
         get;
         set;
      }
   }
}
