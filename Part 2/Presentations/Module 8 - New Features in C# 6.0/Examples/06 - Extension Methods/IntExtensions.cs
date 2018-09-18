using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Wincubate.Lib
{
	static class IntExtensions
	{
		public static bool IsPrime(this int number)
		{
			if ((number % 2) == 0)
			{
				return number == 2;
			}
			int sqrt = (int)Math.Sqrt(number);
			for (int t = 3; t <= sqrt; t = t + 2)
			{
				if (number % t == 0)
				{
					return false;
				}
			}
			return number != 1;
		}
	}

	static class StringExtensions
	{
		public static bool IsValidEmailAddress(this string s)
		{
			Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
			return regex.IsMatch(s);
		}
	}
}
