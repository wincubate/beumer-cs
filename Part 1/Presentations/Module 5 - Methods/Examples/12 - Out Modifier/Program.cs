﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module05.Slide13
{
    class Program
    {
        static void FillWithNumber( ref int x )
        {
            x = 87;
        }

        static void Main()
        {
            int k = 0;               // NB!
            FillWithNumber( ref k );
        }
    }
}
