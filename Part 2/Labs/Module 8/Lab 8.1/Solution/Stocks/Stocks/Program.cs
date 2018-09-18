using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stocks
{
    class Program
    {
        static void Main( string[] args )
        {
            // TODO: Create publishers and subscriber
            StockPublisher p1 = new StockPublisher( "MSFT" );
            StockPublisher p2 = new StockPublisher( "WCB" );

            StockSubscriber subscriber = new StockSubscriber();
            subscriber.SubscribeTo( p1 );
            subscriber.SubscribeTo( p2 );

            Console.ReadLine();
        }
    }
}
