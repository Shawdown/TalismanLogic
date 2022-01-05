using System;
using Talisman.Logic.Core.Cards.Implementation;
using Talisman.Logic.Core.Game.Implementation;
using Talisman.Logic.Core.Players.Implementation;

namespace Talisman.Logic.Core.Gameplay.Implementation;

/// <summary>
/// Static manager for Card-related operations.
/// </summary>
public static class CardManager
{
    /// <summary>
    /// Discards the Card.
    /// </summary>
    ///
    /// <param name="gameData">Current game's data.</param>
    /// <param name="card">BaseCard to be discarded.</param>
    public static void Discard(GameData gameData, BaseCard card)
    {
        if (card == null) throw new ArgumentNullException(nameof(card));

        if (card.DiscardDeck is null)
        {
            // It's a non-discardable Card.
            return;
        }
        else if (card.Owner != null)
        {
            card.Owner.OwnedCards.Remove(card);
            card.Owner = null;
        }

        card.DiscardDeck.Cards.Add(card);
    }

    /// <summary>
    /// Sets the specified player as the owner of the Card.
    /// </summary>
    /// 
    /// <param name="gameData">Current game's data.</param>
    /// <param name="card">BaseCard to change ownership of.</param>
    /// <param name="player">Player to be set as an owner (can be null if the Card lost its owner).</param>
    public static void SetCardOwner(GameData gameData, BaseCard card, Player player)
    {
        if (card == null) throw new ArgumentNullException(nameof(card));

        if (!card.CanBeOwnedByPlayer(gameData, player) || card.Owner == player)
        {
            return;
        }
        else if (card.Owner != null)
        {
            card.Owner.OwnedCards.Remove(card);
        }

        card.Owner = player;
        player?.OwnedCards.Add(card);
    }
}