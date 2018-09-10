using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module07.Slide07
{
    class BankAccount
    {
        private decimal _currentBalance;
        public static decimal CurrentInterestRate;

        static BankAccount()
        {
            CurrentInterestRate = 0.04m;
        }

        public BankAccount( decimal balance )
        {
            _currentBalance = balance;
        }

        public static void SetInterestRate( decimal interestRate )
        {
            CurrentInterestRate = interestRate;
        }

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

            BankAccount.SetInterestRate( 0.06m );

            ba1.PrintInterestRate();
            ba2.PrintInterestRate();
        }
    }
}
