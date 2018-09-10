using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module08.Slide22
{
    class FrameworkClass
    {
        public void Clear()
        {
            // ...
        }
    }

    class MyClass : FrameworkClass
    {
        public new void Clear()
        {
        }
    }

    //abstract class Shape
    //{
    //   protected string shapeName = "";
    //}

    //class MyShape : Shape
    //{
    //   public new string shapeName = "";
    //}

    class Program
    {
        static void Main( string[] args )
        {
        }
    }
}
