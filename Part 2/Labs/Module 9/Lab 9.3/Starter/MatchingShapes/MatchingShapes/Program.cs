using System;
using System.Collections.Generic;

namespace Wincubate.CS7.MatchingShapesLab
{
    class Program
    {
        static void Main( string[] args )
        {
            List<object> objects = new List<object>
            {
                new Circle( 3 ),
                null,
                new Rectangle( 4, 5 ),
                "Not really a shape",
                new Rectangle( 6, 7 ),
                new Circle( 8 )
            };

            objects.ForEach(ComputeArea);
        }

        static void ComputeArea( object o )
        {
            switch (o)
            {
                // TODO
            }
        }
    }
}
