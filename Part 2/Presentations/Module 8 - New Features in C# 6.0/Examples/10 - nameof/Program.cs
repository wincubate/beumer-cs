using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wincubate.Module08.Data;

namespace Wincubate.Module08.Slide10
{
    class Program
    {
        static void Main(string[] args)
        {
			PersonRepository repository = new PersonRepository();
			IEnumerable<Person> persons = repository.GetAll();

			//repository.Add(null);

			//Person p = new Person();
   //         Console.WriteLine( nameof( Person.FullName ) );
        }
    }
}
