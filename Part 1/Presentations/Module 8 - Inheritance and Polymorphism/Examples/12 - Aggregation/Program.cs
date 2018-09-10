using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module08.Slide12
{
    class Car
    {
        Wheel[] wheels;
        Radio radio;

        public int MaxSpeed { get; protected set; }

        public Car( int maxSpeed = 110 )
        {
            wheels = new Wheel[ 4 ];
            radio = new Radio();

            MaxSpeed = maxSpeed;
        }
    }

    class Wheel
    {
        // ...
    }

    class Radio
    {
        // ...
    }

    class Program
    {
        static void Main( string[] args )
        {
            Car car = new Car();
        }
    }
}
