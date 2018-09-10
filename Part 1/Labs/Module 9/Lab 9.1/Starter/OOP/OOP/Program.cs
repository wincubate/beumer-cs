using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Program
    {
        static void Main( string[] args )
        {
            BankAccount account = Bank.CreateAccount( 176 );
            BankAccount otherAccount = Bank.CreateAccount( 1024 );

            // TODO 2: Add exception handling

            // TODO 1: Input amount to transfer

            if( Bank.TransferFunds( otherAccount, 555, account ) )
            {
                Console.WriteLine( "Transferred funds from {0} to {1}",
                   otherAccount, account );
            }
        }
    }
}
