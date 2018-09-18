using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{
   public class Subscriber
   {
      public Subscriber( string operationName, Func<int,int,int> f, Publisher publisher )
      {
         // TODO: Subscribe to publisher's Numbers event with an action producing
         //       console output similar to "5+7=12" when invoked with +
      }
   }
}
