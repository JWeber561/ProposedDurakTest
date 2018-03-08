using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics; // for Debug and Trace objects

namespace DurakDeck
{
    public class Deck : PileOfCards
    {
        private List <Card> cards;
        private int myDeckSize;

        public Deck(int deckSize)
        {
            //cards = new Card[deckSize];
            myDeckSize = deckSize;
            cards = new List<Card>();
            if (myDeckSize == 20)
            {
                for (int suitVal = 0; suitVal < 4; suitVal++)
                {
                    for (int rankVal = 10; rankVal < 15; rankVal++)
                    {
                        /*cards[suitVal * 5 + rankVal - 10] = new Card((Suit)suitVal,
                        (Rank)rankVal);*/
                        cards.Add(new Card((Suit)suitVal,(Rank)rankVal));
                    }
                }
            }
            else if (myDeckSize == 36)
            {
                for (int suitVal = 0; suitVal < 4; suitVal++)
                {
                    for (int rankVal = 6; rankVal < 15; rankVal++)
                    {
                        /*cards[suitVal * 9 + rankVal - 6] = new Card((Suit)suitVal,
                        (Rank)rankVal);*/
                        cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                    }
                }
            }
            else if (myDeckSize == 52)
            {
                for (int suitVal = 0; suitVal < 4; suitVal++)
                {
                    for (int rankVal = 2; rankVal < 15; rankVal++)
                    {
                        /*cards[suitVal * 13 + rankVal - 2] = new Card((Suit)suitVal,
                        (Rank)rankVal);*/
                        cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                    }
                }
            }
            else
            {
                throw (new ArgumentOutOfRangeException("deckSize", myDeckSize, String.Format("deckSize must be 20, 36, or 52 exclusively, not {0}.", myDeckSize)));
            }
        }
        public Deck()
        {
            
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
            if (myDeckSize == 20)
            {
                for (int suitVal = 0; suitVal < 4; suitVal++)
                {
                    for (int rankVal = 10; rankVal < 15; rankVal++)
                    {
                        /*cards[suitVal * 5 + rankVal - 10] = new Card((Suit)suitVal,
                        (Rank)rankVal);*/
                        cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                    }
                }
            }
            else if (myDeckSize == 36)
            {
                for (int suitVal = 0; suitVal < 4; suitVal++)
                {
                    for (int rankVal = 6; rankVal < 15; rankVal++)
                    {
                        /*cards[suitVal * 9 + rankVal - 6] = new Card((Suit)suitVal,
                        (Rank)rankVal);*/
                        cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                    }
                }
            }
            else if (myDeckSize == 52)
            {
                for (int suitVal = 0; suitVal < 4; suitVal++)
                {
                    for (int rankVal = 2; rankVal < 15; rankVal++)
                    {
                        /*cards[suitVal * 13 + rankVal - 2] = new Card((Suit)suitVal,
                        (Rank)rankVal);*/
                        cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                    }
                }
            }
            else
            {
                throw (new ArgumentOutOfRangeException("deckSize", myDeckSize, String.Format("deckSize must be 20, 36, or 52 exclusively, not {0}.", myDeckSize)));
            }
        }
    }
}