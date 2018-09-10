using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module07.Slide19
{
    class MyMathClass
    {
        public const double Pi = 3.14;
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine( MyMathClass.Pi );

            //MyMathClass.Pi = 22 / 7;

            //MyMathClass mmc = new MyMathClass();
        }
    }
}
