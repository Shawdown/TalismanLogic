using System;
using System.Collections.Generic;
using System.Linq;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Cards.Implementation;
using Talisman.Logic.Core.Events.Abstract;
using Talisman.Logic.Core.GameField.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Events.Implementation;

/// <summary>
/// Represents an event that places a game card on a game field cell.
/// </summary>
public class PlaceCardEvent : BaseEvent, ICardEvent<ICard>, IFieldCellEvent
{
    /// <inheritdoc />
    public override EventType EventType => EventType.PlaceCard;

    /// <inheritdoc />
    public ICard TargetCard { get; }

    /// <summary>
    /// Game field cell to put the card on.
    /// </summary>
    public IFieldCell TargetGameFieldCell { get; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// 
    /// <param name="targetCard">Game card this event targets.</param>
    /// <param name="targetGameFieldCell">Game field cell to put the card on.</param>
    /// 
    /// <exception cref="ArgumentNullException"></exception>
    public PlaceCardEvent(ICard targetCard, IFieldCell targetGameFieldCell)
    {
        TargetCard = targetCard ?? throw new ArgumentNullException(nameof(targetCard));
        TargetGameFieldCell = targetGameFieldCell ?? throw new ArgumentNullException(nameof(targetGameFieldCell));
    }

    /// <summary>
    /// Removes the card's owner (if set) and places the card on the <see cref="TargetGameFieldCell"/>.
    /// </summary>
    public override IEnumerable<IEvent> Execute()
    {
        if (TargetCard is IPickableCard pickableCard)
        {
            IPlayer previoiusOwner = pickableCard.Owner;
            CardUtils.SetCardOwner(null, pickableCard, null);

            return pickableCard.GetDropEvents(null, previoiusOwner);
        }

        TargetCard.FieldCell = TargetGameFieldCell;

        return Enumerable.Empty<IEvent>();
    }
}