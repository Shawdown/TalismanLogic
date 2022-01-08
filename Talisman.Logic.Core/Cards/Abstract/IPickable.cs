using System.Collections.Generic;
using Talisman.Logic.Core.Events.Abstract;
using Talisman.Logic.Core.Game.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Cards.Abstract;

/// <summary>
/// Defines properties and methods for classes representing cards that players can pick up.
/// </summary>
public interface IPickableCard : ICard
{
    /// <summary>
    /// Current owner of this Card.
    /// </summary>
    IPlayer Owner { get; set; }

    /// <summary>
    /// Gets events need to be executed after this card has been picked up by its <see cref="Owner"/>.
    /// </summary>
    /// 
    /// <param name="gameData">Current game's data.</param>
    /// <param name="player">Player that picked up the card.</param>
    /// 
    /// <returns>Collection of events to be executed in the provided order after this card has been picked up.</returns>
    IEnumerable<IEvent> GetPickupEvents(IGameData gameData, IPlayer player);

    /// <summary>
    /// Gets events need to be executed after this card has been dropped by the player.
    /// </summary>
    /// 
    /// <param name="gameData">Current game's data.</param>
    /// <param name="player">Player that dropped the card.</param>
    /// 
    /// <returns>Collection of events to be executed in the provided order after this card has been dropped.</returns>
    IEnumerable<IEvent> GetDropEvents(IGameData gameData, IPlayer player);

    /// <summary>
    /// Checks whether the player can pick up this Card.
    /// </summary>
    /// 
    /// <param name="gameData">Current game's data.</param>
    /// <param name="player">Player to be checked.</param>
    /// 
    /// <returns>true if the player <paramref name="player"/> can own this Card; false otherwise.</returns>
    bool CanBePickedUpByPlayer(IGameData gameData, IPlayer player);

    /// <summary>
    /// Checks whether the current owner can drop this Card.
    /// </summary>
    /// 
    /// <param name="gameData">Current game's data.</param>
    /// <param name="player">Player to be checked.</param>
    /// <returns>true if <see cref="Owner"/> can drop this Card; false otherwise.</returns>
    bool CanBeDroppedByPlayer(IGameData gameData, IPlayer player);
}