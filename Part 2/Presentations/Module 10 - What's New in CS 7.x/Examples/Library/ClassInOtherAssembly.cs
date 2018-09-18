using System;
using System.Collections.Generic;
using System.Text;

namespace Wincubate.CS7x.Library
{
    public class ClassInOtherAssembly
    {
        protected internal int X { get; set; }
        //private protected int X { get; set; }

        public void Print() => Console.WriteLine(X);
    }

    public class DerivedClassInSameAssembly : ClassInOtherAssembly
    {
        public void InspectInDerivedClass()
        {
            Console.WriteLine(X);
        }
    }
}
