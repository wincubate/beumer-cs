using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class BankException : Exception
    {
        public BankException()
        {
        }

        public BankException( string message )
            : base( message )
        {
        }

        public BankException( string message, Exception inner )
            : base( message, inner )
        {
        }
    }
}
