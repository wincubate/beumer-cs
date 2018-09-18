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
                Serve(rng.GetRandomName(), factory.CreateCoffee(CoffeeType.Cappuccino));
                Serve(rng.GetRandomName(), factory.CreateCoffee(CoffeeType.Espresso));
                Serve(rng.GetRandomName(), factory.CreateCoffee(CoffeeType.LatteDoppio));
                Serve(rng.GetRandomName(), factory.CreateCoffee(CoffeeType.LatteGrande));
                Serve(rng.GetRandomName(), factory.CreateCoffee(CoffeeType.LatteTriplo));
            }
        }

        static void Serve( string customerName, in Coffee coffee )
        {
            WriteLine( $"Serving a {coffee.Size} {coffee.Kind} of strength {coffee.Strength} to {customerName}");
        }
    }
}
