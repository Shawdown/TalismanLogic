using System;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Decks.Abstract;
using Talisman.Logic.Core.Game.Abstract;

namespace Talisman.Logic.Core.Cards.Implementation
{
    /// <summary>
    /// Base class for the cards that can be owned by players.
    /// </summary>
    public abstract class BaseOwnableCard : BaseCard, IOwnable
    {
        /// <summary>
        /// Card's owner.
        /// </summary>
        public Player Owner { get; set; }

        /// <inheritdoc />
        public virtual bool CanBeOwnedByPlayer(GameData gameData, Player player) => true;

        /// <inheritdoc />
        public void SetOwner(GameData gameData, Player player)
        {
            if (player == null) throw new ArgumentNullException(nameof(player));

            Owner = player;
            player.OwnedCards.Add(this);
        }

        /// <inheritdoc />
        protected BaseOwnableCard(string name, string description, Deck deck, Deck discardDeck = null) : base(name, description, deck, discardDeck)
        {
        }
    }
}