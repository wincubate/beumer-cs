using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindVowels
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine( "Indtast en streng: " );
            string input = Console.ReadLine();

            int vowels = FindVowels( input );
            Console.WriteLine( "Der er {0} vokaler i strengen \"{1}\"", vowels, input );
        }

        static int FindVowels( string s )
        {
            int count = 0;

            foreach( char c in s )
            {
                if( IsVowel( c ) )
                {
                    count++;
                }
            }

            return count;
        }

        static bool IsVowel( char c )
        {
            switch( char.ToLower( c ) )
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