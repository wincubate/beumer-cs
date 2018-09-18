using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module03.Slide09
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
            List<int> numbers = new List<int> { 10, 20, 30, 40, 0, 1, 2, 3, 8 };
            var query = from i in numbers
                        where i < 10
                        select 87 / i;

            // numbers.Add(-112);

            try
            {
                foreach( var i in query )
                {
                    Console.WriteLine( i );
                }
            }
            catch( Exception exception )
            {
                Console.WriteLine( exception );
            }
        }
    }
}
