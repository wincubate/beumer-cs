using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stocks
{
    public class StockChangedEventArgs : EventArgs
    {
        public string Ticker
        {
            get
            {
                return _ticker;
            }
        }
        private readonly string _ticker;

        public double StockValue
        {
            get
            {
                return _stockValue;
            }
        }
        private readonly double _stockValue;

        public DateTime TimeStamp
        {
            get
            {
                return _timeStamp;
            }
        }
        private readonly DateTime _timeStamp;

        public StockChangedEventArgs( string ticker, double stockValue )
        {
            _ticker = ticker;
            _stockValue = stockValue;
            _timeStamp = DateTime.Now;
        }
    }
}
