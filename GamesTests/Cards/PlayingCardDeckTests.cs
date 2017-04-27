// <copyright file="PlayingCardDeckTests.cs" company="ShooShoSha">
// Copyright (c) 2017 Kevin "ShooShoSha" O'Brien
// </copyright>
namespace ShooShosha.Games.Cards.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass()]
    public class PlayingCardDeckTests
    {
        [TestMethod()]
        public void GetCardsTest_ByDefault_ReturnsStandardDeckOfCards()
        {
            var target = PlayingCardDeck.GetCards();

            Assert.AreEqual(52, target.Count());
        }

        [TestMethod]
        public void ShuffleTest_NumberOfCardsRemainsConstant()
        {
            var target = PlayingCardDeck.GetCards();

            var actual = PlayingCardDeck.Shuffle(target);

            Assert.AreEqual(target.Count(), actual.Count());
            Assert.AreNotEqual(target, actual);
        }

        [TestMethod]
        public void SortTest_NumberOfCardsRemainConstant()
        {
            var target = PlayingCardDeck.GetCards();

            var actual = PlayingCardDeck.Sort(target);

            Assert.AreEqual(target.Count(), actual.Count());
        }

        [TestMethod]
        public void SortTest_DeckIsSorted()
        {
            var expected = new List<PlayingCard>()
            {
                new PlayingCard(CardValue.Ace, CardSuit.Hearts),
                new PlayingCard(CardValue.Two, CardSuit.Hearts),
                new PlayingCard(CardValue.Three, CardSuit.Hearts),
                new PlayingCard(CardValue.Four, CardSuit.Hearts),
                new PlayingCard(CardValue.Five, CardSuit.Hearts),
                new PlayingCard(CardValue.Six, CardSuit.Hearts),
                new PlayingCard(CardValue.Seven, CardSuit.Hearts),
                new PlayingCard(CardValue.Eight, CardSuit.Hearts),
                new PlayingCard(CardValue.Nine, CardSuit.Hearts),
                new PlayingCard(CardValue.Ten, CardSuit.Hearts),
                new PlayingCard(CardValue.Jack, CardSuit.Hearts),
                new PlayingCard(CardValue.Queen, CardSuit.Hearts),
                new PlayingCard(CardValue.King, CardSuit.Hearts),
                new PlayingCard(CardValue.Ace, CardSuit.Clubs),
                new PlayingCard(CardValue.Two, CardSuit.Clubs),
                new PlayingCard(CardValue.Three, CardSuit.Clubs),
                new PlayingCard(CardValue.Four, CardSuit.Clubs),
                new PlayingCard(CardValue.Five, CardSuit.Clubs),
                new PlayingCard(CardValue.Six, CardSuit.Clubs),
                new PlayingCard(CardValue.Seven, CardSuit.Clubs),
                new PlayingCard(CardValue.Eight, CardSuit.Clubs),
                new PlayingCard(CardValue.Nine, CardSuit.Clubs),
                new PlayingCard(CardValue.Ten, CardSuit.Clubs),
                new PlayingCard(CardValue.Jack, CardSuit.Clubs),
                new PlayingCard(CardValue.Queen, CardSuit.Clubs),
                new PlayingCard(CardValue.King, CardSuit.Clubs),
                new PlayingCard(CardValue.Ace, CardSuit.Diamonds),
                new PlayingCard(CardValue.Two, CardSuit.Diamonds),
                new PlayingCard(CardValue.Three, CardSuit.Diamonds),
                new PlayingCard(CardValue.Four, CardSuit.Diamonds),
                new PlayingCard(CardValue.Five, CardSuit.Diamonds),
                new PlayingCard(CardValue.Six, CardSuit.Diamonds),
                new PlayingCard(CardValue.Seven, CardSuit.Diamonds),
                new PlayingCard(CardValue.Eight, CardSuit.Diamonds),
                new PlayingCard(CardValue.Nine, CardSuit.Diamonds),
                new PlayingCard(CardValue.Ten, CardSuit.Diamonds),
                new PlayingCard(CardValue.Jack, CardSuit.Diamonds),
                new PlayingCard(CardValue.Queen, CardSuit.Diamonds),
                new PlayingCard(CardValue.King, CardSuit.Diamonds),
                new PlayingCard(CardValue.Ace, CardSuit.Spades),
                new PlayingCard(CardValue.Two, CardSuit.Spades),
                new PlayingCard(CardValue.Three, CardSuit.Spades),
                new PlayingCard(CardValue.Four, CardSuit.Spades),
                new PlayingCard(CardValue.Five, CardSuit.Spades),
                new PlayingCard(CardValue.Six, CardSuit.Spades),
                new PlayingCard(CardValue.Seven, CardSuit.Spades),
                new PlayingCard(CardValue.Eight, CardSuit.Spades),
                new PlayingCard(CardValue.Nine, CardSuit.Spades),
                new PlayingCard(CardValue.Ten, CardSuit.Spades),
                new PlayingCard(CardValue.Jack, CardSuit.Spades),
                new PlayingCard(CardValue.Queen, CardSuit.Spades),
                new PlayingCard(CardValue.King, CardSuit.Spades),
            };

            var actual = PlayingCardDeck.Sort(PlayingCardDeck.GetCards());

            Assert.AreEqual(expected.Count(), actual.Count());
            Assert.IsTrue(Enumerable.SequenceEqual(expected, actual));
        }
    }
}