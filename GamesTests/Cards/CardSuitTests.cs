// <copyright file="CardSuitTests.cs" company="ShooShoSha">
// Copyright (c) 2017 Kevin "ShooShoSha" O'Brien
// </copyright>
namespace GamesTests.Cards
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ShooShosha.Games.Cards;

    /// <summary>
    /// Provides test against <see cref="CardSuit"/>.
    /// </summary>
    [TestClass]
    public class CardSuitTests
    {
        /// <summary>
        /// Asserts the values of the card suits.
        /// </summary>
        [TestMethod]
        public void CardSuit_AssertSuits()
        {
            Assert.AreEqual(0, (int)CardSuit.Hearts);
            Assert.AreEqual(1, (int)CardSuit.Clubs);
            Assert.AreEqual(2, (int)CardSuit.Diamonds);
            Assert.AreEqual(3, (int)CardSuit.Spades);
        }
    }
}
