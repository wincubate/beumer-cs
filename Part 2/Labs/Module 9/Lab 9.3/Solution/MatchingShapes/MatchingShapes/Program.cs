using System;
using System.Collections.Generic;
using static System.Math;

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
                case Circle c when c.Radius is var r:
                    Console.WriteLine($"Area of circle with radius {r} is {PI * Pow(r, 2)}");
                    break;
                case Rectangle r when r.Width is var w && r.Height is var h:
                    Console.WriteLine($"Area of rectangle with width {w} and height {h} is {w * h}");
                    break;
                case object unknown:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Object of type {unknown.GetType()} was ignored");
                    Console.ResetColor();
                    break;
                case null:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please remove null values..!");
                    Console.ResetColor();
                    break;
            }
        }
    }
}
