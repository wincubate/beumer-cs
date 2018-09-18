using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module02.Slide29
{
   class Program
   {
      static void Main( string[] args )
      {
         // Assignment Compatibility
         string s = "Hello, World!";
         object o = s;

         // Covariance
         IEnumerable<string> strings = new List<string>();
         IEnumerable<object> objects = strings;

         // Contravariance
         Action<object> objectAction = DoStuff;
         Action<string> stringAction = objectAction;
      }

      static void DoStuff( object o )
      {
         // ...
      }
   }
}
