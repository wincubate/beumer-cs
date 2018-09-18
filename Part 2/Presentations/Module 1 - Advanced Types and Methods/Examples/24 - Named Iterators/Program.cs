using System;
using System.Collections;
using Wincubate.Module01.Classes;

namespace Wincubate.Module01.Slide24
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
            yield return carArray[ 0 ];
            yield return carArray[ 1 ];
            yield return carArray[ 2 ];
            yield return carArray[ 3 ];
        }

        public IEnumerable GetTheCars( bool returnReversed )
        {
            if( returnReversed )
            {
                for( int i = carArray.Length; i != 0; i-- )
                {
                    yield return carArray[ i - 1 ];
                }
            }
            else
            {
                foreach( Car c in carArray )
                {
                    yield return c;
                }
            }
        }
        public IEnumerable GetTheCars( int number )
        {
            for( int i = 0; i < Math.Min( carArray.Length, number ); i++ )
            {
                yield return carArray[ i ];
            }
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
