using System;
using System.Collections.Generic;
using System.Linq;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Cards.Implementation;
using Talisman.Logic.Core.Events.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Events.Implementation;

/// <summary>
/// Represents an event that makes a player drop a card.
/// </summary>
public class DropCardEvent : BaseEvent, ICardEvent<IPickableCard>
{
    /// <inheritdoc />
    public override EventType EventType => EventType.DropCard;

    /// <inheritdoc />
    public IPickableCard TargetCard { get; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// 
    /// <param name="targetCard">Game card this event targets.</param>
    public DropCardEvent(IPickableCard targetCard)
    {
        TargetCard = targetCard ?? throw new ArgumentNullException(nameof(targetCard));
    }

    /// <summary>
    /// Sets card's owner to null and places it on its previous owner's game field cell (if set).
    /// </summary>
    public override IEnumerable<IEvent> Execute()
    {
        if (TargetCard.Owner != null && !TargetCard.CanBeDroppedByPlayer(null, TargetCard.Owner))
        {
            // Card cannot be dropped by its current owner.
            return Enumerable.Empty<IEvent>();
        }
        else if (TargetCard.Owner?.FieldCell != null)
        {
            TargetCard.FieldCell = TargetCard.Owner.FieldCell;
        }

        IPlayer previousOwner = TargetCard.Owner;

        CardUtils.SetCardOwner(null, TargetCard, null);

        return TargetCard.GetDropEvents(null, previousOwner);
    }
}