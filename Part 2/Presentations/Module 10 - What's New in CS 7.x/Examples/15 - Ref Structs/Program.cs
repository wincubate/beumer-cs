using System;

namespace Wincubate.CS7x.Slide15
{
    struct Point3D
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

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
            Point3D point = new Point3D(1, 0, 1);
            object o = point;

            Console.WriteLine(o);
        }
    }
}
