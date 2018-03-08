using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakDeck
{
    public class PileOfCards
    {
        private List<Card> cards;
        public PileOfCards()
        {

        }
        public Card GetCard()
        {
            if (GetCount() > 0)
            {
                Card cardReturned = cards[0];
                cards.RemoveAt(0);
                return cardReturned;

            }
            else
                throw (new System.ArgumentOutOfRangeException("Cannot draw from an empty pile"));
        }
        public int GetCount()
        {
            return cards.Count;
        }
    }
}
