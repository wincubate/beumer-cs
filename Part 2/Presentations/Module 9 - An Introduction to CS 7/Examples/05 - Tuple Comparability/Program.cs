using System;
using static System.Console;

namespace Wincubate.CS7.Slide05
{
    class Program
    {
        static void Main( string[] args )
        {
            string input = "Onomatopoiea";
            var tuple = FindVowels(input);

            WriteLine(tuple.ToString());

            //var other = (8, 4);
            //WriteLine( tuple.Equals( other ) );

            //WriteLine( tuple == other );

            //var (o1, o2) = tuple; // Implicit Conversion

            //var other = (vowels: 8, cons: 4);
            //WriteLine( tuple == other );

            //var t1 = (vowels: 8, cons: 4);
            //var t2 = (vowels: 8, cons: 4);
            //WriteLine(t1 == t2);
        }

        static (int vowels, int cons) FindVowels( string s )
        {
            var tuple = (v: 0, c: 0);

            foreach (char letter in s)
            {
                if (IsVowel(letter))
                {
                    tuple.v++;
                }
                else if (char.IsLetter(letter))
                {
                    tuple.c++;
                }
            }

            return tuple;
        }

        static bool IsVowel( char letter )
        {
            switch (char.ToLower(letter))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'y':
                case 'æ':
                case 'ø':
                case 'å':
                    return true;
                default:
                    return false;
            }
        }
    }
}
