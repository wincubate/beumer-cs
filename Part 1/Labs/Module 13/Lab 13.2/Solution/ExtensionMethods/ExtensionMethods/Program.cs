using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wincubate.Utility;

namespace ExtensionMethods
{
    class Program
    {
        static void Main( string[] args )
        {
           Console.WriteLine( 87.IsEven() );

           Console.WriteLine( DateTime.Now.ToWincubateTimestamp() );
        }
    }
}
