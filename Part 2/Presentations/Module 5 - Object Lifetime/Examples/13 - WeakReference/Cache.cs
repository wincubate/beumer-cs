using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module05.Slide13
{
   public class Cache
   {
      // Dictionary to contain the cache. 
      static Dictionary<int, WeakReference<Data>> _cache;

      // Returns the number of items in the cache. 
      public int Count => _cache.Count;

      // Returns the number of times an  
      // object had to be regenerated. 
      public int RegenerationCount { get; private set; }

      public Cache(int count)
      {
         _cache = new Dictionary<int, WeakReference<Data>>();

         // Add data objects with a  
         // short weak reference to the cache. 
         for (int i = 0; i < count; i++)
         {
            _cache.Add(i, new WeakReference<Data>(new Data(i), false));
         }
      }

      // Accesses a data object from the cache. 
      // If the object was reclaimed for garbage collection, 
      // create a new data object at that index location. 
      public Data this[int index]
      {
         get
         {
            // Obtain an instance of a data 
            // object from the cache of 
            // of weak reference objects.
            Data d = null;
            if (_cache[index].TryGetTarget(out d) == true)
            {
               // Object was obtained with the weak reference.
               Console.WriteLine( $"Regenerate object at {index}: No" );
            }
            else
            {
               // Object was reclaimed, so generate a new one.
               Console.WriteLine( $"Regenerate object at {index}: Yes" );
               d = new Data(index);
               _cache[index].SetTarget(d);

               RegenerationCount++;
            }

            return d;
         }
      }
   }
}
