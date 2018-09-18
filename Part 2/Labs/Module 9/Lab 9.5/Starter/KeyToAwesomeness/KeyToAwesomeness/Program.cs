using System;
using System.Collections.Generic;
using System.Linq;

namespace Wincubate.CS7.KeyToAwesomenessLab
{
    class Program
    {
        static void Main( string[] args )
        {
            void Serve( string customerName, CoffeeKind kind, CoffeeSize size, int strength )
            {
                Console.WriteLine($"Serving a {size} {kind} of strength {strength} to {customerName}");
            }

            RandomHelper helper = new RandomHelper();

            for (int i = 0; i < 100; i++)
            {
                CoffeeKind kind = helper.GetRandomCoffeeKind();
                CoffeeSize size = helper.GetRandomCoffeeSize();
                int strength = helper.GetRandomCoffeeStrength();

                Serve(helper.GetRandomName(), kind, size, strength);
            }

            Console.WriteLine();
        }
    }
}
