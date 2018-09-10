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
    struct Card : IComparable
    {
        public Suit suit;
        public Rank rank;

        public override string ToString()
        {
            char rankOutput;
            switch( rank )
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
                        rankOutput = (char) ( '2' + ( (char) ( rank - Rank.Two ) ) );
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
            switch( suit )
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

            return $"{rankOutput}{suitOutput}";
        }

        #region IComparable Members

        public int CompareTo( object obj )
        {
            if( obj is Card )
            {
                Card other = (Card) obj;
                if( this.suit < other.suit )
                {
                    return -1;
                }
                else if( this.suit > other.suit )
                {
                    return 1;
                }
                else
                {
                    if( this.rank < other.rank )
                    {
                        return -1;
                    }
                    else if( this.rank > other.rank )
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

            throw new ArgumentException( "Can only compare Card to other Cards" );
        }

        #endregion
    }
}
