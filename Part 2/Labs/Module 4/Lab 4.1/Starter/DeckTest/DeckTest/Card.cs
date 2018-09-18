using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace DeckTest
{
   enum Suit
   {
      Spades,
      Clubs,
      Hearts,
      Diamonds
   }

   enum Rank
   {
      Two,
      Three,
      Four,
      Five,
      Six,
      Seven,
      Eight,
      Nine,
      Ten,
      Jack,
      Queen,
      King,
      Ace
   }

   // TODO 5: Implement IComparable
   struct Card : IComparable, ICloneable
   {
      public Suit Suit { get; }
      public Rank Rank { get; }

      public static IComparer RankComparer
      {
         get
         {
            return new RankComparer();
         }
      }

      public Card( Suit suit, Rank rank )
      {
         Suit = suit;
         Rank = rank;
      }

      public override string ToString()
      {
         char rankOutput;
         switch (Rank)
         {
            case Rank.Two:
            case Rank.Three:
            case Rank.Four:
            case Rank.Five:
            case Rank.Six:
            case Rank.Seven:
            case Rank.Eight:
            case Rank.Nine:
               {
                  rankOutput = (char)('2' + ((char)(Rank - Rank.Two)));
                  break;
               }
            case Rank.Ten:
               {
                  rankOutput = 'T';
                  break;
               }
            case Rank.Jack:
               {
                  rankOutput = 'J';
                  break;
               }
            case Rank.Queen:
               {
                  rankOutput = 'Q';
                  break;
               }
            case Rank.King:
               {
                  rankOutput = 'K';
                  break;
               }
            case Rank.Ace:
               {
                  rankOutput = 'A';
                  break;
               }
            default:
               {
                  rankOutput = '?';
                  break;
               }
         }

         char suitOutput;
         switch (Suit)
         {
            case Suit.Clubs:
               {
                  suitOutput = 'c';
                  break;
               }
            case Suit.Diamonds:
               {
                  suitOutput = 'd';
                  break;
               }
            case Suit.Hearts:
               {
                  suitOutput = 'h';
                  break;
               }
            case Suit.Spades:
               {
                  suitOutput = 's';
                  break;
               }
            default:
               {
                  suitOutput = '?';
                  break;
               }
         }

         return string.Format( "{0}{1}",
            rankOutput,
            suitOutput);
      }

      #region IComparable Members

      public int CompareTo(object obj)
      {
         if (obj is Card)
         {
            Card other = (Card) obj;
            if (Suit < other.Suit)
            {
               return -1;
            }
            else if (Suit > other.Suit)
            {
               return 1;
            }
            else
            {
               if (Rank < other.Rank)
               {
                  return -1;
               }
               else if (Rank > other.Rank)
               {
                  return 1;
               }
               else
               {
                  return 0;
               }
            }
         }

         throw new ArgumentException( "Can only compare Card to other Cards");
      }

      #endregion

      #region ICloneable Members

      public object Clone()
      {
         return new Card(Suit, Rank);
      }

      #endregion
   }
}
