using System;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Cards.Implementation;
using Talisman.Logic.Core.Events.Abstract;

namespace Talisman.Logic.Core.Events.Implementation;

/// <summary>
/// Represents an event that makes a player drop a card.
/// </summary>
public class DropCardEvent : BaseEvent, ICardEvent
{
    /// <inheritdoc />
    public override EventType EventType => EventType.DropCard;

    /// <inheritdoc />
    public ICard TargetCard { get; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// 
    /// <param name="targetCard">Game card this event targets.</param>
    public DropCardEvent(ICard targetCard)
    {
        TargetCard = targetCard ?? throw new ArgumentNullException(nameof(targetCard));
    }

    /// <summary>
    /// Sets card's owner to null and places it on its previous owner's game field cell (if set).
    /// </summary>
    public override void Execute()
    {
        if (TargetCard.Owner?.FieldCell != null)
        {
            TargetCard.FieldCell = TargetCard.Owner.FieldCell;
        }

        CardUtils.SetCardOwner(null, TargetCard, null);
    }
}