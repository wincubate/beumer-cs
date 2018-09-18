using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module07.Slide05
{
   class Program
   {
      static void Main( string[] args )
      {
         #region Create and Start

         Task task1 = new Task( () =>
         {
            for( int i = 0; i < 100; i += 2 )
            {
               Console.WriteLine( i );
            }
         });
         task1.Start();

         #endregion

         #region Start New

         Task task2 = Task.Factory.StartNew( () =>
         {
            for ( int i = 1 ; i < 100 ; i += 2 )
            {
               Console.WriteLine( "\t" + i );
            }
         });

         #endregion

         #region Run

         Task task3 = Task.Run( () =>
         {
            for ( int i = 0 ; i > -100 ; i -= 2 )
            {
               Console.WriteLine( "\t\t" + i );
            }
         } );

         #endregion
         
         Console.ReadLine();

         //task1.Wait();

         //Task.WaitAll( task1, task2, task3 );

         //Task.WaitAny( task1, task2, task3 );
      }
   }
}
