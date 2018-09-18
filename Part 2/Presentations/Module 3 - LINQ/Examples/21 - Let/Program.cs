using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module03.Slide21
{
   class Program
   {
      static void Main( string[] args )
      {
         string[] sentences = 
         {
            "A penny saved is a penny earned",
            "The early bird catches the worm",
            "It's not safe to hope for the best without preparing for the worst",
            "The pen is mightier than the sword",
            "It's a trick. Get an axe"
         };

         var query =
             from sentence in sentences
             let words = sentence.Split( ' ' )
             orderby words.Length
             select sentence;

         foreach ( var s in query )
         {
            Console.WriteLine( s );
         }
      }
   }
}
