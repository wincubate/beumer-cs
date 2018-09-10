using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    class Square : Rectangle
    {
        public Square( double width ) : base( width, width )
        {
        }

        public override string ToString()
        {
            return "Kvadrat med Sidelængde " + Width;
        }
    }
}
