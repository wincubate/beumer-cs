using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stocks
{
    public class StockChangedEventArgs : EventArgs
    {
        public string Ticker { get; }
        public double StockValue { get; }
        public DateTime TimeStamp { get; } = DateTime.Now;

        public StockChangedEventArgs( string ticker, double stockValue )
        {
            Ticker = ticker;
            StockValue = stockValue;
        }
    }
}
