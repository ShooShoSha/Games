// <copyright file="PlayingCardDeck.cs" company="ShooShoSha">
// Copyright (c) 2017 Kevin "ShooShoSha" O'Brien
// </copyright>
namespace ShooShosha.Games.Cards
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Provides methods of handling a deck of playing cards.
    /// </summary>
    public static class PlayingCardDeck
    {
        /// <summary>
        /// An instance of a pseudorandom number generator.
        /// </summary>
        private static Random random = new Random();

        /// <summary>
        /// Gets a standard set of <see cref="PlayingCard"/>.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{PlayingCard}"/> collection.</returns>
        public static IEnumerable<PlayingCard> GetCards()
        {
            var cards = new List<PlayingCard>();
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
                {
                    cards.Add(new PlayingCard(value, suit));
                }
            }

            return cards;
        }

        /// <summary>
        /// Returns a sorted deck.
        /// </summary>
        /// <typeparam name="T">The type of elements in the deck.</typeparam>
        /// <param name="deck">A deck of <typeparamref name="T"/> cards.</param>
        /// <returns>A sorted deck.</returns>
        public static IEnumerable<T> Sort<T>(IEnumerable<T> deck)
        {
            var sortedDeck = new List<T>(deck);
            sortedDeck.Sort();
            return sortedDeck;
        }

        /// <summary>
        /// Returns a shuffled deck.
        /// </summary>
        /// <remarks>
        /// Based off the Fisher-Yates algorithm <see href="https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle"/>
        /// </remarks>
        /// <typeparam name="T">the type of the elements in the collection.</typeparam>
        /// <param name="deck">A deck of <typeparamref name="T"/> cards.</param>
        /// <returns>A pseudorandom shuffle of the <paramref name="deck"/>.</returns>
        public static IEnumerable<T> Shuffle<T>(IEnumerable<T> deck)
        {
            var s = new List<T>(deck);
            for (int i = s.Count - 1; i > 0; i--)
            {
                int r = random.Next(i + 1);
                T temp = s[i];
                s[i] = s[r];
                s[r] = temp;
            }

            return s;
        }
    }
}
