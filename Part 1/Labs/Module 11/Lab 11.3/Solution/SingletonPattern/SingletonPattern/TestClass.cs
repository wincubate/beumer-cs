using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern
{
    public class TestClass
    {
        public int X
        {
            get;
            set;
        }

        public TestClass()
        {
            Console.WriteLine( "TestClass.TestClass()" );
        }

        public void Display()
        {
            Console.WriteLine( "X = {0}", X );
        }
    }
}
