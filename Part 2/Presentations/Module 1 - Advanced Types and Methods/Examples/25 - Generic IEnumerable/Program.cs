using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wincubate.Module01.Classes;

namespace Wincubate.Module01.Slide25
{
   public class Garage : IEnumerable<Car>
   {
      private Car[] carArray = new Car[ 4 ];
      public Garage()
      {
         carArray[ 0 ] = new Car( "FeeFee", 200 );
         carArray[ 1 ] = new Car( "Clunker", 90 );
         carArray[ 2 ] = new Car( "Zippy", 30 );
         carArray[ 3 ] = new Car( "Fred", 30 );
      }

      #region IEnumerable Members

      IEnumerator IEnumerable.GetEnumerator()
      {
         return ( this as IEnumerable<Car> ).GetEnumerator();
      }

      #endregion

      #region IEnumerable<Car> Members

      public IEnumerator<Car> GetEnumerator()
      {
         int i = 0;
         while( true )
         {
            yield return carArray[ i++ ];
            if( i == carArray.Length )
            {
               yield break;
            }
         }      
      }

      #endregion
   }
   
   class Program
   {
      static void Main( string[] args )
      {
         Garage garage = new Garage();
         foreach ( Car car in garage )
         {
            Console.WriteLine( car.PetName );
         }
      }
   }
}
