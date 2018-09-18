using System.Collections.Generic;
using System.Linq;

namespace Wincubate.Module08.Slide06
{
	class Program
	{
		static void Main(string[] args)
		{
			IEnumerable<int> numbers = Enumerable.Range( 0, 100 );
			var query = Enumerable.Where(numbers, i => i % 2 == 0);

			//System.Console.WriteLine( 87.IsPrime() );
			//System.Console.WriteLine( "jgh@wincubate.net".IsValidEmailAddress() );
		}
	}
}
