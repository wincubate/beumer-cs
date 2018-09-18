using System;
using System.Collections.Generic;
using System.Linq;
using Wincubate.Module08.Data;

namespace Wincubate.Module08.Slide08
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonRepository repository = new PersonRepository();
            IEnumerable<Person> persons = repository.GetAll();

            // Write name of first person (or "No name" if none)
            if (persons != null)
            {
                Person p = persons.FirstOrDefault();
                if (p != null)
                {
                    Console.WriteLine(p.FullName);
                }
                else
                {
                    Console.WriteLine("No name");
                }
            }
            else
            {
                Console.WriteLine("No name");
            }

			//foreach (var p in persons )
			//{
			//	Console.WriteLine( p.FullName );
			//}
        }
    }
}
