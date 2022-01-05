using Talisman.Logic.Core.Cards.Implementation;
using Talisman.Logic.Core.Decks.Implementation;

namespace Talisman.Logic.ExternalPackageExample.Objects
{
    public sealed class Sword : ObjectBaseCard
    {
        /// <inheritdoc />
        public Sword(Deck deck, Deck discardDeck) : base(1337, deck, discardDeck)
        {
        }
    }
}