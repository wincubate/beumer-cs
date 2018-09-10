﻿using System;
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
           get;
           private set;
        }

        public decimal Balance
        {
           get;
           private set;
        }
        
        public BankAccount()
            : this( 0 )
        {
        }

        public BankAccount( decimal initialBalance )
        {
            AccountNumber = GetNextAccountNumber();
            Balance = initialBalance;
        }

        public override string ToString()
        {
            return string.Format( "Account Number {0} containing {1}",
               AccountNumber,
               Balance );
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
