using System;

namespace Wincubate.CS7x.EffectiveValueTypesLab
{
    struct Coffee
    {
        public Coffee(
            CoffeeKind kind,
            int strength,
            CoffeeSize size )
        {
            Kind = kind;
            Strength = strength;
            Size = size;
        }

        public CoffeeKind Kind { get; set; }
        public int Strength { get; set; }
        public CoffeeSize Size { get; set; }
    }
}
