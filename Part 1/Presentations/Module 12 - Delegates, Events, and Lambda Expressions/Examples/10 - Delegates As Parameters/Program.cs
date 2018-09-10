using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module12.Slide10
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

        //public static string SayHello( string name )
        //{
        //    return string.Format( "Hello, {0}", name );
        //}
        //public static string StreetGreeting( string name )
        //{
        //    return string.Format( "Yo, yo, yoooo! Wassup, {0}?", name );
        //}
        //public delegate string HelloDelegate( string s );

        #endregion

        static void ShowInvocationList( Delegate del )
        {
            foreach( Delegate d in del.GetInvocationList() )
            {
                Console.WriteLine( "Method Name: {0}", d.Method );
                Console.WriteLine( "Type Name: {0}", d.Target );
            }
        }

        static MathOperation CreateDelegate()
        {
            return SimpleMath.Add;
        }

        static void Main( string[] args )
        {
            MathOperation m = CreateDelegate();
            m( 5, 7 );

            ShowInvocationList( m );

            #region Hello
            //HelloDelegate hello = SayHello;
            //hello += StreetGreeting;
            //Console.WriteLine( hello( "World" ) );
            #endregion
        }
    }
}
