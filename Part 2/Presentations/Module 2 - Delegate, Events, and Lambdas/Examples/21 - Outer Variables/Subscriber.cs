﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module02.Slide21
{
    public class Subscriber
    {
        public Subscriber( string name, Publisher publisher )
        {
            this.name = name;

            publisher.NewInfo += new EventHandler<NewInfoEventArgs>( PublisherUpdated );
        }

        protected void PublisherUpdated( object sender, NewInfoEventArgs e )
        {
            Console.WriteLine( "{0} received new info from publisher: {1}", name, e.TimeStamp );
        }

        private string name;
    }
}
