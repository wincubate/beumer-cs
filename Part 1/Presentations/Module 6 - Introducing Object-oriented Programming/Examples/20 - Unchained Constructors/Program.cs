using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module06.Slide20
{
    class Car
    {
        public string petName;
        public int currentSpeed;

        public Car()
        {
            petName = "Chuck";
            currentSpeed = 0;
        }
        public Car( string petName )
        {
            this.petName = petName;
        }
        public Car( string petName, int currentSpeed )
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
            Car chuck = new Car( "Chuck" );
            chuck.PrintState();
        }
    }
}
