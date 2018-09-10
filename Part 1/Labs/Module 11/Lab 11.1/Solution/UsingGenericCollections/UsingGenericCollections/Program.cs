using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingGenericCollections
{
    class Program
    {
        static void Main( string[] args )
        {
            // TODO: Initialize generic list of strings
            List<string> list = new List<string>();

            bool done = false;
            while( !done )
            {
                string s = Console.ReadLine();

                if( string.IsNullOrEmpty( s.Trim() ) )
                {
                    done = true;
                }
                else
                {
                    // TODO: Insert string into generic list if not done
                    list.Add( s );
                }
            }

            // TODO: Iterate through stored strings inserting their corresponding lengths into a generic queue of integers
            Queue<int> queue = new Queue<int>();
            foreach( string s in list )
            {
                queue.Enqueue( s.Length );
            }

            // TODO: Print out all these integers and their total sum
            int total = 0;
            foreach( int i in queue )
            {
                Console.WriteLine( i );
                total += i;
            }

            Console.WriteLine( "Total length of strings is {0}", total );
        }
    }
}
