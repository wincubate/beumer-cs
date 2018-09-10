using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module07.Slide20
{
    class MyMathClass
    {
        public MyMathClass()
        {
            if( DateTime.Today.Day % 2 == 0 )
            {
                TodaysPi = 3.14;
            }
            else
            {
                TodaysPi = 22.0 / 7;
            }
        }

        //public void SetTodaysPi( double tp )
        //{
        //   TodaysPi = tp;
        //}

        public readonly double TodaysPi;
    }

    class Program
    {
        static void Main()
        {
            MyMathClass mmc = new MyMathClass();
            Console.WriteLine( mmc.TodaysPi );

            //mmc.TodaysPi = 4.00;
        }
    }
}
