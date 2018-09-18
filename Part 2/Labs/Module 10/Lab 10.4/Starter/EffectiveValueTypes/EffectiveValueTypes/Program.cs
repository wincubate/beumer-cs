using static System.Console;

namespace Wincubate.CS7x.EffectiveValueTypesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomNameGenerator rng = new RandomNameGenerator();
            ICoffeeFactory factory = new CoffeeFactory();

            for (int i = 0; i < 1_000; i++)
            {
                Coffee c1 = factory.CreateCoffee(CoffeeType.Cappuccino);
                Serve(rng.GetRandomName(),c1);
                Coffee c2 = factory.CreateCoffee(CoffeeType.Espresso);
                Serve(rng.GetRandomName(),c2);
                Coffee c3 = factory.CreateCoffee(CoffeeType.LatteDoppio);
                Serve(rng.GetRandomName(),c3);
                Coffee c4 = factory.CreateCoffee(CoffeeType.LatteGrande);
                Serve(rng.GetRandomName(),c4);
                Coffee c5 = factory.CreateCoffee(CoffeeType.LatteTriplo);
                Serve(rng.GetRandomName(),c5);
            }
        }

        static void Serve( string customerName, Coffee coffee )
        {
            WriteLine( $"Serving a {coffee.Size} {coffee.Kind} of strength {coffee.Strength} to {customerName}");
        }
    }
}
