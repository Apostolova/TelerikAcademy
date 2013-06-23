namespace Poker
{
    using System;

    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            bool isValid = true;
            if (hand.Cards.Count != 5)
            {
                isValid = false;
            }

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face && hand.Cards[i].Suit == hand.Cards[j].Suit)
                    {
                        isValid = false;
                    }
                }
            }

            return isValid;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            bool isValidHand = this.IsValidHand(hand);
            bool isFourOfKind = false;
            int[] facesCount = this.CalcFacesCounts(hand);
            for (int i = 0; i < facesCount.Length; i++)
            {
                if (isValidHand && (facesCount[i] == 4))
                {
                    isFourOfKind = true;
                }
            }

            return isFourOfKind;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            bool isValidHand = this.IsValidHand(hand);
            bool sameSuit = this.IsSameSuit(hand);
            bool isFlush = false;
            if (isValidHand && sameSuit && !this.IsFourOfAKind(hand))
            {
                isFlush = true;
            }

            return isFlush;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            bool isValidHand = this.IsValidHand(hand);
            bool isThreeOfKind = false;
            int[] facesCount = this.CalcFacesCounts(hand);
            for (int i = 0; i < facesCount.Length; i++)
            {
                if (isValidHand && facesCount[i] == 3)
                {
                    isThreeOfKind = true;
                }
            }

            return isThreeOfKind;
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            bool isValidHand = this.IsValidHand(hand);
            bool isOnePair = false;
            int[] facesCount = this.CalcFacesCounts(hand);
            isOnePair = this.IsPair(facesCount);
            if (isValidHand && isOnePair)
            {
                isOnePair = true;
            }

            return isOnePair;
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }

        private int[] CalcSuitsCounts(IHand hand)
        {
            int[] suitsCounts = new int[((int)CardSuit.Spades) + 1];
            foreach (var card in hand.Cards)
            {
                int faceNum = (int)card.Face;
                suitsCounts[faceNum]++;
            }

            return suitsCounts;
        }

        private int[] CalcFacesCounts(IHand hand)
        {
            int[] facesCounts = new int[((int)CardFace.Ace) + 1];
            foreach (var card in hand.Cards)
            {
                int faceNum = (int)card.Face;
                facesCounts[faceNum]++;
            }

            return facesCounts;
        }

        private bool IsSameSuit(IHand hand)
        {
            bool isSameSuit = true;
            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Suit != hand.Cards[i + 1].Suit)
                {
                    isSameSuit = false;
                }
            }

            return isSameSuit;
        }

        private bool IsPair(int[] facesCount)
        {
            bool isOnePair = false;
            for (int i = 0; i < facesCount.Length; i++)
            {
                if (facesCount[i] == 2)
                {
                    for (int j = i + 1; j < facesCount.Length - 1; j++)
                    {
                        if (facesCount[j] != 2)
                        {
                            isOnePair = true;
                        }
                    }
                }
            }

            return isOnePair;
        }
    }
}
