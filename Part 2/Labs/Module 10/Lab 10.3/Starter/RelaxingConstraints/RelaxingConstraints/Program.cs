using System;

namespace Wincubate.CS7x.RelaxingConstraintsLab
{
    class Program
    {
        static void Main( string[] args )
        {
            // Should compile and each produce a single enum member result
            
            //Console.WriteLine(GetRandomMember<Color>());
            //Console.WriteLine(GetRandomMember<Team>());

            // Should not compile!
            
            //Console.WriteLine(GetRandomMember<Enum>());
            //Console.WriteLine(GetRandomMember<string>());
            //Console.WriteLine(GetRandomMember<int>());
            //Console.WriteLine(GetRandomMember<object>());
        }
    }
}
