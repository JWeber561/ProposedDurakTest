using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DurakDeck
{
    public class Player
    {
        public Hand playerHand;
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
            playerHand = new Hand();
            playerName = newPlayerName;
            isDurak = false;
        }
        public Player()
        {

        }
    }
}