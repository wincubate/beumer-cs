using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeckTest
{
   class Program
   {
      static void Main(string[] args)
      {
         Deck deck = new Deck();
         deck.Shuffle();
      
         // TODO 3: Test the newly implemented indexers
         Card card = deck[42];

         int indexOfCard42 = deck[card.ToString()];

         Console.WriteLine( indexOfCard42 == 42 );
      }
   }
}
