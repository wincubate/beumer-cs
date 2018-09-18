using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module02.Slide18
{
    public class Publisher
    {
        public event EventHandler<NewInfoEventArgs> NewInfo
        {
            add
            {
                _newInfo += value;

                Console.WriteLine( "{0} is subscribing", value.Target );
            }
            remove
            {
                _newInfo -= value;

                Console.WriteLine( "{0} is unsubscribing", value.Target );
            }
        }
        private EventHandler<NewInfoEventArgs> _newInfo;

        public void CreateNewInfo()
        {
            if( _newInfo != null )
            {
               _newInfo( this, new NewInfoEventArgs() );
            }
        }
    }
}
