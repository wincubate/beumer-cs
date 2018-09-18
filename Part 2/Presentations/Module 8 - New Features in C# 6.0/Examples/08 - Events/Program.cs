using System;
using Wincubate.Module08.Data;

namespace Wincubate.Module08.Slide08
{
    class Program
    {
        static void Main( string[] args )
        {
			StockPublisher p1 = new StockPublisher("MSFT");
            StockPublisher p2 = new StockPublisher( "MY" );

            p1.StockChanged += StockHandler;
            p2.StockChanged += StockHandler;

            Console.ReadLine();
        }

        private static void StockHandler(object sender, StockChangedEventArgs e)
        {
            Console.WriteLine("Stock {0} was on {1} priced at {2:f2}",
               e.Ticker,
               e.TimeStamp,
               e.StockValue);
        }
    }
}
