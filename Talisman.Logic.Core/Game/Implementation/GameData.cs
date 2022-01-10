using System.Collections.Generic;
using Talisman.Logic.Core.Game.Abstract;
using Talisman.Logic.Core.GameField.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Game.Implementation;

/// <summary>
/// Contains information about the current game.
/// </summary>
public class GameData
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
    /// Game field.
    /// </summary>
    IField Field { get; set; }
}