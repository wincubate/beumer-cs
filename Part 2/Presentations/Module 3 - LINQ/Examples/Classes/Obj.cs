
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module03.Classes
{
   public class Obj
   {
      public int x;
      public int y;

      public override string ToString()
      {
         return string.Format( "x = {0}, y = {1}",
            x,
            y
         );
      }
   }
}
