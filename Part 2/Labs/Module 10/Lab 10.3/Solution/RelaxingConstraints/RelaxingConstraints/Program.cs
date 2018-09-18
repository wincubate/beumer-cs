using System;
using System.Linq;

namespace Wincubate.CS7x.RelaxingConstraintsLab
{
    class Program
    {
        public static T GetRandomMember<T>() where T : struct, Enum
        {
            Random random = new Random();
            T[] ts = Enum.GetValues(typeof(T))
                .OfType<T>()
                .ToArray()
                ;

            return ts[random.Next(ts.Length)];
        }

        static void Main( string[] args )
        {
            // Should compile and each produce a single enum member result
            Console.WriteLine(GetRandomMember<Color>());
            Console.WriteLine(GetRandomMember<Team>());

            // Should not compile!
            //Console.WriteLine(GetRandomMember<Enum>());
            //Console.WriteLine(GetRandomMember<string>());
            //Console.WriteLine(GetRandomMember<int>());
            //Console.WriteLine(GetRandomMember<object>());
        }
    }
}
