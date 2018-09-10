using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeckTest;

namespace SortingTest
{
    class Program
    {
        static void Main( string[] args )
        {
            #region numbers

            int[] numbers = { 87, 176, 11, 112, 42 };

            // TODO 1: Sort numbers
            Array.Sort( numbers );

            foreach( int i in numbers )
            {
                Console.Write( i + " " );
            }
            Console.WriteLine();

            #endregion

            #region deck

            Card[] deck = new Card[ 52 ];

            #region Fill deck of cards

            int indexToFill = 0;
            foreach( Suit suit in Enum.GetValues( typeof( Suit ) ) )
            {
                foreach( Rank rank in Enum.GetValues( typeof( Rank ) ) )
                {
                    deck[ indexToFill ].suit = suit;
                    deck[ indexToFill ].rank = rank;
                    indexToFill++;
                }
            }

            #endregion

            #region Shuffle deck

            Random random = new Random();
            for( int i = 0; i < deck.Length; i++ )
            {
                int j = random.Next( deck.Length );
                Card temp = deck[ i ];
                deck[ i ] = deck[ j ];
                deck[ j ] = temp;
            }

            #endregion

            // TODO 2: Sort deck
            // Array.Sort(deck); <-- Throws Exception!!

            // TODO 3: Custom sort algorithm

            // Simple inlined BubbleSort 
            for( int i = deck.Length - 1; i > 0; i-- )
            {
                for( int j = 0; j < i; j++ )
                {
                    if( deck[ j ].rank > deck[ j + 1 ].rank )
                    {
                        Card temp = deck[ j ];
                        deck[ j ] = deck[ j + 1 ];
                        deck[ j + 1 ] = temp;
                    }
                }
            }

            #region Output cards

            foreach( Card card in deck )
            {
                char rankOutput;
                switch( card.rank )
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
                            rankOutput = (char) ( '2' + ( (char) ( card.rank - Rank.Two ) ) );
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
                switch( card.suit )
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

                Console.Write( "{0}{1} ", rankOutput, suitOutput );
            }
            Console.WriteLine();

            #endregion

            #endregion
        }
    }
}
