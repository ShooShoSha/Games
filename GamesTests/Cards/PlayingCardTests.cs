// <copyright file="PlayingCardTests.cs" company="ShooShoSha">
// Copyright (c) 2017 Kevin "ShooShoSha" O'Brien
// </copyright>
namespace ShooShosha.Games.Cards.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass()]
    public class PlayingCardTests
    {

        [TestMethod()]
        public void GetHashCodeTest_DistinctSameObjects_ReturnSameHashCode()
        {
            var target = new PlayingCard(CardValue.Ace, CardSuit.Clubs);
            var other = new PlayingCard(CardValue.Ace, CardSuit.Clubs);

            var targetHashCode = target.GetHashCode();
            var otherHashCode = other.GetHashCode();

            Assert.AreEqual(targetHashCode, otherHashCode);
        }

        [TestMethod]
        public void GetHashCodeTest_DistinctObjectsDifferSingleProperty_ReturnDifferentHashCode()
        {
            var targetSuit = new PlayingCard(CardValue.Ace, CardSuit.Clubs);
            var otherSuit = new PlayingCard(CardValue.Ace, CardSuit.Diamonds);
            var targetValue = new PlayingCard(CardValue.Ace, CardSuit.Clubs);
            var otherValue = new PlayingCard(CardValue.King, CardSuit.Clubs);

            var targetSuitHashCode = targetSuit.GetHashCode();
            var otherSuitHashCode = otherSuit.GetHashCode();
            var targetValueHashCode = targetValue.GetHashCode();
            var otherValueHashCode = otherValue.GetHashCode();

            Assert.AreNotEqual(targetSuitHashCode, otherSuitHashCode);
            Assert.AreNotEqual(targetValueHashCode, otherValueHashCode);
        }

        [TestMethod]
        public void GetHashCodeTest_DistinctDifferentObjects_ReturnsDifferentHashCode()
        {
            var target = new PlayingCard(CardValue.Ace, CardSuit.Clubs);
            var other = new PlayingCard(CardValue.King, CardSuit.Spades);

            var targetHashCode = target.GetHashCode();
            var otherHashCode = other.GetHashCode();

            Assert.AreNotEqual(targetHashCode, otherHashCode);
        }

        [TestMethod()]
        public void ToStringTest_ByDefault_ReturnsString()
        {
            var target = new PlayingCard(CardValue.Ace, CardSuit.Spades);

            var actual = target.ToString();

            Assert.AreEqual("Ace of Spades", actual);
        }

        [TestMethod()]
        public void CompareToTest_SameSuitAndValue_ReturnsZero()
        {
            var target = new PlayingCard(CardValue.Ace, CardSuit.Clubs);
            var other = new PlayingCard(CardValue.Ace, CardSuit.Clubs);

            var actual = target.CompareTo(other);

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void CompareToTest_GreaterSuit_ReturnsOne()
        {
            var target = new PlayingCard(CardValue.Ace, CardSuit.Spades);
            var other = new PlayingCard(CardValue.Ace, CardSuit.Clubs);

            var actual = target.CompareTo(other);

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void CompareToTest_LesserSuit_ReturnsNegativeOne()
        {
            var target = new PlayingCard(CardValue.Ace, CardSuit.Clubs);
            var other = new PlayingCard(CardValue.Ace, CardSuit.Spades);

            var actual = target.CompareTo(other);

            Assert.AreEqual(-1, actual);
        }

        [TestMethod]
        public void CompareToTest_LesserCardValue_ReturnsNegativeOne()
        {
            var target = new PlayingCard(CardValue.Two, CardSuit.Clubs);
            var other = new PlayingCard(CardValue.Three, CardSuit.Clubs);

            var actual = target.CompareTo(other);

            Assert.AreEqual(-1, actual);
        }

        [TestMethod]
        public void CompareToTest_GreaterCardValue_ReturnsOne()
        {
            var target = new PlayingCard(CardValue.King, CardSuit.Clubs);
            var other = new PlayingCard(CardValue.Two, CardSuit.Clubs);

            var actual = target.CompareTo(other);

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void CompareToTest_LesserSuitAndValue_ReturnsNegativeOne()
        {
            var target = new PlayingCard(CardValue.Two, CardSuit.Hearts);
            var other = new PlayingCard(CardValue.King, CardSuit.Spades);

            var actual = target.CompareTo(other);

            Assert.AreEqual(-1, actual);
        }

        [TestMethod]
        public void CompareToTest_GreaterSuitAndValue_ReturnsOne()
        {
            var target = new PlayingCard(CardValue.Queen, CardSuit.Diamonds);
            var other = new PlayingCard(CardValue.Four, CardSuit.Clubs);

            var actual = target.CompareTo(other);

            Assert.AreEqual(1, actual);
        }
    }
}