using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module07.Slide13
{
    class Car
    {
        public string PetName
        {
            get
            {
                return _petName;
            }
            set
            {
                _petName = value;
            }
        }
        private string _petName;

        public override string ToString()
        {
            // No access to the private member in the defining
            // class. Must use properties!
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
