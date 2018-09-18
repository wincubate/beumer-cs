using System.Collections.Generic;

namespace Wincubate.CS7x.Data
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        void Add( Employee employee );
    }
}
