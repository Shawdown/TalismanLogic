using System;
using System.Collections.Generic;
using Talisman.Logic.Core.Events.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Events.Implementation;

/// <summary>
/// Represents an event that kills the target player.
/// </summary>
public class KillPlayerEvent : BaseEvent, IPlayerEvent
{
    /// <inheritdoc />
    public override EventType EventType => EventType.KillPlayer;

    /// <inheritdoc />
    public IPlayer TargetPlayer { get; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// 
    /// <param name="targetPlayer">Player this event targets.</param>
    /// 
    /// <exception cref="ArgumentNullException"></exception>
    public KillPlayerEvent(IPlayer targetPlayer)
    {
        TargetPlayer = targetPlayer ?? throw new ArgumentNullException(nameof(targetPlayer));
    }

    /// <inheritdoc />
    public override IEnumerable<IEvent> Execute()
    {
        IList<IEvent> deathEvents = new List<IEvent>();

        // Drop inventory cards events.
        foreach (var pickableCard in TargetPlayer.Inventory.PickableCards)
        {
            deathEvents.Add(new DropCardEvent(pickableCard));
        }

        // Discarding all trophies.
        foreach (var trophy in TargetPlayer.Inventory.Trophies)
        {
            deathEvents.Add(new DiscardCardEvent(trophy));
        }

        // Discarding all spells.
        // TODO

        // Resetting the player's character & stats.
        // TODO

        return deathEvents;
    }
}