using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wincubate.Module08.Data;

namespace Wincubate.Module08.Slide15
{
	class Program
	{
		static void Main(string[] args)
		{
			ProcessAccounts();

			Console.ReadLine();
		}

		async private static void ProcessAccounts()
		{
			Logger logger = new Logger(@"C:\Tmp\Log.txt");

			var from = Bank.CreateAccount(100);
			var to = Bank.CreateAccount(100);

			try
			{
				Bank.TransferFunds(from, 200, to);
			}
			catch (InsufficientFundsException e) when (e.Account?.IsVIP == true)
			{
				// Handle VIP account
				await logger.LogExceptionAsync(e);
			}
			finally
			{
				await logger.LogAsync("Completed processing of accounts");
			}
		}
	}
}
