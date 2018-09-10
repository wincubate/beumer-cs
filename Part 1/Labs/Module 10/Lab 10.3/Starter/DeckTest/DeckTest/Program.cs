using System;
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

            // TODO 2: Iterate through all cards with foreach
            foreach( Card card in deck )
            {
                Console.WriteLine( card );
            }

            // TODO 4: Arrange and display Deck
            deck.Arrange();

            Console.WriteLine( "Rearranged Deck: " );
            foreach( Card card in deck )
            {
                Console.WriteLine( card );
            }
        }
    }
}
