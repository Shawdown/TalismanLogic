using System;
using System.Collections.Generic;
using System.Linq;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Cards.Implementation;
using Talisman.Logic.Core.Decks.Abstract;
using Talisman.Logic.Core.Events.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Events.Implementation;

/// <summary>
/// Represents a game card burn event.
/// </summary>
public class BurnCardEvent : BaseEvent, ICardEvent<ICard>, IDeckEvent
{
    /// <inheritdoc />
    public override EventType EventType => EventType.BurnCard;

    /// <inheritdoc />
    public ICard TargetCard { get; }

    /// <summary>
    /// Game card deck to transfer the card after it's been burnt.
    /// </summary>
    public IDeck TargetDeck { get; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// 
    /// <param name="targetCard">Game card this event targets.</param>
    /// <param name="targetDeck">Game card deck to transfer the card after it's been burnt.</param>
    public BurnCardEvent(ICard targetCard, IDeck targetDeck)
    {
        TargetCard = targetCard ?? throw new ArgumentNullException(nameof(targetCard));
        TargetDeck = targetDeck ?? throw new ArgumentNullException(nameof(targetDeck));
    }

    /// <summary>
    /// Removes the card from its owner's inventory (if set), sets its <see cref="ICard.Burnt"/> to true and sets its <see cref="ICard.CurrentDeck"/> to <see cref="TargetDeck"/>.
    /// </summary>
    public override IEnumerable<IEvent> Execute()
    {
        if (!TargetCard.Burnable)
        {
            // Card cannot be burnt.
            return Enumerable.Empty<IEvent>();
        }

        TargetCard.Burnt = true;
        TargetDeck.Cards.Add(TargetCard);
        TargetCard.CurrentDeck = TargetDeck;

        if (TargetCard is IPickableCard pickableCard)
        {
            IPlayer previousCardOwner = pickableCard.Owner;
            CardUtils.SetCardOwner(null, pickableCard, null);

            return pickableCard.GetDropEvents(null, previousCardOwner);
        }

        return Enumerable.Empty<IEvent>();
    }
}