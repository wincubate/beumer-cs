using System;
using System.Collections.Generic;
using System.Linq;

namespace Wincubate.CS7.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IList<Employee> _employees;

        public EmployeeRepository()
        {
            Employee both = new SoftwareArchitect
            {
                FirstName = "Bo",
                LastName = "Ramsdahl Thomassen",
                Level = SoftwareArchitectLevel.Senior,
                VisioDrawingsProduced = 87
            };
            Employee henrmo = new SoftwareEngineer
            {
                FirstName = "Henrik",
                LastName = "Leth Mortensen",
                Level = SoftwareEngineerLevel.Senior,
                CodeLinesProduced = 251723
            };
            Employee jepk = new SoftwareEngineer
            {
                FirstName = "Jeppe",
                LastName = "Thestrup Knudsen",
                Level = SoftwareEngineerLevel.Senior,
                CodeLinesProduced = 235919
            };
            Employee rm = new SoftwareArchitect
            {
                FirstName = "Rasmus",
                LastName = "Holm Mortensen",
                Level = SoftwareArchitectLevel.Senior,
                VisioDrawingsProduced = 42
            };
            Employee nilad = new BusinessAnalyst
            {
                FirstName = "Nina",
                LastName = "Holewińska Ladefoged"
            };
            Employee ntho = new ProjectManager
            {
                FirstName = "Nils",
                LastName = "Gram Thomassen",
                Level = ProjectManagerLevel.Senior,
                Team = "Banzai Raccoons"
            };
            Employee phe = new StudentProgrammer
            {
                FirstName = "Peter",
                LastName = "Nethan Henriksen",
                MentoredBy = jepk
            };
            Employee jeshe = new SoftwareEngineer
            {
                FirstName = "Jesper",
                LastName = "Gulmann Henriksen",
                Level = SoftwareEngineerLevel.Lead,
                CodeLinesProduced = 176
            };

            _employees = new List<Employee>
            {
                both, henrmo, jepk, rm, nilad, ntho, phe, jeshe
            };
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employees.ToList();
        }

        //public void Add( Employee employee )
        //{
        //    if (employee == null)
        //    {
        //        throw new ArgumentNullException("employee");
        //    }

        //    _employees.Add(employee);
        //}

        public void Add( Employee employee ) =>
            _employees.Add(employee ?? throw new ArgumentNullException(nameof(employee)));
    }
}
