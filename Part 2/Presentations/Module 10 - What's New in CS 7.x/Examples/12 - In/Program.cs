using System;
using static System.Math;

namespace Wincubate.CS7x.Slide12
{
    struct Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D( double x, double y, double z )
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString() => $"({X},{Y},{Z})";
    }

    class Program
    {
        static void Main( string[] args )
        {
            Point3D p1 = new Point3D { X = -1, Y = 0, Z = -1 };
            Point3D p2 = new Point3D { X = 1, Y = 2, Z = 3 };

            Console.WriteLine($"The distance between {p1} and {p2} is {CalculateDistance(p1, p2)}");
        }

        static double CalculateDistance( in Point3D first, in Point3D second = default )
        {
            double xDiff = first.X - second.X;
            double yDiff = first.Y - second.Y;
            double zDiff = first.Z - second.Z;

            return Sqrt(xDiff * xDiff + yDiff * yDiff + zDiff * zDiff);
        }
    }
}
