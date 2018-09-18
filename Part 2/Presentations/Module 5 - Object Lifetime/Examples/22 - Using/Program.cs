using System;

namespace Wincubate.Module05.Slide22
{
    class Program
    {
        static void Main( string[] args )
        {
            using( MyDisposableClass disp = new MyDisposableClass() )
            {
                //disp.DoStuff();

                // ...

                //disp.DoMoreStuff();
            }
        }
    }
}
