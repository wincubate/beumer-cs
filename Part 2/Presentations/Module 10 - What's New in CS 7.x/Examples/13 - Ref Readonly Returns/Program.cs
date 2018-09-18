using System;
using static System.Console;

namespace Wincubate.CS7x.Slide13
{
    class Program
    {
        static ref int FindMax( int[] numbers )
        {
            int indexOfMax = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[indexOfMax])
                {
                    indexOfMax = i;
                }
            };

            return ref numbers[indexOfMax];
        }

        static void Main( string[] args )
        {
            int[] numbers = { 112, 176, 42, 87, 99 };

            ref int max = ref FindMax(numbers);
            WriteLine($"{nameof(max)} is now {max}");

            max = 1000;

            //int maxCopy = FindMax(numbers); // Copy
            //maxCopy = 999999;

            WriteLine("Numbers are:");
            foreach (int i in numbers)
            {
                WriteLine(i);
            }

            #region Shocker!

            //FindMax(numbers) = 99999;

            #endregion
        }
    }
}
