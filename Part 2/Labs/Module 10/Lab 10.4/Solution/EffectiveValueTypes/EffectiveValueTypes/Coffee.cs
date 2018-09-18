using System;

namespace Wincubate.CS7x.EffectiveValueTypesLab
{
    readonly struct Coffee
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

        public CoffeeKind Kind { get; }
        public int Strength { get; }
        public CoffeeSize Size { get; }
    }
}
