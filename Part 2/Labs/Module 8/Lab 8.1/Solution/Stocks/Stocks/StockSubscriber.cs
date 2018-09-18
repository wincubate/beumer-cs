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
            Console.WriteLine($"Stock {e.Ticker} was on {e.TimeStamp} priced at {e.StockValue:f2}");
        }
    }
}
