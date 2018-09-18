using System;
using System.Collections.Generic;
using Wincubate.CS7x.Data;

namespace Wincubate.CS7x.Slide06
{
    class Program
    {
        static void Main( string[] args )
        {
            IEmployeeRepository repository = new EmployeeRepository();
            IEnumerable<Employee> all = repository.GetAll();

            foreach (Employee e in all)
            {
                Promote(e);
            }
        }

        static void Promote<T>( T employee )
        {
            //switch (employee)
            //{
            //    case SoftwareArchitect sa:
            //        sa.Level = SoftwareArchitectLevel.Lead;
            //        break;

            //    case SoftwareEngineer se:
            //        se.Level = SoftwareEngineerLevel.Chief;
            //        break;
            //}
        }
    }
}
