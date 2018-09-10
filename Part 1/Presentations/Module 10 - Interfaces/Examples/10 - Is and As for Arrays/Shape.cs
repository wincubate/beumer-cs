using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module11.Slide10
{
    public abstract class Shape
    {
        public abstract void Draw();

        protected string shapeName;

        public Shape()
        {
            shapeName = "NoName";
        }

        public Shape( string s )
        {
            shapeName = s;
        }

        public string PetName
        {
            get
            {
                return shapeName;
            }
            set
            {
                shapeName = value;
            }
        }
    }
}
