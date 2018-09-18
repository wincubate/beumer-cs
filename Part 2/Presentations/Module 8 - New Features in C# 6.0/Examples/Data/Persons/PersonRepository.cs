using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module08.Data
{
    public class PersonRepository
    {
        private List<Person> _persons;

        public PersonRepository()
        {
            _persons = new List<Person>
            {
				new Person { FirstName = "Jimmy", LastName = "McGill", Age = 41 },
				new Person { FirstName = "Mike", LastName = "Ehrmantraut", Age = 53 },
				new Person { FirstName = "Tuco", LastName = "Salamanca", Age = 29 },
				new Person { FirstName = "Chuck", LastName = "McGill", Age = 47 }
			};
        }

        public IEnumerable<Person> GetAll()
        {
            return _persons.ToList(); 
        }

        public void Add( Person p )
        {
            if( p == null )
            {
                throw new ArgumentNullException( "p" );
            }

            _persons.Add(p);
        }
    }
}
