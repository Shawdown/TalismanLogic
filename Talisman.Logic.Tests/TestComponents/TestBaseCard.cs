using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Cards.Implementation;
using Talisman.Logic.Core.Decks.Implementation;
using Talisman.Logic.Core.Encounters.Abstract;
using Talisman.Logic.Core.Game.Abstract;
using Talisman.Logic.Core.Game.Implementation;
using Talisman.Logic.Core.Players.Abstract;
using Talisman.Logic.Core.Players.Implementation;

namespace Talisman.Game.Logic.Tests.TestComponents;

/// <summary>
/// BaseCard class to be used for unit-testing.
/// </summary>
public class TestBaseCard : BaseCard
{
    /// <summary>
    /// Specified whether the Card can be owned by a player.
    /// </summary>
    public bool IsOwnable { get; set; } = false;

    /// <inheritdoc />
    public override CardType Type => CardType.MagicObject;

    /// <inheritdoc />
    public override bool CanBeOwnedByPlayer(IGameData gameData, IPlayer player) => IsOwnable;

    /// <inheritdoc />
    public TestBaseCard(Deck deck, Deck discardDeck = null) : base(1, deck, discardDeck)
    {
    }

    /// <inheritdoc />
    public override IEncounterResult Encounter(IGameData gameData, IPlayer player) => throw new System.NotImplementedException();
}