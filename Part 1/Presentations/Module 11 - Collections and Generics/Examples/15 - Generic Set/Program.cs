﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wincubate.Module11.Classes;

namespace Wincubate.Module11.Slide15
{
    class Program
    {
        static void Main( string[] args )
        {
            HashSet<int> set = new HashSet<int>();
            set.Add( 42 );
            set.Add( 87 );
            set.Add( 42 );
            set.Add( 176 );
            set.Add( 87 );
            set.Add( 112 );

            set.Remove( 42 );

            foreach( int i in set )
            {
                Console.WriteLine( i );
            }
        }
    }
}
