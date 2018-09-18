using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module01.Classes
{
    public class Car
    {
        public string PetName { get; set; }
        public int CurrentSpeed { get; set; }

        public Car( string petName = "Chuck", int currentSpeed = 0 )
        {
            PetName = petName;
            CurrentSpeed = currentSpeed;
        }

        public void PrintState()
        {
            Console.WriteLine( "{0} is going {1} km/h", PetName, CurrentSpeed );
        }

        public void SpeedUp( int delta )
        {
            CurrentSpeed += delta;
        }
    }
}
