using System;

namespace Wincubate.Module02.Slide18
{
    class Program
    {
        static void Main( string[] args )
        {
            Publisher p = new Publisher();

            Subscriber s1 = new Subscriber( "Ted", p );
            Subscriber s2 = new Subscriber( "Marshall", p );

            for( int i = 0; i < 5; i++ )
            {
                Console.ReadLine();

                p.CreateNewInfo();
            }
        }
    }
}
