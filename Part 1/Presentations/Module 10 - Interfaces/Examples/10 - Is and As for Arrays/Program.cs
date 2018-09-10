using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module11.Slide10
{
    class Program
    {
        static void Main( string[] args )
        {
            // Make an array of Shapes.
            Shape[] s = { new Circle( "Ceecee" ), new Triangle( "Titi" ), new Circle( "JoJo" ) };

            for( int i = 0; i < s.Length; i++ )
            {
                // Recall the Shape base class defines an abstract Draw()
                // member, so all shapes know how to draw themselves.
                s[ i ].Draw();

                // Who's pointy?
                if( s[ i ] is IPointy )
                {
                    IPointy p = s[ i ] as IPointy;
                    Console.WriteLine( "-> Points: {0}", p.Points );
                }
                else
                {
                    Console.WriteLine( "-> {0}\'s not pointy!", s[ i ].PetName );
                }
            }
        }
    }
}
