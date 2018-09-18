using System.Collections.Generic;

namespace Wincubate.CS7.Data
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        void Add( Employee employee );
    }
}
