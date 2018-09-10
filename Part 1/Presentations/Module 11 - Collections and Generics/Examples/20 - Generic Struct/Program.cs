using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module11.Slide20
{
    public struct Point<T>
    {
        private T x;
        private T y;

        public Point( T x, T y )
        {
            this.x = x;
            this.y = y;
        }

        public T X
        {
            get
            {
                return x;
            }
        }
        public T Y
        {
            get
            {
                return y;
            }
        }

        public override string ToString()
        {
            return string.Format( "({0},{1})", x, y );
        }

        //public void Reset()
        //{
        //   x = default(T);
        //   y = default(T);
        //}
    }

    class Program
    {
        static void Main( string[] args )
        {
            Point<int> pt1 = new Point<int>( 42, 87 );
            //pt1.Reset();
            Console.WriteLine( pt1 );

            Point<double> pt2 = new Point<double>( 11.2, 8.7 );
            //pt2.Reset();
            Console.WriteLine( pt2 );

            Point<string> pt3 = new Point<string>( "Hello", "World" );
            //pt3.Reset();
            Console.WriteLine( pt3 );
        }
    }
}
