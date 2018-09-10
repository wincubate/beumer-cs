using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    class Circle : Shape
    {
        public double Radius
        {
            get;
            protected set; 
        }

        public Circle( double radius )
        {
            Radius = radius;
        }

        public override string ToString()
        {
            return "Cirkel med Radius " + Radius;
        }

        public override double Area
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }
    }
}
