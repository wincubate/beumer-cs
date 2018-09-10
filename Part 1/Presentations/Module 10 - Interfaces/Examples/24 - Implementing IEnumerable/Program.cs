using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Wincubate.Module11.Slide24
{
    public class Garage : IEnumerable
    {
        private Car[] carArray = new Car[ 4 ];
        public Garage()
        {
            carArray[ 0 ] = new Car( "FeeFee", 200 );
            carArray[ 1 ] = new Car( "Clunker", 90 );
            carArray[ 2 ] = new Car( "Zippy", 30 );
            carArray[ 3 ] = new Car( "Fred", 30 );
        }

        public IEnumerator GetEnumerator()
        {
            return carArray.GetEnumerator();

            #region yield
            //yield return carArray[ 0 ];
            //yield return carArray[ 1 ];
            //yield return carArray[ 2 ];
            //yield return carArray[ 3 ];

            //int i = 0;
            //while( true )
            //{
            //   yield return carArray[ i++ ];
            //   if( i == 4 )
            //   {
            //      yield break;
            //   }
            //}      
            #endregion
        }
    }

    class Program
    {
        static void Main( string[] args )
        {
            Garage garage = new Garage();
            foreach( Car car in garage )
            {
                Console.WriteLine( car.PetName );
            }
        }
    }
}
