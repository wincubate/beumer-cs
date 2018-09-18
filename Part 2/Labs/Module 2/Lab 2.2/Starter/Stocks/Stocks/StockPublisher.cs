﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Stocks
{
    public class StockPublisher
    {
        private string _ticker;

        public StockPublisher( string ticker )
        {
            _ticker = ticker;

            Initialize();
        }

        // TODO: Define StockChanged event

        protected void OnStockChanged( double stockValue )
        {
            // TODO: Raise StockChanged event
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
