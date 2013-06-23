namespace Poker
{
    using System;

    public class Card : ICard
    {
        public CardFace Face { get; private set; }

        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            string faceStr = this.GetFaceNameToString();
            char suit = this.GetFaceSuitToString();
            string cardStr = faceStr + suit;
            return cardStr;
        }

        private char GetFaceSuitToString()
        {
            char suit;
            switch (this.Suit)
            {
                case CardSuit.Clubs:
                    suit = '♣'; 
                    break;
                case CardSuit.Diamonds:
                    suit = '♦';
                    break;
                case CardSuit.Hearts:
                    suit = '♥'; 
                    break;
                case CardSuit.Spades:
                    suit = '♠'; 
                    break;
                default:
                    throw new InvalidOperationException("Invalid suit:" + this.Suit);
            }

            return suit;
        }

        private string GetFaceNameToString()
        {
            string faceStr;
            if ((int)this.Face <= 10)
            {
                faceStr = ((int)this.Face).ToString();
            }
            else
            {
                string faceName = this.Face.ToString();
                char faceLatter = faceName[0];
                faceStr = faceLatter.ToString();
            }

            return faceStr;
        }
    }
}
