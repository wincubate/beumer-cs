using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main( string[] args )
        {
            Dictionary<int, string> places = new Dictionary<int, string>()
            {
                {1, "Charlotte" },
                {3, "Tim" },
                {4, "Anne-Mette" },
                {6, "Karl Erik" }
            };

            foreach (var x in places)
            {
                Console.WriteLine( $"{x.Value} sidder på plads {x.Key}" );
            }
        }
    }
}
