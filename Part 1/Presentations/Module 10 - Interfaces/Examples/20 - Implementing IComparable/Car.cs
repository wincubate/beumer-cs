using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module11.Slide24
{
    public class Car // : IComparable
    {
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
    }
}
