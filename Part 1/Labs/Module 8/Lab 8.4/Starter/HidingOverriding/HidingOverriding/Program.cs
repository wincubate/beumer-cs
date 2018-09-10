using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HidingOverriding
{
    class A
    {
        public virtual void M()
        {
            Console.WriteLine( "A" );
        }
    }

    class B : A
    {
        public override void M()
        {
            Console.WriteLine( "B" );
        }
    }

    class C : B
    {
        new public virtual void M()
        {
            Console.WriteLine( "C" );
        }
    }

    class D : C
    {
        public override void M()
        {
            Console.WriteLine( "D" );
        }
    }

    class Program
    {
        public static void Main()
        {
            D d = new D();
            C c = d;
            B b = c;
            A a = b;

            d.M();
            c.M();
            b.M();
            a.M();
        }
    }
}
