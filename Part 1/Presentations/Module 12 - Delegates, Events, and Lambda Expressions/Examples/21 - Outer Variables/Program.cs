using System;

namespace Wincubate.Module12.Slide21
{
    class Program
    {
        static void Main( string[] args )
        {
            int eventOccurrences = 0;
            Publisher p = new Publisher();

            Subscriber s1 = new Subscriber( "Ted", p );
            Subscriber s2 = new Subscriber( "Marshall", p );
            Subscriber s3 = new Subscriber( "Barney", p );

            p.NewInfo += delegate( object sender, NewInfoEventArgs e )
            {
                Console.WriteLine( "[Anonymous subscriber] New info: {0}", e.TimeStamp );
                eventOccurrences++;
            };

            for( int i = 0; i < 5; i++ )
            {
                Console.ReadLine();

                p.CreateNewInfo();
                Console.WriteLine( "There were {0} event(s) raised", eventOccurrences );
            }
        }
    }
}
