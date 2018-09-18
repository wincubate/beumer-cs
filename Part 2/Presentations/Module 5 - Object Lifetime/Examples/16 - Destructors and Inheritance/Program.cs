using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module05.Slide16
{
    class A
    {
        public A()
        {
            Console.WriteLine( "A()" );
        }
        ~A()
        {
            Console.WriteLine( "~A()" );
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine( "B()" );
        }
        ~B()
        {
            Console.WriteLine( "~B()" );
        }
    }

    class Program
    {
        static void Main()
        {
            B b = new B();
            b = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            // Wait
            Console.ReadLine();
        }
    }
}
