using System;

namespace Wincubate.Module11.Slide07
{
    public interface IPointy
    {
        int Points
        {
            get;
        }
    }

    public class Triangle : Shape // , IPointy
    {
        public Triangle()
        {
        }
        public Triangle( string name )
            : base( name )
        {
        }
        public override void Draw()
        {
            Console.WriteLine( "Drawing {0} the Triangle", PetName );
        }
    }

    class Program
    {
        static void Main( string[] args )
        {
        }
    }
}
