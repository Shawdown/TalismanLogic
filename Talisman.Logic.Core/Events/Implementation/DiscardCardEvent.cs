using System;
using System.Collections.Generic;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Cards.Implementation;
using Talisman.Logic.Core.Events.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Events.Implementation;

/// <summary>
/// Represents a game card discard event.
/// </summary>
public class DiscardCardEvent : BaseEvent, ICardEvent<ICard>
{
    /// <inheritdoc />
    public override EventType EventType => EventType.DiscardCard;

    /// <inheritdoc />
    public ICard TargetCard { get; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// 
    /// <param name="targetCard">Game card this event targets.</param>
    public DiscardCardEvent(ICard targetCard)
    {
        TargetCard = targetCard ?? throw new ArgumentNullException(nameof(targetCard));
    }

    /// <summary>
    /// Adds the card to its <see cref="ICard.DiscardDeck"/> (if set), removes it from its owner's <see cref="IPlayer.OwnedCards"/> and sets the <see cref="ICard.Owner"/> to null.
    /// </summary>
    public override IEnumerable<IEvent> Execute()
    {
        IEnumerable<IEvent> result = null;

        if (TargetCard.DiscardDeck is null)
        {
            // It's a non-discardable Card.
            return null;
        }
        else if (TargetCard is IPickableCard pickableCard)
        {
            result = pickableCard.GetDropEvents(null, pickableCard.Owner);

            pickableCard.Owner.Inventory.PickableCards.Remove(pickableCard);
            pickableCard.Owner = null;
        }

        TargetCard.DiscardDeck.Cards.Add(TargetCard);

        return result;
    }
}