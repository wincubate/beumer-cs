using System;
using System.Linq;
using System.Text;
using System.Collections.Specialized;

namespace Wincubate.Module11.Slide06
{
    class Program
    {
        static void Main( string[] args )
        {
            #region BitVector32
            BitVector32 v = new BitVector32( 15 );

            int bitMask = BitVector32.CreateMask();
            int i = 0;
            while( true )
            {
                Console.WriteLine( v[ bitMask ] );

                // v[bitMask] = !v[bitMask];

                i++;
                if( i < 32 )
                {
                    bitMask = BitVector32.CreateMask( bitMask );
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine( v.Data );
            #endregion
        }
    }
}
