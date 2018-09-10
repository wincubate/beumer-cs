using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module10.Slide29
{
   class A
   {
      public A( int x )
      {
         this.x = x;
         counter++;
      }
      ~A()
      {
         counter--;
      }

      public int x;

      public static int counter = 0;
   }
}
