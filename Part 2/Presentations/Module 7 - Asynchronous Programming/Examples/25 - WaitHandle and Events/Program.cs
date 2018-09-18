using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wincubate.Module07.Slide25
{
   class A
   {
      public int Counter { get; private set; } = 0;

      public WaitHandle Signal
      {
         get
         {
            return _signal;
         }
      }
      ManualResetEvent _signal = new ManualResetEvent( false );

      public void MyThreadMethod( object o )
      {
         int count = (int)o;

         Random r = new Random( DateTime.Now.Millisecond );

         for ( int i = 0 ; i < count ; i++ )
         {
            int temp = Counter;
            Thread.Sleep( r.Next( 100 ) );
            Counter = temp + 1;

            Console.WriteLine(
               $"Counter = {Counter}. Thread: {Thread.CurrentThread.ManagedThreadId}"
            );

            Thread.Sleep( r.Next( 100 ) );
         }

         Console.WriteLine( "Thread complete" );

         _signal.Set();
      }
   }

   class Program
   {

      static void Main( string[] args )
      {
         A a1 = new A();
         A a2 = new A();
         A a3 = new A();

         Thread thread1 = new Thread( a1.MyThreadMethod );
         Thread thread2 = new Thread( a2.MyThreadMethod );
         Thread thread3 = new Thread( a3.MyThreadMethod );

         //thread1.IsBackground = true;
         //thread2.IsBackground = true;
         //thread3.IsBackground = true;

         thread1.Start( 42 );
         thread2.Start( 87 );
         thread3.Start( 112 );

         //WaitHandle[] waitHandles = { a1.Signal, a2.Signal, a3.Signal };
         //WaitHandle.WaitAll( waitHandles );

         Console.WriteLine( "Yahoooo! All threads have terminated... Exiting..." );
      }
   }
}
