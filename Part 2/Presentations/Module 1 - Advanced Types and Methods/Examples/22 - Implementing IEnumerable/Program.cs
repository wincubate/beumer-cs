using System;
using System.Collections;
using System.Linq;
using System.Text;
using Wincubate.Module01.Classes;

namespace Wincubate.Module01.Slide22
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
            int i = 0;
            while (true)
            {
                yield return carArray[i++];
                if (i == 4)
                {
                    yield break;
                }
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
