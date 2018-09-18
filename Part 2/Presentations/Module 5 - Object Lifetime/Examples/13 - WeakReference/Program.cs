using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module05.Slide13
{
    class Program
    {
        static void Main(string[] args)
        {
            int cacheSize = 100;
            Cache cache = new Cache(cacheSize);

            string DataName = string.Empty;

            // Randomly access objects in the cache. 
            Random random = new Random();

            for (int i = 0; i < cache.Count; i++)
            {
                int index = random.Next(cache.Count);

                // Access the object by 
                // getting a property value.
                DataName = cache[index].Name;
            }

            double regenerationPercentage = cache.RegenerationCount * 100 / cache.Count;
            Console.WriteLine("Cache size: {0}, Regenerated: {1}%",
                cache.Count.ToString(), 
                regenerationPercentage.ToString());
        }
    }
}
