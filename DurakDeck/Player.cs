using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DurakDeck
{
    public class Player
    {
        private List <Card> playerHand;
        private bool isDurak;
        private string myName;
        public string playerName
        {
            get // Accessing
            {
                return myName;
            }
            set // Mutating
            {
                myName = value;
            }
        }
        public Player(String newPlayerName)
        {
            playerHand = new List<Card>();
            playerName = newPlayerName;
            isDurak = false;
        }
        public Player()
        {

        }
        public void DrawCard(Card cardDrawn)
        {
            playerHand.Add(cardDrawn);
        }
        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= playerHand.Count - 1)
            {
                return playerHand[cardNum];
            }
            else
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum,
                String.Format("Value must be between 0 and {0}.", playerHand.Count - 1)));
        }
        public int GetCount()
        {
            return playerHand.Count;
        }
    }
}