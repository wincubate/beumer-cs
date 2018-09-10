using System;
using System.Collections;

namespace Wincubate.Module11.Slide21
{
    public class PetNameComparer : IComparer
    {
        int IComparer.Compare( object o1, object o2 )
        {
            if( o1 is Car && o2 is Car )
            {
                Car c1 = o1 as Car;
                Car c2 = o2 as Car;

                return string.Compare( c1.PetName, c2.PetName );
            }

            throw new ArgumentException( "Can only compare Car objects" );
        }
    }
}
