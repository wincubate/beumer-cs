using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Wincubate.Module08.Data
{
    public class StockPublisher
    {
        public string Ticker { get; set; }
        public event EventHandler<StockChangedEventArgs> StockChanged;

        public StockPublisher( string ticker )
        {
            Ticker = ticker;

            Initialize();
        }

        protected void OnStockChanged( double stockValue )
        {
            EventHandler<StockChangedEventArgs> del = StockChanged;
            if (del != null)
            {
                del(this, new StockChangedEventArgs(Ticker, stockValue));
            }
        }

        #region Timing

        Timer _timer;
        Random _random;
        double _currentValue;

        private void Initialize()
        {
            _random = new Random( this.GetHashCode() );
            _currentValue = _random.NextDouble() * 2000;
            _timer = new Timer( Tick, null, 1000 + _random.Next( 1000 ), 2000 + _random.Next( 2000 ) );
        }

        private void Tick( object state )
        {
            _currentValue += ( _random.NextDouble() - 0.5 );

            OnStockChanged( _currentValue );
        }

        #endregion
    }
}
