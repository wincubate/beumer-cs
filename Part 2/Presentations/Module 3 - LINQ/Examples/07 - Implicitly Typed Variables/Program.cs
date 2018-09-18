using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module03.Slide07
{
    class Program
    {
        #region Reflect Over Query
        static void ReflectOverQueryResults( object query )
        {
            Console.WriteLine();
            Console.WriteLine( "Query is of type: {0}", query.GetType().Name );
            Console.WriteLine( "Query location: {0}", query.GetType().Assembly );
        }
        #endregion

        static void Main( string[] args )
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            IEnumerable<int> query = from i in numbers where i < 10 select i;

            foreach( int i in query )
            {
                Console.WriteLine( i );
            }

            // ReflectOverQueryResults(query);
        }
    }
}
