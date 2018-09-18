using System;
using static System.Console;

namespace Wincubate.CS7.Slide04
{
    class Program
    {
        static void Main( string[] args )
        {
            WriteLine("Please input a word: ");
            string input = ReadLine();

            int vowels = FindVowels(input);
            WriteLine($"There are {vowels} vowels in \"{input}\"");
        }

        static int FindVowels( string s )
        {
            int v = 0;

            foreach (char letter in s)
            {
                if (IsVowel(letter))
                {
                    v++;
                }
            }

            return v;
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