// <copyright file="CardValueTests.cs" company="ShooShoSha">
// Copyright (c) 2017 Kevin "ShooShoSha" O'Brien
// </copyright>
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace GamesTests.Cards
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ShooShosha.Games.Cards;

    /// <summary>
    /// Provides tests against <see cref="CardValue"/>
    /// </summary>
    [TestClass]
    public class CardValueTests
    {
        /// <summary>
        /// Asserts the card values.
        /// </summary>
        [TestMethod]
        public void CardValueTest_AssertValues()
        {
            Assert.AreEqual(1, (int)CardValue.Ace);
            Assert.AreEqual(2, (int)CardValue.Two);
            Assert.AreEqual(3, (int)CardValue.Three);
            Assert.AreEqual(4, (int)CardValue.Four);
            Assert.AreEqual(5, (int)CardValue.Five);
            Assert.AreEqual(6, (int)CardValue.Six);
            Assert.AreEqual(7, (int)CardValue.Seven);
            Assert.AreEqual(8, (int)CardValue.Eight);
            Assert.AreEqual(9, (int)CardValue.Nine);
            Assert.AreEqual(10, (int)CardValue.Ten);
            Assert.AreEqual(11, (int)CardValue.Jack);
            Assert.AreEqual(12, (int)CardValue.Queen);
            Assert.AreEqual(13, (int)CardValue.King);
        }

        /// <summary>
        /// Asserts <see cref="CardValue.Ace"/> is the lowest value.
        /// </summary>
        /// <remarks>
        /// This contradicts the test <see cref="CardValueTest_AceIsHigh"/>.
        /// </remarks>
        /// <seealso cref="CardValueTest_AceIsHigh"/>
        [TestMethod]
        public void CardValueTest_AceIsLow()
        {
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.Two) < 0);
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.Three) < 0);
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.Four) < 0);
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.Five) < 0);
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.Six) < 0);
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.Seven) < 0);
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.Eight) < 0);
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.Nine) < 0);
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.Ten) < 0);
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.Jack) < 0);
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.Queen) < 0);
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.King) < 0);
        }

        /// <summary>
        /// Asserts <see cref="CardValue.Ace"/> is the highest value.
        /// </summary>
        /// <remarks>
        /// This contradicts the test <see cref="CardValueTest_AceIsLow"/>.
        /// </remarks>
        /// <seealso cref="CardValueTest_AceIsLow"/>
        [TestMethod, Ignore]
        public void CardValueTest_AceIsHigh()
        {
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.Two) > 0);
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.Three) > 0);
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.Four) > 0);
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.Five) > 0);
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.Six) > 0);
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.Seven) > 0);
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.Eight) > 0);
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.Nine) > 0);
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.Ten) > 0);
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.Jack) > 0);
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.Queen) > 0);
            Assert.IsTrue(CardValue.Ace.CompareTo(CardValue.King) > 0);
        }
    }
}
