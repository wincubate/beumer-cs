using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module02.Slide04
{
    class SimpleMath
    {
        public static void Add( int i, int j )
        {
            Console.WriteLine( "{0} + {1} = {2}", i, j, i + j );
        }

        public static void Multiply( int i, int j )
        {
            Console.WriteLine( "{0} x {1} = {2}", i, j, i * j );
        }
    }

    public delegate void MathOperation( int i, int j );

    class Program
    {
        #region Hello
        //public static string SayHello(string name)
        //{
        //   return string.Format("Hello, {0}", name);
        //}

        //public delegate string HelloDelegate(string s);
        #endregion

        static void Main( string[] args )
        {
            MathOperation m = new MathOperation( SimpleMath.Multiply );
            m( 5, 7 );

            #region Invocation list
            //foreach( Delegate d in m.GetInvocationList() )
            //{
            //   Console.WriteLine( "Method Name: {0}", d.Method );
            //   Console.WriteLine( "Type Name: {0}", d.Target );
            //}
            #endregion

            #region Hello
            //HelloDelegate hello = new HelloDelegate(SayHello);
            //Console.WriteLine(hello("World"));
            #endregion
        }
    }
}
