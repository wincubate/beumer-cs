using static System.Console;

namespace Wincubate.CS7.Slide20
{
    class Program
    {
        static void Main( string[] args )
        {
            int[] numbers = { 1, 2, 4, 8, 16, 32, 64, 128 };


            #region Binary Literals and Separators

            //int[] numbers = { 0x1, 0x2, 0x4, 0x8, 0x10, 0x20, 0x40, 0x80 };

            //int[] numbers = {
            //    0b00_00_00_01,
            //    0b00_00_00_10,
            //    0b00_00_01_00,
            //    0b00_00_10_00,
            //    0b00_01_00_00,
            //    0b00_10_00_00,
            //    0b01_00_00_00,
            //    0b10_00_00_00,
            //};

            #endregion

            foreach (var i in numbers)
            {
                WriteLine(i);
            }
        }
    }
}
