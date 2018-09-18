﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module02.Slide18
{
    public class NewInfoEventArgs : EventArgs
    {
        public NewInfoEventArgs()
        {
            _timeStamp = DateTime.Now;
        }

        public DateTime TimeStamp
        {
            get
            {
                return _timeStamp;
            }
        }
        private readonly DateTime _timeStamp;
    }
}
