using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module04.Slide17
{
    class Program
    {
        static void Main( string[] args )
        {
            string s1 = "Hello!";
            string s2 = "Hello!";
            string t = "Yo!";

            Console.WriteLine( s1 == s2 );
            //Console.WriteLine(s1 == "Hello!");           
            //Console.WriteLine(s1 == "HELLO!");           
            //Console.WriteLine(s1.ToUpper() == "HELLO!"); 
            //Console.WriteLine(s1.Equals(t));           
            //Console.WriteLine("Yo!".Equals(t));        
        }
    }
}
