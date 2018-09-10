using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module08.Slide09
{
    class Car
    {
        public readonly int maxSpeed;
        private int currentSpeed;

        public int Speed
        {
            get
            {
                return currentSpeed;
            }
            set
            {
                currentSpeed += value;
                if( currentSpeed > maxSpeed )
                {
                    currentSpeed = maxSpeed;
                }
            }
        }

        public Car( int maxSpeed = 110 )
        {
            this.maxSpeed = maxSpeed;
        }
    }

    class MiniVan : Car
    {
        public MiniVan()
            : base( 90 )
        {
        }
    }

    class Program
    {
        static void Main( string[] args )
        {
            MiniVan van = new MiniVan();
            Console.WriteLine( van.maxSpeed );
        }
    }
}
