using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wincubate.Module04.Classes;

namespace Wincubate.Module04.Slide04
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

        public Car this[int index]
        {
            get
            {
                return _list[index];
            }
            set
            {
                _list[index] = value;
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
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            Console.WriteLine(garage[1]);
            garage[1] = new Car("Goofy", 128);

            foreach (Car car in garage)
            {
                Console.WriteLine(car);
            }
        }
    }
}
