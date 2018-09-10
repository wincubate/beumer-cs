using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module12.Slide11
{
    public delegate void MyGenericDelegate<T>( T arg );

    class Program
    {
        static void Main( string[] args )
        {
            MyGenericDelegate<int> it = IntTarget;
            it( 87 );

            MyGenericDelegate<string> st = StringTarget;
            st( "Yo!" );
        }

        static void StringTarget( string arg )
        {
            Console.WriteLine( "arg in uppercase is: {0}", arg.ToUpper() );
        }

        static void IntTarget( int arg )
        {
            Console.WriteLine( "++arg is: {0}", ++arg );
        }
    }
}
