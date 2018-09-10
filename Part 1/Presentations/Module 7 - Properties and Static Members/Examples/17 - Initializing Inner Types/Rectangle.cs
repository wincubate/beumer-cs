using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module07.Slide17
{
    public class Rectangle
    {
        public Point TopLeft
        {
            get;
            set;
        }
        public Point BottomRight
        {
            get;
            set;
        }
        public override string ToString()
        {
            return string.Format( "[TopLeft: {0}, BottomRight: {1}]",
               TopLeft,
               BottomRight
            );
        }
    }
}
