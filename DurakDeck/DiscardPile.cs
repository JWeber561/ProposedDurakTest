﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakDeck
{
    public class DiscardPile:PileOfCards
    {
        public Card GetTopCard()
        {
            return GetCard(GetCount()-1);
        }
    }
}
