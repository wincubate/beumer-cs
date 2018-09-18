using System;
using System.Runtime.InteropServices;

namespace Wincubate.Module05.Slide12
{
    class Program
    {
        static void Main(string[] args)
        {
            IntPtr buffer = IntPtr.Zero;
            int bufferSize = 2073600 * sizeof(int);

            try
            {
                buffer = Marshal.AllocHGlobal(bufferSize);
                GC.AddMemoryPressure(bufferSize);

                // ...Use the buffer...
            }
            finally
            {
                if (buffer != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(buffer);
                    GC.RemoveMemoryPressure(bufferSize);
                }
            }
        }
    }
}
