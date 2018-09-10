using System;

namespace Wincubate.Module10.Slide32
{
    class Program
    {
        static void Main( string[] args )
        {
            using( MyDisposableClass rw = new MyDisposableClass() )
            {
                //rw.Method1();

                // ...

                //rw.Methodn();
            }
        }
    }
}
