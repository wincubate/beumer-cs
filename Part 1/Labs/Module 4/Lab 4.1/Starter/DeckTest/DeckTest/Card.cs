using System;

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

    struct Card
    {
        public Suit suit;
        public Rank rank;
    }
}
