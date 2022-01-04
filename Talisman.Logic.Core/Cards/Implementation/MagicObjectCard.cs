using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Decks.Abstract;

namespace Talisman.Logic.Core.Cards.Implementation
{
    /// <summary>
    /// Magic object card.
    /// </summary>
    public class MagicObjectCard : ObjectCard
    {
        /// <inheritdoc />
        public override CardType Type => CardType.MagicObject;

        /// <inheritdoc />
        protected MagicObjectCard(string name, string description, Deck deck, Deck discardDeck) : base(name, description, deck, discardDeck)
        {
        }
    }
}