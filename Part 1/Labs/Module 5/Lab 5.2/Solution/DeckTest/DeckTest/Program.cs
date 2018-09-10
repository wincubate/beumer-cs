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
            Card[] deck = new Card[ 52 ];

            // TODO 1: Create FillDeck() method
            FillDeck( deck );

            // TODO 2: Create ShuffleDeck() method
            ShuffleDeck( deck );

            // TODO 3: Create OutputDeck() method
            OutputDeck( deck );

            Console.WriteLine();

            Card deuceOfSpades;
            deuceOfSpades.suit = Suit.Spades;
            deuceOfSpades.rank = Rank.Two;

            // TODO 4: Create FindCard() method
            deuceOfSpades = FindCard( deck, deuceOfSpades );

            Console.WriteLine( "Indtast antal kort, der skal undersøges: " );
            int number = int.Parse( Console.ReadLine() );

            // TODO 5: Create FindPairs() method
            FindPairs( deck, number );
        }

        static void FillDeck( Card[] deck )
        {
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
        }

        private static void ShuffleDeck( Card[] deck )
        {
            Random random = new Random();
            for( int i = 0; i < deck.Length; i++ )
            {
                int j = random.Next( deck.Length );
                Card temp = deck[ i ];
                deck[ i ] = deck[ j ];
                deck[ j ] = temp;
            }
        }

        private static void OutputDeck( Card[] deck )
        {
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
        }

        private static Card FindCard( Card[] deck, Card deuceOfSpades )
        {
            Console.WriteLine( "2s er på position {0}", Array.IndexOf( deck, deuceOfSpades ) );
            return deuceOfSpades;
        }

        private static void FindPairs( Card[] deck, int number )
        {
            if( number > 0 )
            {
                for( int i = 0; i < number; i++ )
                {
                    for( int j = i + 1; j < number; j++ )
                    {
                        if( deck[ i ].rank == deck[ j ].rank )
                        {
                            Console.WriteLine( "Position {0} og {1} udgør et par", i, j );
                        }
                    }
                }
            }
        }
    }
}
