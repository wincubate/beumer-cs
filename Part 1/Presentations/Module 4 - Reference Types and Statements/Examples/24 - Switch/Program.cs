using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module04.Slide25
{
    enum Country
    {
        Denmark,
        Spain,
        Italy,
        Unspecified
    }

    public class Program
    {
        static void Main()
        {
            string club = "Real Madrid";
            Country country = Country.Unspecified;

            switch( club )
            {
                case "AGF":
                case "Brøndby":
                    {
                        country = Country.Denmark;
                        break;
                    }
                case "Real Madrid":
                    {
                        country = Country.Spain;
                        break;
                    }
                case "AC Milan":
                    {
                        country = Country.Italy;
                        break;
                    }
            }

            Console.WriteLine( "{0} is from {1}", club, country );

            // Wait for CR
            Console.ReadLine();
        }
    }
}
