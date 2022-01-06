using System;
using Talisman.Logic.Core.Events.Abstract;
using Talisman.Logic.Core.GameField.Abstract;
using Talisman.Logic.Core.Players.Abstract;
using Talisman.Logic.Core.Players.Implementation;

namespace Talisman.Logic.Core.Events.Implementation;

/// <summary>
/// Represent an event that teleports a player.
/// </summary>
public class TeleportEvent : BaseEvent, IPlayerEvent
{
    /// <inheritdoc />
    public override EventType EventType => EventType.Teleport;

    /// <inheritdoc />
    public IPlayer TargetPlayer { get; }

    /// <summary>
    /// Game field cell to teleport player to.
    /// </summary>
    public IFieldCell TargetCell { get; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// 
    /// <param name="targetPlayer">Player this event targets.</param>
    /// <param name="targetCell">Game field cell to teleport player to.</param>
    /// 
    /// <exception cref="ArgumentNullException"></exception>
    public TeleportEvent(Player targetPlayer, IFieldCell targetCell)
    {
        TargetPlayer = targetPlayer ?? throw new ArgumentNullException(nameof(targetPlayer));
        TargetCell = targetCell ?? throw new ArgumentNullException(nameof(targetCell));
    }

    /// <summary>
    /// Changes TargetPlayer's <see cref="IPlayer.FieldCell"/> to <see cref="TargetCell"/>.
    /// </summary>
    public override void Execute()
    {
        TargetPlayer.FieldCell = TargetCell;
    }
}