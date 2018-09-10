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

            try
            {
                Console.WriteLine( "Input amount to be transferred: " );
                string input = Console.ReadLine();

                decimal amount;
                if( decimal.TryParse( input, out amount ) )
                {
                    Bank.TransferFunds( otherAccount, amount, account );

                    Console.WriteLine( "Transferred funds from {0} to {1}",
                       otherAccount, account );
                }
                else
                {
                    Console.WriteLine( "Input amount can be recognized as a legal number to transfer" );
                }
            }
            catch( BankException exception )
            {
                string details = string.Empty;

                Exception innerException = exception.InnerException;
                if( innerException != null )
                {
                    details = string.Format( "Reason: {0}", innerException.Message );
                }

                Console.WriteLine( "{0}. {1}",
                   exception.Message,
                   details );
            }
            catch
            {
                Console.WriteLine( "An internal error has happened" );
            }
            finally
            {
                Console.WriteLine( "Ending processing of amount" );
            }
        }
    }
}
