using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module12.Slide18
{
    public class Publisher
    {
        public event EventHandler<NewInfoEventArgs> NewInfo;

        public void CreateNewInfo()
        {
            EventHandler<NewInfoEventArgs> del = NewInfo;
            if( del != null )
            {
                del( this, new NewInfoEventArgs() );
            }
        }
    }
}
