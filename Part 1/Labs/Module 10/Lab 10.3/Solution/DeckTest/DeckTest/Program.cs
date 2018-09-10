﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeckTest
{
    class Program
    {
        static void Main( string[] args )
        {
            Deck deck = new Deck();
            deck.Shuffle();

            deck.ArrangeByRank();

            Console.WriteLine( "Rearranged Deck: " );
            foreach( Card card in deck )
            {
                Console.WriteLine( card );
            }
        }
    }
}
