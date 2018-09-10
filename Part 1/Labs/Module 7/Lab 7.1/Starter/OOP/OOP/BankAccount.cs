using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    public class BankAccount
    {
        private int _accountNumber;
        private decimal _balance;

        public BankAccount( int accountNumber, decimal initialBalance = 0)
        {
            _accountNumber = accountNumber;
            _balance = initialBalance;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Deposit( decimal amount )
        {
            _balance += amount;
        }

        public bool Withdraw( decimal amount )
        {
            if( _balance >= amount )
            {
                _balance -= amount;

                return true;
            }

            return false;
        }
    }
}
