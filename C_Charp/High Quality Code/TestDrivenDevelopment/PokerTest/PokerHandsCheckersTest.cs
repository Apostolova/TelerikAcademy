namespace PokerTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class PokerHandsCheckerTest
    {
        [TestMethod]
        public void TestValidHand()
        {
            Hand hand = new Hand(
             new Card(CardFace.Jack, CardSuit.Diamonds),
             new Card(CardFace.Six, CardSuit.Spades),
             new Card(CardFace.Ace, CardSuit.Diamonds),
             new Card(CardFace.Five, CardSuit.Clubs),
             new Card(CardFace.Ten, CardSuit.Hearts));
            bool expected = true;
            PokerHandsChecker cheker = new PokerHandsChecker();
            bool actual = cheker.IsValidHand(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsInvalidHand()
        {
            Hand hand = new Hand(
             new Card(CardFace.Jack, CardSuit.Diamonds),
             new Card(CardFace.Six, CardSuit.Spades),
             new Card(CardFace.Ace, CardSuit.Diamonds),
             new Card(CardFace.Ace, CardSuit.Diamonds),
             new Card(CardFace.Ten, CardSuit.Hearts));
            bool expected = false;
            PokerHandsChecker cheker = new PokerHandsChecker();
            bool actual = cheker.IsValidHand(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFourOfKindHand()
        {
            Hand hand = new Hand(
             new Card(CardFace.Jack, CardSuit.Diamonds),
             new Card(CardFace.Four, CardSuit.Spades),
             new Card(CardFace.Four, CardSuit.Diamonds),
             new Card(CardFace.Four, CardSuit.Clubs),
             new Card(CardFace.Four, CardSuit.Hearts));
            bool expected = true;
            PokerHandsChecker cheker = new PokerHandsChecker();
            bool actual = cheker.IsFourOfAKind(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsNotFourOfKindHand()
        {
            Hand hand = new Hand(
             new Card(CardFace.Jack, CardSuit.Diamonds),
             new Card(CardFace.Four, CardSuit.Spades),
             new Card(CardFace.Four, CardSuit.Diamonds),
             new Card(CardFace.Four, CardSuit.Clubs),
             new Card(CardFace.Six, CardSuit.Hearts));
            bool expected = false;
            PokerHandsChecker cheker = new PokerHandsChecker();
            bool actual = cheker.IsFourOfAKind(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFlushHand()
        {
            Hand hand = new Hand(
             new Card(CardFace.Jack, CardSuit.Hearts),
             new Card(CardFace.Five, CardSuit.Hearts),
             new Card(CardFace.Four, CardSuit.Hearts),
             new Card(CardFace.Ten, CardSuit.Hearts),
             new Card(CardFace.Two, CardSuit.Hearts));
            bool expected = true;
            PokerHandsChecker cheker = new PokerHandsChecker();
            bool actual = cheker.IsFlush(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsNotFlushHand()
        {
            Hand hand = new Hand(
             new Card(CardFace.Jack, CardSuit.Spades),
             new Card(CardFace.Five, CardSuit.Hearts),
             new Card(CardFace.Four, CardSuit.Hearts),
             new Card(CardFace.Ten, CardSuit.Hearts),
             new Card(CardFace.Two, CardSuit.Hearts));
            bool expected = false;
            PokerHandsChecker cheker = new PokerHandsChecker();
            bool actual = cheker.IsFlush(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestThreeOfKindHand()
        {
            Hand hand = new Hand(
             new Card(CardFace.Jack, CardSuit.Diamonds),
             new Card(CardFace.Five, CardSuit.Spades),
             new Card(CardFace.Four, CardSuit.Diamonds),
             new Card(CardFace.Four, CardSuit.Clubs),
             new Card(CardFace.Four, CardSuit.Hearts));
            bool expected = true;
            PokerHandsChecker cheker = new PokerHandsChecker();
            bool actual = cheker.IsThreeOfAKind(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsNotThreeOfKindHand()
        {
            Hand hand = new Hand(
             new Card(CardFace.Jack, CardSuit.Diamonds),
             new Card(CardFace.Four, CardSuit.Spades),
             new Card(CardFace.Four, CardSuit.Diamonds),
             new Card(CardFace.Four, CardSuit.Clubs),
             new Card(CardFace.Four, CardSuit.Hearts));
            bool expected = false;
            PokerHandsChecker cheker = new PokerHandsChecker();
            bool actual = cheker.IsThreeOfAKind(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestOnePair()
        {
            Hand hand = new Hand(
             new Card(CardFace.Jack, CardSuit.Diamonds),
             new Card(CardFace.Five, CardSuit.Spades),
             new Card(CardFace.Ten, CardSuit.Diamonds),
             new Card(CardFace.Four, CardSuit.Clubs),
             new Card(CardFace.Four, CardSuit.Hearts));
            bool expected = true;
            PokerHandsChecker cheker = new PokerHandsChecker();
            bool actual = cheker.IsOnePair(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsNotOnePair()
        {
            Hand hand = new Hand(
             new Card(CardFace.Jack, CardSuit.Diamonds),
             new Card(CardFace.Four, CardSuit.Spades),
             new Card(CardFace.Five, CardSuit.Diamonds),
             new Card(CardFace.Four, CardSuit.Clubs),
             new Card(CardFace.Four, CardSuit.Hearts));
            bool expected = false;
            PokerHandsChecker cheker = new PokerHandsChecker();
            bool actual = cheker.IsOnePair(hand);
            Assert.AreEqual(expected, actual);
        }
    }
}
