using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module11.Slide25
{
    interface IBinaryOperation<T> where T : struct
    {
        T Add( T arg1, T arg2 );
    }

    class IntegerMath : IBinaryOperation<int>
    {
        public int Add( int arg1, int arg2 )
        {
            return arg1 + arg2;
        }
    }

    class Program
    {
        static void Main( string[] args )
        {
        }
    }
}
