using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Utility
{
    static class Extensions
    {
        public static bool IsEven( this int i )
        {
            return ( i % 2 == 0 );
        }

        public static string ToWincubateTimestamp( this DateTime dt )
        {
            return dt.ToString( "yyyy-MM-dd HH:mm:ss.fff" );
        }
    }
}
