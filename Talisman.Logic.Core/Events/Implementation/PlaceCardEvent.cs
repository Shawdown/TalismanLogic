using System;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Cards.Implementation;
using Talisman.Logic.Core.Events.Abstract;
using Talisman.Logic.Core.GameField.Abstract;

namespace Talisman.Logic.Core.Events.Implementation;

/// <summary>
/// Represents an event that places a game card on a game field cell.
/// </summary>
public class PlaceCardEvent : BaseEvent, ICardEvent, IFieldCellEvent
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
    public override void Execute()
    {
        CardUtils.SetCardOwner(null, TargetCard, null);
        TargetCard.FieldCell = TargetGameFieldCell;
    }
}