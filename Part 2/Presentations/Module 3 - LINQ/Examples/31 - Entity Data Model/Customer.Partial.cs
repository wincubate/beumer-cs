using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module17.Slide09
{
   public partial class Customer
   {
      public string FullName
      {
         get
         {
            return FirstName + " " + LastName;
         }
      }

      public int Age
      {
         get
         {
            DateTime today = DateTime.Now;
            return today.Year - this.BirthDate.Year - ( this.BirthDate.DayOfYear < today.DayOfYear ? 0 : 1 );
         }
      }
   }
}
