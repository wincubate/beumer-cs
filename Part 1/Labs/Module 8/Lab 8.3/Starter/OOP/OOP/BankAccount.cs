using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    public class BankAccount
    {
        private static int s_NextAccountNumber;

        static BankAccount()
        {
            s_NextAccountNumber = 100000;
        }

        private static int GetNextAccountNumber()
        {
            return s_NextAccountNumber++;
        }

        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            private set
            {
                _accountNumber = value;
            }
        }
        private int _accountNumber;

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            private set
            {
                _balance = value;
            }
        }
        private decimal _balance;

        public BankAccount()
            : this( 0 )
        {
        }

        public BankAccount( decimal initialBalance )
        {
            AccountNumber = GetNextAccountNumber();
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
