using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module07.Slide13
{
   class Program
   {
      static void Main( string[] args )
      {
         #region Continuation Tasks

         //Task<DateTime> t1 = new Task<DateTime>( () => DateTime.Now );
         //Task<string> t2 = t1.ContinueWith( previous => $"The time is {previous.Result}!" );

         //t1.Start();
         //Console.WriteLine( t2.Result );

         #endregion

         #region Nested Tasks

         //Task outer = Task.Factory.StartNew( () =>
         //{
         //   Console.WriteLine( "Outer task started" );
         //   Task task1 = Task.Factory.StartNew( () =>
         //   {
         //      Console.WriteLine( "Nested task 1 started" );
         //      for ( int i = 0 ; i < 100 ; i += 2 )
         //      {
         //         Console.WriteLine( i );
         //      }
         //      Console.WriteLine( "Nested task 1 ended" );
         //   } );
         //   Task task2 = Task.Factory.StartNew( () =>
         //   {
         //      Console.WriteLine( "Nested task 2 started" );
         //      for ( int i = 1 ; i < 100 ; i += 2 )
         //      {
         //         Console.WriteLine( "\t" + i );
         //      }
         //      Console.WriteLine( "Nested task 2 ended" );
         //   } );
         //} );

         //outer.Wait();
         //Console.WriteLine( "Outer task ended" );

         //Console.ReadLine();

         #endregion

         #region Child Tasks

         //Task outer = Task.Factory.StartNew( () =>
         //{
         //   Console.WriteLine( "Parent task started" );
         //   Task task1 = Task.Factory.StartNew( () =>
         //      {
         //         Console.WriteLine( "Child task 1 started" );
         //         for ( int i = 0 ; i < 100 ; i += 2 )
         //         {
         //            Console.WriteLine( i );
         //         }
         //         Console.WriteLine( "Child task 1 ended" );
         //      },
         //      TaskCreationOptions.AttachedToParent            
         //   );
         //   Task task2 = Task.Factory.StartNew( () =>
         //      {
         //         Console.WriteLine( "Child task 2 started" );
         //         for ( int i = 1 ; i < 100 ; i += 2 )
         //         {
         //            Console.WriteLine( "\t" + i );
         //         }
         //         Console.WriteLine( "Child task 2 ended" );
         //      },
         //      TaskCreationOptions.AttachedToParent
         //   );
         //} );

         //outer.Wait();
         //Console.WriteLine( "Parent task ended" );

         //Console.ReadLine();

         #endregion
      }
   }
}
