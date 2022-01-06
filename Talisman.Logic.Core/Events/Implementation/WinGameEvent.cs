using System;
using Talisman.Logic.Core.Events.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Events.Implementation;

/// <summary>
/// Represents an event that makes the player win the game.
/// </summary>
public class WinGameEvent : BaseEvent, IPlayerEvent
{
    /// <inheritdoc />
    public override EventType EventType => EventType.WinGame;

    /// <inheritdoc />
    public IPlayer TargetPlayer { get; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// 
    /// <param name="targetPlayer">Player this event targets.</param>
    /// 
    /// <exception cref="ArgumentNullException"></exception>
    public WinGameEvent(IPlayer targetPlayer)
    {
        TargetPlayer = targetPlayer ?? throw new ArgumentNullException(nameof(targetPlayer));
    }

    /// <inheritdoc />
    public override void Execute()
    {
        TargetPlayer.AdditionalPlayerState.Won = true;
    }
}