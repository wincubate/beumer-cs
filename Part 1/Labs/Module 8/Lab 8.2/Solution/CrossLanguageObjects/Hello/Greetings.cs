using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello
{
    // TODO 1: Inherit from Vb.Greetings
    class Greetings : Vb.Greetings
    {
        public override string Hello()
        {
            return base.Hello() + " " + DateTime.Now.ToLongTimeString();
        }
    }
}
