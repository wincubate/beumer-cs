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

        public static void TransferFunds( BankAccount from, decimal amount, BankAccount to )
        {
            try
            {
                from.Withdraw( amount );
                to.Deposit( amount );
            }
            catch( InsufficientFundsException exception )
            {
                throw new BankException(
                   string.Format( "Could not complete transfer of {1} from {0} to {2}",
                      from,
                      amount,
                      to ),
                   exception );
            }
        }
    }
}
