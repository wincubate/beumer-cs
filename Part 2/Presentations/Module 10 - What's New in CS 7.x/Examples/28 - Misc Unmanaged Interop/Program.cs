using System;

namespace Wincubate.CS7x.Slide28
{
    unsafe struct S
    {
        public fixed int FixedField[10];
    }

    class Program
    {
        static S s;

        unsafe static void Main(string[] args)
        {
            //unsafe
            //{
            //    int* span = stackalloc int[] { 11, 22, 33 };
            //}

            // 1)
            Span<int> span = stackalloc int[] { 11, 22, 33 };

            // 2)
            int p = s.FixedField[5]; // No fixed required

            // 3)
            byte[] byteArray = new byte[10]; 
            fixed (byte* ptr = byteArray)
            {
                // ptr is a native pointer to the first element of the array
                // byteArray is protected from being moved/collected by the GC for the duration of this block 
            }
        }
    }
}
