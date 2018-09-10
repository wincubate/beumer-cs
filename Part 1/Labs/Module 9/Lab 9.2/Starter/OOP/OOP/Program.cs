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

                // TODO 1: Use decimal.TryParse() instead
                decimal amount = decimal.Parse( input );

                if( Bank.TransferFunds( otherAccount, amount, account ) )
                {
                    Console.WriteLine( "Transferred funds from {0} to {1}",
                       otherAccount, account );
                }
            }
            catch( FormatException )
            {
                Console.WriteLine( "Input amount is not in correct format" );
            }
            catch( OverflowException )
            {
                Console.WriteLine( "Input amount is an exceedingly large-sized amount" );
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
