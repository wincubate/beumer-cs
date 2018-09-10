using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern
{
    class Program
    {
        static void Main( string[] args )
        {
            TestClass t1 = Singleton<TestClass>.Instance;
            t1.X = 42;

            TestClass t2 = Singleton<TestClass>.Instance;
            t2.Display();
        }
    }
}
