using System.Collections.Generic;
using System.Linq;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Decks.Abstract;
using Talisman.Logic.Core.Events.Abstract;
using Talisman.Logic.Core.Game.Abstract;
using Talisman.Logic.Core.Game.Implementation;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Cards.Implementation;

/// <summary>
/// Base class for game cards that can be picked up by players.
/// </summary>
public abstract class BasePickableCard : BaseCard, IPickableCard
{
    /// <inheritdoc />
    public IPlayer Owner { get; set; }

    /// <inheritdoc />
    protected BasePickableCard(int id, IDeck deck, IDeck discardDeck = null) : base(id, deck, discardDeck)
    {
    }

    /// <inheritdoc />
    public virtual IEnumerable<IEvent> GetPickupEvents(GameData gameData, IPlayer player) => Enumerable.Empty<IEvent>();

    /// <inheritdoc />
    public virtual IEnumerable<IEvent> GetDropEvents(GameData gameData, IPlayer player) => Enumerable.Empty<IEvent>();

    /// <inheritdoc />
    public virtual bool CanBePickedUpByPlayer(GameData gameData, IPlayer player) => true;

    /// <inheritdoc />
    public virtual bool CanBeDroppedByPlayer(GameData gameData, IPlayer player) => player != null && Owner == player;
}