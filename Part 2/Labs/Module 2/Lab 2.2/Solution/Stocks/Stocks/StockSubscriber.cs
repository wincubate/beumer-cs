using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stocks
{
    public class StockSubscriber
    {
        public void SubscribeTo( StockPublisher p )
        {
            p.StockChanged += OnStockChanged;
        }

        private void OnStockChanged( object sender, StockChangedEventArgs e )
        {
            Console.WriteLine( "Stock {0} was on {1} priced at {2:f2}",
               e.Ticker,
               e.TimeStamp,
               e.StockValue );
        }
    }
}
