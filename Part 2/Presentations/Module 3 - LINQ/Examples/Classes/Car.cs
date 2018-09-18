using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module03.Classes
{
    public class Car
    {
        public override string ToString()
        {
            return PetName;
        }

        public string PetName = string.Empty;
        public string Color = string.Empty;
        public int Speed;
        public string Make = string.Empty;
    }
}
