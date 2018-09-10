using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module04.Slide15
{
    class Program
    {
        static void Main( string[] args )
        {
            string firstName = "Bruce";
            string lastName = "Campbell";

            string name = $"{firstName} {lastName}";

            Console.WriteLine( $"Hail to the king: {name}!");

        }
    }
}
