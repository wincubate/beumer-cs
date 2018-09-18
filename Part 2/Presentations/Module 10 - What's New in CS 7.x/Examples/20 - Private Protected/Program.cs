using System;

namespace Wincubate.CS7x.Slide20
{
    class DerivedFromOtherAssembly : Library.ClassInOtherAssembly
    {
        public DerivedFromOtherAssembly( int x )
        {
            X = x;
        }
    }

    class Program
    {
        static void Main( string[] args )
        {
            var example = new DerivedFromOtherAssembly(87);
            //Console.WriteLine(example.X); // Not allowed!

            example.Print();
        }
    }
}
