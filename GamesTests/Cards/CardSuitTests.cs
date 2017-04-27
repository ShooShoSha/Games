// <copyright file="CardSuitTests.cs" company="ShooShoSha">
// Copyright (c) 2017 Kevin "ShooShoSha" O'Brien
// </copyright>
namespace GamesTests.Cards
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ShooShosha.Games.Cards;

    [TestClass]
    public class CardSuitTests
    {
        [TestMethod]
        public void CardValue_HeartsIsLeast()
        {
            Assert.IsTrue(CardSuit.Hearts.CompareTo(CardSuit.Clubs) < 0);
            Assert.IsTrue(CardSuit.Hearts.CompareTo(CardSuit.Diamonds) < 0);
            Assert.IsTrue(CardSuit.Hearts.CompareTo(CardSuit.Spades) < 0);
        }

        [TestMethod]
        public void CardValue_SpadesIsGreatest()
        {
            Assert.IsTrue(CardSuit.Spades.CompareTo(CardSuit.Hearts) > 0);
            Assert.IsTrue(CardSuit.Spades.CompareTo(CardSuit.Clubs) > 0);
            Assert.IsTrue(CardSuit.Spades.CompareTo(CardSuit.Diamonds) > 0);
        }

        [TestMethod]
        public void CardValue_ClubsGreaterThanHeartsLessThanDiamondsAndSpades()
        {
            Assert.IsTrue(CardSuit.Clubs.CompareTo(CardSuit.Hearts) > 0);
            Assert.IsTrue(CardSuit.Clubs.CompareTo(CardSuit.Diamonds) < 0);
            Assert.IsTrue(CardSuit.Clubs.CompareTo(CardSuit.Spades) < 0);
        }

        [TestMethod]
        public void CardValue_DiamondsGreaterThanHeartsAndClubsLessThanSpades()
        {
            Assert.IsTrue(CardSuit.Diamonds.CompareTo(CardSuit.Hearts) > 0);
            Assert.IsTrue(CardSuit.Diamonds.CompareTo(CardSuit.Clubs) > 0);
            Assert.IsTrue(CardSuit.Diamonds.CompareTo(CardSuit.Spades) < 0);
        }
    }
}
