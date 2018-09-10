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

            Console.WriteLine( "Input amount to be transferred: " );
            string input = Console.ReadLine();

            // TODO 1: Use decimal.TryParse() instead
            decimal amount;
            if( decimal.TryParse( input, out amount ) )
            {
                if( Bank.TransferFunds( otherAccount, amount, account ) )
                {
                    Console.WriteLine( "Transferred funds from {0} to {1}",
                       otherAccount, account );
                }
            }
            else
            {
                Console.WriteLine( "Input amount can be recognized as a legal number to transfer" );
            }
        }
    }
}
