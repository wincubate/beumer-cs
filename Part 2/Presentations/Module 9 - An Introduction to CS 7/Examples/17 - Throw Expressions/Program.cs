using Wincubate.CS7.Data;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Wincubate.CS7.Slide17
{
    class Program
    {
        static void Main( string[] args )
        {
            IEmployeeRepository repository = new EmployeeRepository();
            IEnumerable<Employee> all = repository.GetAll();

            repository.Add(null);

            //repository.Add(new Employee { FirstName = "Anders", LastName = "Hejlsberg" });

            repository
                .GetAll()
                .Select(e => e.FirstName)
                .ToList()
                .ForEach(WriteLine);
        }
    }
}
