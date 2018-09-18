using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{
   public class NumbersEventArgs : EventArgs
   {
        public int X
        {
            get
            {
                return _x;
            }
        }
        private readonly int _x;

        public int Y
        {
            get
            {
                return _y;
            }
        }
        private readonly int _y;

        public NumbersEventArgs( int x, int y )
        {
            _x = x;
            _y = y;
        }
   }
}
