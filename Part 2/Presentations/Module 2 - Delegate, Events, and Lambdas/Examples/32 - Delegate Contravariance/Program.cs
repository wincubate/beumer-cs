using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module02.Slide32
{
    class A
    {
    }

    class B : A
    {
    }

    delegate void DelegateA( A a );
    delegate void DelegateB( B b );

    class Program
    {
        static void MethodA( A a )
        {
            Console.WriteLine( a );
        }

        static void MethodB( B b )
        {
            Console.WriteLine( b );
        }

        static void Main( string[] args )
        {
            DelegateA delA = MethodA;
            DelegateB delB = MethodA;   // Contravariance

            //DelegateA delA = new DelegateA( MethodA );
            //DelegateB delB = new DelegateB( MethodA ); // Contravariance
        }
    }
}
