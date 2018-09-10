using System;
using System.Collections;

namespace Wincubate.Module13.Slide06
{
    class GridWrapper : IEnumerable
    {
        private int[ , ] grid = new int[ 3, 3 ] { { 0, 1, 2 }, { 4, 5, 6 }, { 7, 8, 9 } };

        public virtual int this[ int row, int column ]
        {
            get
            {
                return grid[ row, column ];
            }
            set
            {
                grid[ row, column ] = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return grid.GetEnumerator();
        }
    }

    public interface IMyStringContainer<T>
    {
        string this[ T index ]
        {
            get;
            set;
        }
    }

    class Program
    {
        static void Main( string[] args )
        {
            GridWrapper gw = new GridWrapper();
            gw[ 0, 0 ] = 87;

            foreach( int i in gw )
            {
                Console.WriteLine( i );
            }
        }
    }
}
