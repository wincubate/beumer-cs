using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardTest
{
    class Program
    {
        static void Main( string[] args )
        {
            Card card1;
            card1.suit = Suit.Spades;
            card1.rank = Rank.Seven;

            Card card2;
            card2.suit = Suit.Spades;
            card2.rank = Rank.Ten;

            Console.WriteLine( card1 );
            Console.WriteLine( card2 );
        }
    }
}
