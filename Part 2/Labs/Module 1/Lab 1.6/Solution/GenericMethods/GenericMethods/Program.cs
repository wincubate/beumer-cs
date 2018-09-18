using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericMethods
{
    class Program
    {
        static int GreaterCount<T>( IEnumerable<T> data, T threshold ) where T : IComparable<T>
        {
            int count = 0;

            foreach( T t in data )
            {
                if( t.CompareTo( threshold ) >= 0 )
                {
                    count++;
                }
            }

            return count;
        }

        static void Main( string[] args )
        {
            List<int> data1 = new List<int>();
            data1.Add( 42 );
            data1.Add( 87 );
            data1.Add( 31 );
            data1.Add( 112 );
            data1.Add( 256 );

            int threshold1 = 87;
            Console.WriteLine( "The number of elements in data1 greater than {0} is {1}",
               threshold1,
               GreaterCount( data1, threshold1 )
            );

            Stack<string> data2 = new Stack<string>();
            data2.Push( "Hello" );
            data2.Push( "World" );
            data2.Push( "C# 3.0" );
            data2.Push( "Anders Hejlsberg" );
            data2.Push( "Nando Rafael" );

            string threshold2 = "Lexicographic!";
            Console.WriteLine( "The number of elements in data2 greater than {0} is {1}",
               threshold2,
               GreaterCount( data2, threshold2 )
            );

            Queue<Car> data3 = new Queue<Car>();
            data3.Enqueue( new Car( "Det Blå Lyn", 156, "SB49024" ) );
            data3.Enqueue( new Car( "Familiebil", 60, "YY42977" ) );
            data3.Enqueue( new Car( "Goofy", 128, "RR22222" ) );
            data3.Enqueue( new Car( "Tandlægens bil", 80, "GAB OP" ) );

            Car threshold3 = new Car( "Bimmer", 220, "SKROT" );
            Console.WriteLine( "The number of elements in data3 greater than {0} is {1}",
               threshold3,
               GreaterCount( data3, threshold3 )
            );
        }
    }
}
