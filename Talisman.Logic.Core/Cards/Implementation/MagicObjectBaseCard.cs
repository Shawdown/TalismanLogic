using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Decks.Abstract;

namespace Talisman.Logic.Core.Cards.Implementation;

/// <summary>
/// Magic object card.
/// </summary>
public abstract class MagicObjectBaseCard : ObjectBaseCard
{
    /// <inheritdoc />
    public override CardType Type => CardType.MagicObject;

    /// <inheritdoc />
    protected MagicObjectBaseCard(int id, IDeck deck, IDeck discardDeck = null) : base(id, deck, discardDeck)
    {
    }
}