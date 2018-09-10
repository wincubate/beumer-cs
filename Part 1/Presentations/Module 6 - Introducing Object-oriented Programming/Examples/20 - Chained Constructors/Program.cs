using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module06.Slide20Chained
{
    class Car
    {
        public string petName;
        public int currentSpeed;

        public Car()
            : this( "Chuck" )
        {
            Console.WriteLine( "This is Car() constructor" );
        }

        public Car( string petName )
            : this( petName, 0 )
        {
            Console.WriteLine( "This is Car( x ) constructor" );
        }

        public Car( string petName, int currentSpeed )
        {
            Console.WriteLine( "This is the core Car( x, y ) constructor" );

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
            Car chuck = new Car();
            chuck.PrintState();
        }
    }
}
