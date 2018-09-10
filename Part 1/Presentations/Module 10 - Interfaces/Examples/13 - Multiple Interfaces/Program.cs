using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module11.Slide13
{
    interface IDrawable
    {
        void Draw();
    }

    interface IPrintable
    {
        void Print();
        void Draw();
    }

    interface IRenderToMemory
    {
        void Render();
    }

    class SuperShape : IDrawable, IPrintable, IRenderToMemory
    {
        public void Draw()
        {
            Console.WriteLine( "Drawing..." );
        }
        public void Print()
        {
            Console.WriteLine( "Printing..." );
        }
        public void Render()
        {
            Console.WriteLine( "Render..." );
        }
    }

    class Program
    {
        static void Main( string[] args )
        {
            SuperShape ss = new SuperShape();
            ss.Draw();

            IPrintable printable = ss as IPrintable;
            printable.Print();
        }
    }
}
