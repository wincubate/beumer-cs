using System;
using System.Threading;
using System.Threading.Tasks;

namespace Wincubate.Module07.Slide24
{
   class A
   {
      public int Counter { get; private set; } = 0;

      public void MyTaskMethod()
      {
         Random r = new Random(DateTime.Now.Millisecond);

         for (int i = 0; i < 50; i++)
         {
            int temp = Counter;
            Thread.Sleep(r.Next(10));
            Counter = temp + 1;

            Console.WriteLine(
                $"Counter = {Counter}. Thread: {Thread.CurrentThread.ManagedThreadId}"
            );

            Thread.Sleep(r.Next(10));
         }

         Console.WriteLine("Task complete");
      }
   }

   class Program
   {
      static void Main(string[] args)
      {
         A a = new A();

         Task t1 = Task.Factory.StartNew( a.MyTaskMethod );
         Task t2 = Task.Factory.StartNew( a.MyTaskMethod );

         Console.ReadLine();
      }
   }
}
