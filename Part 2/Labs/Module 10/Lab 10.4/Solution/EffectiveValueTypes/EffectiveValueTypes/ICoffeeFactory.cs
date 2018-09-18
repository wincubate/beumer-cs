namespace Wincubate.CS7x.EffectiveValueTypesLab
{
    interface ICoffeeFactory
    {
        ref readonly Coffee CreateCoffee( CoffeeType coffeeType );
    }
}
