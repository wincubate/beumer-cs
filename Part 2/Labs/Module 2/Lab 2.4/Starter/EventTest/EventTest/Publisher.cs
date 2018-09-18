using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{
   public class Publisher
   {
      public event EventHandler<NumbersEventArgs> Numbers;

      public Publisher()
      {
      }

      public void Start( IEnumerable<Tuple<int,int>> data )
      {
         // TODO: Raise Numbers with each number pair in data
      }
   }
}
