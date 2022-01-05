using System.Collections.Generic;
using Talisman.Logic.Core.GameField.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Game.Abstract;

/// <summary>
/// Defines properties and methods to be used by classes with current game data.
/// </summary>
public interface IGameData
{
    /// <summary>
    /// Current game state.
    /// </summary>
    GameState GameState { get; set; }

    /// <summary>
    /// Players in the current game.
    /// </summary>
    IEnumerable<IPlayer> Players { get; set; }

    /// <summary>
    /// The player whose turn it currently is.
    /// </summary>
    IPlayer CurrentPlayer { get; set; }

    /// <summary>
    /// State of the current player's turn.
    /// </summary>
    PlayerTurnState CurrentTurnState { get; set; }

    /// <summary>
    /// Game field.
    /// </summary>
    IField Field { get; set; }
}