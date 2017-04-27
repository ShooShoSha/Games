// <copyright file="PlayingCard.cs" company="ShooShoSha">
// Copyright (c) 2017 Kevin "ShooShoSha" O'Brien
// </copyright>
namespace ShooShosha.Games.Cards
{
    using System;

    /// <summary>
    /// Represents a single playing card.
    /// </summary>
    public class PlayingCard : IEquatable<PlayingCard>, IComparable<PlayingCard>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayingCard"/> class.
        /// </summary>
        /// <param name="value">The value of the card.</param>
        /// <param name="suit">The suit of the card.</param>
        public PlayingCard(CardValue value, CardSuit suit)
        {
            this.Value = value;
            this.Suit = suit;
        }

        /// <summary>
        /// Gets the value of the card.
        /// </summary>
        public CardValue Value { get; private set; }

        /// <summary>
        /// Gets the suit of the card.
        /// </summary>
        public CardSuit Suit { get; private set; }

        /// <summary>
        /// Indicates whether the current <see cref="PlayingCard"/> is equal to another <see cref="PlayingCard"/>.
        /// </summary>
        /// <param name="other">The other <see cref="PlayingCard"/> to compare.</param>
        /// <returns><see cref="true"/> if the current object is equal to the <paramref name="other"/> parameter; <see cref="false"/> otherwise.</returns>
        /// <see cref="IEquatable{T}.Equals(T)"/>
        public bool Equals(PlayingCard other)
        {
            return other != null &&
                this.Value == other.Value &&
                this.Suit == other.Suit;
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object.
        /// </summary>
        /// <param name="obj">The other object to compare.</param>
        /// <returns><see cref="true"/> if the current object is equal to the <paramref name="obj"/> parameter; <see cref="false"/> otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            return this.Equals(obj as PlayingCard);
        }

        /// <summary>
        /// Serves as a hash function for the <see cref="PlayingCard"/> type.
        /// </summary>
        /// <returns>A hash code for the current <see cref="PlayingCard"/> object.</returns>
        public override int GetHashCode()
        {
            var hashCode = 79;
            hashCode = (hashCode * 563) ^ this.Value.GetHashCode();
            hashCode = (hashCode * 563) ^ this.Suit.GetHashCode();
            return hashCode;
        }

        /// <summary>
        /// Returns a string that represents the current <see cref="PlayingCard"/> object.
        /// </summary>
        /// <returns>A string that represents the current <see cref="PlayingCard"/> object.</returns>
        public override string ToString()
        {
            return $"{this.Value.ToString()} of {this.Suit.ToString()}";
        }

        /// <summary>
        /// Compares the current <see cref="PlayingCard"/> with another.
        /// </summary>
        /// <param name="other">A <see cref="PlayingCard"/> to compare with this object.</param>
        /// <returns>A value indicating the relative order of the objects being compared.</returns>
        /// <seealso cref="IComparable{T}.CompareTo(T)"/>
        public int CompareTo(PlayingCard other)
        {
            var result = this.Suit.CompareTo(other.Suit);
            if (result != 0)
            {
                return result;
            }

            result = this.Value.CompareTo(other.Value);
            if (result != 0)
            {
                return result;
            }

            return 0;
        }
    }
}
