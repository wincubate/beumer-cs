using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module07.Slide26
{
   class Program
   {
      static void Main( string[] args )
      {
         int countOfItems = 1000;
         ConcurrentQueue<int> queue = new ConcurrentQueue<int>();

         Task producer = Task.Factory.StartNew(
            () =>
            {
               Random r = new Random();
               for ( int i = 0 ; i < countOfItems ; i++ )
               {
                  queue.Enqueue( r.Next( 1000000 ) );
               }
            }
         );

         Task consumer = Task.Factory.StartNew(
            () =>
            {
               for ( int i = 0 ; i < countOfItems ; )
               {
                  int number;
                  if( queue.TryDequeue( out number ) )
                  {
                     List<int> factors = PrimeHelper.GetPrimeFactors( number );

                     Console.WriteLine(
                        $"{number} = {string.Join("*", PrimeHelper.GetPrimeFactors(number))}" );
                     i++;
                  }
               }
            }
         );

         Task.WaitAll( producer, consumer );
      }
   }
}
