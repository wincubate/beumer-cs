using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module01.Slide13
{
	class Program
	{
		static void M(int? i)
		{
			Console.WriteLine( "int?" );
		}

		static void M(bool? b)
		{
			Console.WriteLine("int?");
		}

		static void Main(string[] args)
		{
			int? i = null;
			M(i);
		}
	}
}
