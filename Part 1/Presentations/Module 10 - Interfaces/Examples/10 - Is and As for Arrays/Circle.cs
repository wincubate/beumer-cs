using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module11.Slide10
{
    public class Circle : Shape
    {
        public Circle()
        {
        }
        public Circle( string name )
            : base( name )
        {
        }

        public override void Draw()
        {
            Console.WriteLine( "Drawing {0} the Circle", shapeName );
        }
        public void Draw3D()
        {
            Console.WriteLine( "Drawing circle in 3D!" );
        }
    }
}
