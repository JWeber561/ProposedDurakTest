using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics; // for Debug and Trace objects

namespace DurakDeck
{
    public class Deck : PileOfCards
    {
        private int myDeckSize;
        private int minRank;

        public Deck(int deckSize)
        {
            myDeckSize = deckSize;
            if (myDeckSize == 20)
            {
                minRank = 10;
            }
            else if (myDeckSize == 36)
            {
                minRank = 6;
            }
            else if (myDeckSize == 52)
            {
                minRank = 2;
            }
            else
            {
                throw (new ArgumentOutOfRangeException("deckSize", myDeckSize, String.Format("deckSize must be 20, 36, or 52 exclusively, not {0}.", myDeckSize)));
            }
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = minRank; rankVal < 15; rankVal++)
                {
                    cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                }
            }
        }
        public Deck()
        {
            throw (new Exception("Use The Parameterized Constructor"));
        }
        public void Shuffle()
        {
            List <Card> newDeck = new List<Card>(); 
            Random sourceGen = new Random();
            int field;
            for (int i = 0; i < myDeckSize; i++)
            {
                field = sourceGen.Next(0, cards.Count);
                newDeck.Add(cards[field]);
                cards.RemoveAt(field);
            }
            for ( int i =0; i <myDeckSize; i++)
            {
                cards.Add(newDeck[i]);
            }
         }
        public void Refill()
        {
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = minRank; rankVal < 15; rankVal++)
                {
                    cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                }
            }
        }
    }
}