using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module12.Slide25
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string FullName
        {
            get
            {
                return string.Format( "{0} {1}", FirstName, LastName );
            }
        }

        public override string ToString()
        {
            return string.Format( "{0} is {1} year{2} old",
                FullName,
                Age,
                ( Age == 1 ? "" : "s" )
            );
        }
    }

    class Program
    {
        static void Main( string[] args )
        {
            Person ash = new Person { FirstName = "Bruce", LastName = "Campbell", Age = 57 };
            Console.WriteLine( ash );
        }
    }
}
