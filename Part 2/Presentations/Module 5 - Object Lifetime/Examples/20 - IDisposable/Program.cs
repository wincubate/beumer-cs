using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module05.Slide20
{
    class Program
    {
        static void Main( string[] args )
        {
            MyDisposableClass disp = new MyDisposableClass();
            disp.Dispose();

            // Don't call Dispose(), this will trigger the finalizer
            // and cause a beep.
            MyDisposableClass disp2 = new MyDisposableClass();
        }
    }
}
