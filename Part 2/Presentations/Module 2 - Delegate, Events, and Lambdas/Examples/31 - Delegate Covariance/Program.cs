using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module02.Slide14
{
    class A
    {
    }

    class B : A
    {
    }

    delegate A ADelegate();

    class Program
    {
        static A AMethod()
        {
            return new A();
        }

        static B BMethod()
        {
            return new B();
        }

        static void Main( string[] args )
        {
            ADelegate del = AMethod;
            del += BMethod;

            //ADelegate del = new ADelegate( AMethod );
            //del += new ADelegate( BMethod );
        }
    }
}
