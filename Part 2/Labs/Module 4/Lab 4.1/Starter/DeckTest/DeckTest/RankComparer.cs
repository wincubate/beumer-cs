using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace DeckTest
{
   class RankComparer : IComparer
   {
      #region IComparer Members

      public int Compare(object x, object y)
      {
         if (x is Card && y is Card)
         {
            Card lhs = (Card) x;
            Card rhs = (Card) y;

            if (lhs.Rank < rhs.Rank)
            {
               return -1;
            }
            else if (lhs.Rank > rhs.Rank)
            {
               return 1;
            }
            else
            {
               if (lhs.Suit < rhs.Suit)
               {
                  return -1;
               }
               else if (lhs.Suit > rhs.Suit)
               {
                  return 1;
               }
               else
               {
                  return 0;
               }
            }
         }

         throw new ArgumentException("Can only compare Card to other Cards");
      }

      #endregion
   }      
}
