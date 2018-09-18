using System;

namespace Wincubate.CS7x.EffectiveValueTypesLab
{
    class CoffeeFactory : ICoffeeFactory
    {
        private readonly Coffee[] _coffees;

        public CoffeeFactory() => _coffees = new Coffee[]
        {
            new Coffee(CoffeeKind.Cappuccino, 3, CoffeeSize.Regular),
            new Coffee(CoffeeKind.Espresso, 5, CoffeeSize.Small),
            new Coffee(CoffeeKind.Latte, 2, CoffeeSize.Regular),
            new Coffee(CoffeeKind.Latte, 1, CoffeeSize.Regular),
            new Coffee(CoffeeKind.Latte, 2, CoffeeSize.Large)
        };

        public ref readonly Coffee CreateCoffee( CoffeeType coffeeType )
        {
            int index = (int)coffeeType;
            if ( 0 <= index && index < _coffees.Length )
            {
                return ref _coffees[(int)coffeeType];
            }

            throw new NotSupportedException($"Coffee type {coffeeType} not supported");
        }
    }
}