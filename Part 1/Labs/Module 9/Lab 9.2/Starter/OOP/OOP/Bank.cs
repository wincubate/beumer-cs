using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    static class Bank
    {
        public static BankAccount CreateAccount( decimal initialAmount )
        {
            return new BankAccount( initialAmount );
        }

        public static bool TransferFunds( BankAccount from, decimal amount, BankAccount to )
        {
            if( from.Withdraw( amount ) )
            {
                to.Deposit( amount );

                return true;
            }

            return false;
        }
    }
}
