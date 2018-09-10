using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module06.Slide21
{
    class Car
    {
        public string petName;
        public int currentSpeed;

        public Car( string petName = "Chuck", int currentSpeed = 0 )
        {
            this.petName = petName;
            this.currentSpeed = currentSpeed;
        }

        public void PrintState()
        {
            Console.WriteLine( "{0} is going {1} km/h", petName, currentSpeed );
        }

        public void SpeedUp( int delta )
        {
            currentSpeed += delta;
        }
    }

    class Program
    {
        static void Main()
        {
            Car alice = new Car( "Alice", 30 );
            Car bob = new Car( "Bob" );
            Car chuck = new Car( currentSpeed: 50 );
            chuck.PrintState();
        }
    }
}
