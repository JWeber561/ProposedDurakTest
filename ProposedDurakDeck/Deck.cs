using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics; // for Debug and Trace objects

namespace ProposedDurakDeck
{
    public class Deck
    {
        private Card[] cards;

        public Deck(int deckSize)
        {
            cards = new Card[deckSize];
            switch(deckSize)
            {
                case 20:
                    for (int suitVal = 0; suitVal < 4; suitVal++)
                    {
                        for (int rankVal = 10; rankVal < 15; rankVal++)
                        {
                            cards[suitVal * 5 + rankVal - 1] = new Card((Suit)suitVal,
                            (Rank)rankVal);
                        }
                    }
                    break;
                case 36:
                    for (int suitVal = 0; suitVal < 4; suitVal++)
                    {
                        for (int rankVal = 6; rankVal < 15; rankVal++)
                        {
                            cards[suitVal * 8 + rankVal - 1] = new Card((Suit)suitVal,
                            (Rank)rankVal);
                        }
                    }
                    break;
                case 52:
                    for (int suitVal = 0; suitVal < 4; suitVal++)
                    {
                        for (int rankVal = 2; rankVal < 15; rankVal++)
                        {
                            cards[suitVal * 13 + rankVal - 1] = new Card((Suit)suitVal,
                            (Rank)rankVal);
                        }
                    }
                    break;
                default:
                    throw (new System.ArgumentOutOfRangeException("deckSize", deckSize,
                    String.Format("deckSize must be 20, 36, or 52 exclusively, not {0}.", deckSize)));
                    break;

            }

        }
        public Deck()
        {
            
        }
        public Card GetCard(int cardNum, int deckSize)
        {
            if (cardNum >= 0 && cardNum <= deckSize-1)
                return cards[cardNum];
            else
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum,
                String.Format("Value must be between 0 and {0}.", deckSize-1)));
        }
        public void Shuffle(int deckSize)
        {
            Card[] newDeck = new Card[deckSize];
            bool[] assigned = new bool[deckSize];
            Random sourceGen = new Random();
            for (int i = 0; i < deckSize; i++)
            {
                int destCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    destCard = sourceGen.Next(deckSize);
                    if (assigned[destCard] == false)
                        foundCard = true;
                }
                assigned[destCard] = true;
                newDeck[destCard] = cards[i];
            }
            newDeck.CopyTo(cards, 0);
        }
    }
}