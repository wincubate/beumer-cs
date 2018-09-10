using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module08.Slide21
{
    abstract class Shape
    {
        protected string _shapeName = "";

        public abstract void Draw();
    }

    class Hexagon : Shape
    {
        public override void Draw()
        {
            Console.WriteLine( "Drawing the hexagon named {0}", _shapeName );
        }
    }

    //class Circle : Shape
    //{
    //   public Circle()
    //   {
    //   }
    //}

    class Program
    {
        static void Main( string[] args )
        {

        }
    }
}
