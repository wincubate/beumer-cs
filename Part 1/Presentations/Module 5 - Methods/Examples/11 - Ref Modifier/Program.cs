﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module05.Slide12
{
    class Program
    {
        static void Twice( ref int x )
        {
            x = 2 * x;
        }

        static void Main()
        {
            int i = 42;
            Twice( ref i );
            Console.WriteLine( i );
        }
    }
}
