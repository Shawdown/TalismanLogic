using System;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Cards.Implementation;
using Talisman.Logic.Core.Events.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Events.Implementation;

/// <summary>
/// Represents a game card discard event.
/// </summary>
public class DiscardCardEvent : BaseEvent, ICardEvent
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
    public override void Execute()
    {
        if (TargetCard.DiscardDeck is null)
        {
            // It's a non-discardable Card.
            return;
        }
        else if (TargetCard.Owner != null)
        {
            TargetCard.Owner.OwnedCards.Remove(TargetCard);
            TargetCard.Owner = null;
        }

        TargetCard.DiscardDeck.Cards.Add(TargetCard);
    }
}