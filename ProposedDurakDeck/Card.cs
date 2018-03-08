using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProposedDurakDeck
{
    public class Card
    {
        public readonly Rank rank;
        public readonly Suit suit;

        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        private Card()
        {

        }

        public override String ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }
    }
}