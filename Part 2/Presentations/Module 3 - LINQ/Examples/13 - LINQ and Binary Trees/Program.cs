using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module03.Slide13
{
    class Program
    {
        static void Main( string[] args )
        {
            Node<int> tree = new Node<int>(
               42,
               new Node<int>( 87, new Node<int>( 112 ), new Node<int>( 176 ) ),
               new Node<int>( 256 )
            );

            var query = from i in tree
                        where i % 2 == 0
                        select i;

            foreach ( var i in query )
            {
               Console.WriteLine( i );
            }

            //foreach( int i in node )
            //{
            //    Console.WriteLine( i );
            //}

            //Console.WriteLine();

            //foreach( int i in node.Postfix() )
            //{
            //    Console.WriteLine( i );
            //}
        }
    }
}
