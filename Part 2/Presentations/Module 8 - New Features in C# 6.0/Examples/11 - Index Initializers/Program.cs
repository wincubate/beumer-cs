using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wincubate.Module08.Data;

namespace Wincubate.Module08.Slide11
{
	#region LineUp

	//class LineUp : Dictionary<int, Person>
	//{
	//	public LineUp()
	//	{
	//		Add(19, new Person { FirstName = "Søren", LastName = "Larsen", Age = 34 });
	//	}
	//}

	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			var lineUp = new Dictionary<int, Person>
			{
				{ 19, new Person { FirstName = "Kim", LastName = "Aabech", Age = 31 } },
				{ 26, new Person { FirstName = "Morten", LastName = "Nordstrand", Age = 31 } },
				{ 6, new Person { FirstName = "Daniel", LastName = "Christensen", Age = 26 } }
			};

			foreach (var kv in lineUp)
			{
				Console.WriteLine( kv.Value.FullName );
			}
		}
	}
}
