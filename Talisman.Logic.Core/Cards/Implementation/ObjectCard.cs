using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Decks.Abstract;
using Talisman.Logic.Core.Game.Abstract;

namespace Talisman.Logic.Core.Cards.Implementation
{
    /// <summary>
    /// Object card.
    /// </summary>
    public class ObjectCard : BaseOwnableCard, IDiscardable
    {
        /// <inheritdoc />
        public override CardType Type => CardType.Object;

        /// <inheritdoc />
        protected ObjectCard(string name, string description, Deck deck, Deck discardDeck) : base(name, description, deck, discardDeck)
        {
        }

        /// <inheritdoc />
        public virtual void Discard(GameData gameData, Player player = null)
        {
            if (player != null && player.OwnedCards.Contains(this))
            {
                player.OwnedCards.Remove(this);
            }

            DiscardDeck.Cards.Add(this);
        }
    }
}