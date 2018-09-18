using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module08.Data
{
	[Serializable]
	public class InsufficientFundsException : Exception
	{
		public BankAccount Account
		{
			get { return _account; }
		}

		private readonly BankAccount _account;

		public InsufficientFundsException()
		{
		}

		public InsufficientFundsException(string message)
			: base(message)
		{
		}

		public InsufficientFundsException(string message, Exception inner)
			: base(message, inner)
		{
		}

		public InsufficientFundsException(string message, BankAccount account)
			: this(message)
		{
			_account = account;
		}
	}
}
