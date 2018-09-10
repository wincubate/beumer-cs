using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module07.Slide13
{
    class Car
    {
        public string PetName { get; set; } = "Chuck";
        public int CurrentSpeed { get; set; } = 0;

//        public DateTime LastUpdated { get; } = DateTime.Now;

        public override string ToString()
        {
            return string.Format( "PetName = {0}", PetName );
        }
    }

    class Program
    {
        static void Main( string[] args )
        {
            Car c = new Car();

            //c.PetName = "Joooohn";

            Console.WriteLine( c );
            //Console.WriteLine(c.PetName);
            //Console.WriteLine(c.PetName.Length);
        }
    }
}
