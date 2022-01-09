using System.Collections.Generic;
using Talisman.Logic.Core.Game.Abstract;
using Talisman.Logic.Core.GameField.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Game.Implementation;

/// <summary>
/// Contains information about the current game.
/// </summary>
public class GameData : IGameData
{
    /// <inheritdoc />
    public GameState GameState { get; set; } = GameState.NotStarted;

    /// <inheritdoc />
    public IEnumerable<IPlayer> Players { get; set; }

    /// <inheritdoc />
    public IPlayer CurrentPlayer { get; set; }

    /// <inheritdoc />
    public IField Field { get; set; }
}