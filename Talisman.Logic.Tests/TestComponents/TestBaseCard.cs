using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Cards.Implementation;
using Talisman.Logic.Core.Decks.Implementation;
using Talisman.Logic.Core.Encounters.Abstract;
using Talisman.Logic.Core.Game.Abstract;
using Talisman.Logic.Core.Game.Implementation;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Game.Logic.Tests.TestComponents;

/// <summary>
/// BaseCard class to be used for unit-testing.
/// </summary>
public class TestBaseCard : BasePickableCard
{
    /// <summary>
    /// Specified whether the Card can be picked up by a player.
    /// </summary>
    public bool IsPickable { get; set; } = false;

    /// <inheritdoc />
    public override CardType Type => CardType.MagicObject;

    /// <inheritdoc />
    public TestBaseCard(Deck deck, Deck discardDeck = null) : base(1, deck, discardDeck)
    {
    }

    /// <inheritdoc />
    public override bool CanBePickedUpByPlayer(GameData gameData, IPlayer player) => IsPickable;
}