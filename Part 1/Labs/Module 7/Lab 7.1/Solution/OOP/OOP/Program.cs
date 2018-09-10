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
            BankAccount account = new BankAccount( 123456, 176 );
            account.Deposit( 87 );
            Console.WriteLine( account.Balance );
        }
    }
}
