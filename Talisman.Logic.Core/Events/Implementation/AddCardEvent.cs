using System;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Cards.Implementation;
using Talisman.Logic.Core.Events.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Events.Implementation;

/// <summary>
/// Represents an event that gives a card to a player.
/// </summary>
public class AddCardEvent : BaseEvent, ICardEvent, IPlayerEvent
{
    /// <inheritdoc />
    public override EventType EventType => EventType.AddCard;

    /// <inheritdoc />
    public ICard TargetCard { get; }

    /// <inheritdoc />
    public IPlayer TargetPlayer { get; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// 
    /// <param name="targetCard">Game card this event targets.</param>
    /// <param name="targetPlayer">Player this event targets.</param>
    public AddCardEvent(ICard targetCard, IPlayer targetPlayer)
    {
        TargetCard = targetCard ?? throw new ArgumentNullException(nameof(targetCard));
        TargetPlayer = targetPlayer ?? throw new ArgumentNullException(nameof(targetPlayer));
    }

    /// <inheritdoc />
    public override void Execute()
    {
        CardUtils.SetCardOwner(null, TargetCard, TargetPlayer);
    }
}