﻿using System;
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
            from.Withdraw( amount );
            to.Deposit( amount );
        }
    }
}
