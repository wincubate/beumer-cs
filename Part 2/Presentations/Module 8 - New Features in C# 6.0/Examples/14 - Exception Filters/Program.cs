using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wincubate.Module08.Data;

namespace Wincubate.Module08.Slide14
{
	class Program
	{
		static void Main(string[] args)
		{
			var from = Bank.CreateAccount(100);
			var to = Bank.CreateAccount(100);

			try
			{
				Bank.TransferFunds(from, 200, to);
			}
			catch (InsufficientFundsException e)
			{
				if (e.Account?.IsVIP == true )
				{
					// Handle VIP account
				}
				else
				{
					throw;
				}
			}
		}
	}
}
