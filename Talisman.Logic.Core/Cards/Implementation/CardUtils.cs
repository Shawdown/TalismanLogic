using System;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Decks.Abstract;
using Talisman.Logic.Core.Game.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Cards.Implementation;

/// <summary>
/// Static utility methods for Card-related operations.
/// </summary>
public static class CardUtils
{
    /// <summary>
    /// Sets the specified player as the owner of the Card.
    /// </summary>
    /// 
    /// <param name="gameData">Current game's data.</param>
    /// <param name="card">BaseCard to change ownership of.</param>
    /// <param name="player">Player to be set as an owner (can be null if the Card lost its owner).</param>
    public static void SetCardOwner(IGameData gameData, ICard card, IPlayer player)
    {
        if (card == null) throw new ArgumentNullException(nameof(card));

        if ((player != null && !card.CanBeOwnedByPlayer(gameData, player)) || card.Owner == player)
        {
            return;
        }
        else if (card.Owner != null)
        {
            card.Owner.OwnedCards.Remove(card);
        }
        
        player?.OwnedCards.Add(card);
        card.Owner = player;
    }

    /// <summary>
    /// Removes the card from its owner's inventory (if set), sets its <see cref="ICard.Burnt"/> to true and sets its <see cref="ICard.CurrentDeck"/> to <paramref name="burntCardsDeck"/>.
    /// </summary>
    /// 
    /// <param name="gameData">Current game's data.</param>
    /// <param name="card">Card to burn.</param>
    /// <param name="burntCardsDeck">Burnt cards deck to put the card into.</param>
    public static void BurnCard(IGameData gameData, ICard card, IDeck burntCardsDeck)
    {
        if (card == null) throw new ArgumentNullException(nameof(card));
        if (burntCardsDeck == null) throw new ArgumentNullException(nameof(burntCardsDeck));

        SetCardOwner(gameData, card, null);

        card.Burnt = true;
        burntCardsDeck.Cards.Add(card);
        card.CurrentDeck = burntCardsDeck;
    }
}