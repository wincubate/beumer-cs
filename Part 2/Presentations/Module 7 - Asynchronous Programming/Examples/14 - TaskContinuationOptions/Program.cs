using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module07.Slide14
{
   class Program
   {
      static void Main( string[] args )
      {
         Task<DateTime> t1 = new Task<DateTime>( () => DateTime.Now );
         Task<string> t2 = t1.ContinueWith(
            previous => $"The time is {previous.Result}!",
            TaskContinuationOptions.OnlyOnRanToCompletion
         );
         Task t3 = t2.ContinueWith(
            previous => Console.WriteLine( "Error occured!" ),
            TaskContinuationOptions.OnlyOnFaulted
         );

         t1.Start();

         //t2.Wait();
         //t3.Wait();
         
         Console.WriteLine( t2.Result );

         Console.ReadLine();
      }
   }
}
