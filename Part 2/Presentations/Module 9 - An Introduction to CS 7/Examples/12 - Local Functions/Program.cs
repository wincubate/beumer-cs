using System;
using static System.Console;

namespace Wincubate.CS7.Slide12
{
    class Program
    {
        static void Main( string[] args )
        {
            string input = "Onomatopoiea";

            var t = FindVowels(input);
            WriteLine($"There are {t.vowels} vowels and {t.cons} consonants in \"{input}\"");
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
