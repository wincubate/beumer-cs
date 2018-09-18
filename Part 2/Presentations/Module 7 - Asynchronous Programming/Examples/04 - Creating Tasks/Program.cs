using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module07.Slide04
{
   class Program
   {
      static void Main( string[] args )
      {
         Task task1 = new Task( Method1 );
         Task task2 = new Task( delegate
                                {
                                   Console.WriteLine( "Hello from task2" );
                                }
         );
         Task task3 = new Task( () => Console.WriteLine( "Hello from task3" ) );
         
         Console.ReadLine();
      }

      static void Method1()
      {
         Console.WriteLine( "Hello from task1" );
      }
   }
}
