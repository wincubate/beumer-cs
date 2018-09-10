using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wincubate.Module14.Classes;

namespace Wincubate.Module14.Slide15
{
    class Garage : IEnumerable<Car>
    {
        private List<Car> _list;

        public Garage()
        {
            _list = new List<Car>
            {
                new Car( "FeeFee", 200 ),
                new Car( "Clunker", 90 ),
                new Car( "Zippy", 30 ),
                new Car( "Fred", 30 )
            };
        }

        public Car this[ int index ]
        {
            get
            {
                return _list[ index ];
            }
            set
            {
                _list[ index ] = value;
            }
        }

        public IEnumerator<Car> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }

    class Program
    {
        static void Main( string[] args )
        {
            Garage garage = new Garage();

            var query = from c in garage
                        where c.PetName.StartsWith( "F" )
                        select c;

            foreach (var c in query)
            {
                Console.WriteLine( c.PetName );
            }
        }
    }
}
