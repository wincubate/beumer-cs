using System;
using System.Collections.Generic;

namespace Wincubate.CS7x.EffectiveValueTypesLab
{
    class CoffeeFactory : ICoffeeFactory
    {
        private readonly IDictionary<CoffeeType, Coffee> _coffees;

        public CoffeeFactory() => _coffees = new Dictionary<CoffeeType, Coffee>();

        public Coffee CreateCoffee( CoffeeType coffeeType )
        {
            bool exists = _coffees.ContainsKey(coffeeType);
            if (exists == false)
            {
                switch (coffeeType)
                {
                    case CoffeeType.Cappuccino:
                        _coffees[coffeeType] = new Coffee(CoffeeKind.Cappuccino, 3, CoffeeSize.Regular);
                        break;
                    case CoffeeType.Espresso:
                        _coffees[coffeeType] = new Coffee(CoffeeKind.Espresso, 5, CoffeeSize.Small);
                        break;
                    case CoffeeType.LatteDoppio:
                        _coffees[coffeeType] = new Coffee(CoffeeKind.Latte, 2, CoffeeSize.Regular);
                        break;
                    case CoffeeType.LatteGrande:
                        _coffees[coffeeType] = new Coffee(CoffeeKind.Latte, 1, CoffeeSize.Regular);
                        break;
                    case CoffeeType.LatteTriplo:
                        _coffees[coffeeType] = new Coffee(CoffeeKind.Latte, 2, CoffeeSize.Large);
                        break;
                    default:
                        throw new NotSupportedException($"Coffee type {coffeeType} not supported");
                }
            }

            return _coffees[coffeeType];
        }
    }
}