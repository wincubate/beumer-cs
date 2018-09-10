using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module07.Slide16
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point( int x = 0, int y = 0 )
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return string.Format( "({0},{1})", X, Y );
        }
    }
}
