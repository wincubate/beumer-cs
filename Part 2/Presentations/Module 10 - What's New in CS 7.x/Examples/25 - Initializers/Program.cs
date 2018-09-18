using System;

namespace Wincubate.CS7x.Slide25
{
    class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point( int x, int y ) => (X, Y) = (x, y); // New in C# 7.0
        public void Deconstruct( out int x, out int y ) => (x, y) = (X, Y);

        public override string ToString() => $"({X},{Y})";
    }

    class Base
    {
        public int Coordinate { get; } = int.TryParse("hello", out int x) ? x : default;

        public Base( int coordinate = default ) => Coordinate = coordinate;
    }

    class Derived : Base
    {
        public Derived( object o ) : base(o is Point p ? p.X : default)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(1, 2);
            Console.WriteLine(p);
        }
    }
}
