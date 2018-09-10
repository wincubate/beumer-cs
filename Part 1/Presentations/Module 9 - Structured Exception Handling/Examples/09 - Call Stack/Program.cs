using System;

namespace Wincubate.Module09.Slide09
{
    class Program
    {
        static void Main()
        {
            A();

            Console.WriteLine( "Exiting Main" );

            // Wait for CR
            Console.ReadLine();
        }
        static void A()
        {
            B();

            Console.WriteLine( "Exiting A" );
        }
        static void B()
        {
            C();

            Console.WriteLine( "Exiting B" );
        }
        static void C()
        {
            int k = 87;
            int i = 100 / ( k - 87 );

            Console.WriteLine( "Exiting C" );
        }
    }
}
