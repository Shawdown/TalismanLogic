using System;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Decks.Abstract;
using Talisman.Logic.Core.Encounters.Abstract;
using Talisman.Logic.Core.Encounters.Implementation;
using Talisman.Logic.Core.Game.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Cards.Implementation;

/// <summary>
/// Object card.
/// </summary>
public abstract class ObjectBaseCard : BaseCard
{
    /// <inheritdoc />
    public override CardType Type => CardType.Object;

    /// <inheritdoc />
    public override bool CanBeOwnedByPlayer(IGameData gameData, IPlayer player) => true;

    /// <inheritdoc />
    protected ObjectBaseCard(int id, IDeck deck, IDeck discardDeck = null) : base(id, deck, discardDeck)
    {
    }

    /// <inheritdoc />
    public override IEncounterResult Encounter(IGameData gameData, IPlayer player)
    {
        if (player == null) throw new ArgumentNullException(nameof(player));

        // TODO: get prompt messages from a locale resource file.
        if (CanBeOwnedByPlayer(gameData, player) && player.AskYesOrNo($"Would you like to take {Name}?"))
        {
            Owner?.OwnedCards.Remove(this);

            Owner = player;
            player.OwnedCards.Add(this);
        }

        return new EncounterResult(true);
    }
}