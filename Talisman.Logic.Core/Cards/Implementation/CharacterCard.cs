using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Decks.Abstract;

namespace Talisman.Logic.Core.Cards.Implementation;

/// <summary>
/// Character card.
/// </summary>
public abstract class CharacterCard : BaseCard, ICharacterCard
{
    /// <inheritdoc />
    public override CardType Type => CardType.Character;

    /// <inheritdoc />
    protected CharacterCard(int id, IDeck deck, IDeck discardDeck = null) : base(id, deck, discardDeck)
    {
    }
}