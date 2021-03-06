﻿namespace Poker
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public Hand(params ICard[] cards)
        {
            this.Cards = new List<ICard>();
            foreach (var c in cards)
            {
                this.Cards.Add(c);
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var card in this.Cards)
            {
                result.Append(card.ToString());
            }

            return result.ToString();
        }
    }
}
