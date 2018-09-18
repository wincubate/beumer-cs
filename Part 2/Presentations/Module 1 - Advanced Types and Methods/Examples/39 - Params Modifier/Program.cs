using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module01.Slide39
{
    class Program
    {
        #region Params
        //static int Sum(params int[] values)
        //{
        //   int total = 0;
        //   foreach (int i in values)
        //   {
        //      total += i;
        //   }
        //   return total;
        //}
        #endregion

        static int Sum( int a, int b )
        {
            return a + b;
        }

        static void Main()
        {
            Console.WriteLine( Sum( 42, 87 ) );
        }
    }
}
