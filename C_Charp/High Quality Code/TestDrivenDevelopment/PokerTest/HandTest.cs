namespace PokerTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    
    [TestClass]
    public class HandTest
    {
        [TestMethod]
        public void TestHand()
        {
            Hand hand = new Hand(
            new Card(CardFace.Jack, CardSuit.Diamonds),
            new Card(CardFace.Six, CardSuit.Spades),
            new Card(CardFace.Ace, CardSuit.Diamonds),
            new Card(CardFace.Five, CardSuit.Clubs),
            new Card(CardFace.Ten, CardSuit.Hearts));
            string expected = "J♦6♠A♦5♣10♥";
            string actual = hand.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
