using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module14.Classes
{
    public class Car
    {
        public string PetName { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }
        public string Make { get; set; }

        public Car( string petName = "", int speed = 0 )
        {
            PetName = petName;
            Speed = speed;
        }

        public override string ToString()
        {
            return PetName;
        }
    }
}
