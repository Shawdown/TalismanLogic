using System;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Decks.Abstract;

namespace Talisman.Logic.Core.Cards.Implementation
{
    /// <summary>
    /// Base class for game cards.
    /// </summary>
    public abstract class BaseCard
    {
        /// <summary>
        /// Card's name.
        /// </summary>
        public virtual string Name { get; }

        /// <summary>
        /// Card's type.
        /// </summary>
        public abstract CardType Type { get; }

        /// <summary>
        /// Card's description.
        /// </summary>
        public virtual string Description { get; }

        /// <summary>
        /// Deck this card belongs to.
        /// </summary>
        public Deck Deck { get; }

        /// <summary>
        /// Discard deck this card belongs to.
        /// </summary>
        public Deck DiscardDeck { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// 
        /// <param name="name">Card's name.</param>
        /// <param name="description">Card's description.</param>
        /// <param name="deck">Deck this card belongs to.</param>
        /// <param name="discardDeck">Discard deck this card belongs to (for the cards implementing <see cref="IDiscardable"/>).</param>
        /// 
        /// <exception cref="ArgumentNullException"></exception>
        protected BaseCard(string name, string description, Deck deck, Deck discardDeck)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Deck = deck ?? throw new ArgumentNullException(nameof(deck));
            DiscardDeck = discardDeck ?? throw new ArgumentNullException(nameof(discardDeck));
        }
    }
}