using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakDeck
{
    public abstract class PileOfCards
    {
        public List<Card> cards;
        public PileOfCards()
        {

        }
        public Card GetCard(int index)
        {
            if (index >= 0 && index <= GetCount()-1)
            {
                return cards[index];
            }
            else
                throw (new System.ArgumentOutOfRangeException("index", index,
                String.Format("Value must be between 0 and {0}.", GetCount() - 1)));
        }
        public Card DrawCardFrom()
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
        public void AddCard(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }
        public void CombineCards(PileOfCards pile)
        {
            while (pile.GetCount() > 0)
            {
                AddCard(pile.DrawCardFrom());
            }
        }
        public int GetCount()
        {
            return cards.Count;
        }
    }
}
