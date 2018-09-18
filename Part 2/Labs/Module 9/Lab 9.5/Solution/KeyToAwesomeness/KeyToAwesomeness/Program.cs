using System;
using System.Collections.Generic;
using System.Linq;

namespace Wincubate.CS7.KeyToAwesomenessLab
{
    class Program
    {
        static void Main( string[] args )
        {
            var served = new Dictionary<(CoffeeKind kind, CoffeeSize size, int strength), int>();

            void Serve( string customerName, CoffeeKind kind, CoffeeSize size, int strength )
            {
                Console.WriteLine($"Serving a {size} {kind} of strength {strength} to {customerName}");

                var key = (kind, size, strength);

                if (served.ContainsKey(key) == false)
                {
                    served[key] = 1;
                }
                else
                {
                    served[key]++;
                }
            }

            void PrintSummary() => served
                .OrderByDescending(kv => kv.Value)
                .ThenBy(kv => kv.Key.kind)
                .ThenByDescending(kv => kv.Key.size)
                .ThenByDescending(kv => kv.Key.strength)
                .Select(kv => $"Served {kv.Value} {kv.Key.size} {kv.Key.kind} of strength {kv.Key.strength}")
                .ToList()
                .ForEach(Console.WriteLine)
                ;

            RandomHelper helper = new RandomHelper();

            for (int i = 0; i < 100; i++)
            {
                CoffeeKind kind = helper.GetRandomCoffeeKind();
                CoffeeSize size = helper.GetRandomCoffeeSize();
                int strength = helper.GetRandomCoffeeStrength();

                Serve(helper.GetRandomName(), kind, size, strength);
            }

            Console.WriteLine();
            PrintSummary();
        }
    }
}
