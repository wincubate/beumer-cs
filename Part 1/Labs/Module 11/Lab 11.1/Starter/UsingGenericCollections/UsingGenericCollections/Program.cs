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

            bool done = false;
            while( !done )
            {
                string s = Console.ReadLine();

                if( string.IsNullOrEmpty( s.Trim() ) )
                {
                    done = true;
                }

                // TODO: Insert string into generic list if not done
            }

            // TODO: Iterate through stored strings inserting their corresponding lengths into a generic queue of integers

            // TODO: Print out all these integers and their total sum

        }
    }
}
