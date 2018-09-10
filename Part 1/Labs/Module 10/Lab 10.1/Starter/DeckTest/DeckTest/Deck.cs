﻿using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace DeckTest
{
    // TODO 1: Implement IEnumerable
    class Deck
    {
        private Card[] _cards;

        public Deck()
        {
            _cards = new Card[ 52 ];

            int indexToFill = 0;
            foreach( Suit suit in Enum.GetValues( typeof( Suit ) ) )
            {
                foreach( Rank rank in Enum.GetValues( typeof( Rank ) ) )
                {
                    _cards[ indexToFill ].suit = suit;
                    _cards[ indexToFill ].rank = rank;
                    indexToFill++;
                }
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            for( int i = 0; i < _cards.Length; i++ )
            {
                int j = random.Next( _cards.Length );
                Card temp = _cards[ i ];
                _cards[ i ] = _cards[ j ];
                _cards[ j ] = temp;
            }
        }

        public void Arrange()
        {
            // TODO 3: Implement method
        }
    }
}
