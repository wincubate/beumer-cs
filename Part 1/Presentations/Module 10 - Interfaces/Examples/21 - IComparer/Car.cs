using System;
using System.Collections;

namespace Wincubate.Module11.Slide21
{
    public class Car : IComparable
    {
        public static IComparer SortByPetName
        {
            get
            {
                return new PetNameComparer() as IComparer;
            }
        }

        public const int MaxSpeed = 100;

        public int Speed { get; set; }
        public string PetName { get; set; }

        public int ID { get; set; }

        public Car( string name, int currSp, int id )
        {
            Speed = currSp;
            PetName = name;
            ID = id;
        }

        public int CompareTo( object obj )
        {
            Car other = obj as Car;

            if( this.ID < other.ID )
            {
                return -1;
            }
            else if( this.ID > other.ID )
            {
                return 1;
            }
            return 0;
        }
    }
}
