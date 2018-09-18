using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module07.Slide10
{
   class Employee
   {
      public string Name { get; set; }
   }

   class Program
   {
      static void Main( string[] args )
      {
         IEnumerable<Employee> employees = new List<Employee>
         {
            new Employee { Name = "Skæg" },
            new Employee { Name = "Sebastian" },
            new Employee { Name = "Rosa" },
            new Employee { Name = "Mille" },
            new Employee { Name = "Jakob" },
            new Employee { Name = "Bruno" }
         };

         Parallel.ForEach( employees, ( e, state, i ) => LongOperation( e ) );
      }

      private static void LongOperation( Employee e )
      {
         Console.WriteLine( $"Processing {e.Name}..." );
      }
   }
}
