using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    public class BankAccount
    {
        public int AccountNumber { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccount( int accountNumber, decimal initialBalance = 0 )
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit( decimal amount )
        {
            Balance += amount;
        }

        public bool Withdraw( decimal amount )
        {
            if( Balance >= amount )
            {
                Balance -= amount;

                return true;
            }

            return false;
        }
    }
}
