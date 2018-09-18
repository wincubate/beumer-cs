using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeckTest
{
   class Deck : IEnumerable, ICloneable
   {
      private Card[] _cards;

      // TODO 1: Implement integer indexer with get; and set;

      // TODO 2: Implement "Card-string" indexers with get; only

      public Deck()
      {
         _cards = new Card[52];

         int indexToFill = 0;
         foreach (Suit suit in Enum.GetValues(typeof(Suit)))
         {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
               _cards[indexToFill] = new Card(suit, rank);
               indexToFill++;
            }
         }
      }

      public void Shuffle()
      {
         Random random = new Random();
         for (int i = 0; i < _cards.Length; i++)
         {
            int j = random.Next(_cards.Length);
            Card temp = _cards[i];
            _cards[i] = _cards[j];
            _cards[j] = temp;
         }
      }

      public void Arrange()
      {
         Array.Sort(_cards);
      }

      public void ArrangeByRank()
      {
         Array.Sort(_cards, Card.RankComparer );
      }

      #region IEnumerable Members

      public IEnumerator GetEnumerator()
      {
         foreach( Card card in _cards )
         {
            yield return card;
         }
      }

      #endregion

      #region ICloneable Members

      public object Clone()
      {
         Deck clone = new Deck();

         for (int i = 0; i < _cards.Length; i++)
         {
            clone._cards[i] = (Card) _cards[i].Clone(); 
         }

         return clone;
      }

      #endregion
   }
}
