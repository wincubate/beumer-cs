using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module07.Slide05
{
    class BankAccount
    {
        private decimal _currentBalance;
        public static decimal CurrentInterestRate = 0.04m;

        public BankAccount( decimal balance )
        {
            _currentBalance = balance;
        }

        //public void SetInterestRateObj( decimal interestRate )
        //{
        //   CurrentInterestRate = interestRate;
        //}
        public void PrintInterestRate()
        {
            Console.WriteLine( "Interest rate is {0}", CurrentInterestRate );
        }
    }

    class Program
    {
        static void Main()
        {
            BankAccount ba1 = new BankAccount( 87 );
            BankAccount ba2 = new BankAccount( 112 );
            ba1.PrintInterestRate();
            ba2.PrintInterestRate();

            //ba1.SetInterestRateObj( 0.06 );
            //ba1.PrintInterestRate();
            //ba2.PrintInterestRate();
        }
    }
}
