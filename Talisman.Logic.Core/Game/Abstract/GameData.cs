using System.Collections.Generic;

namespace Talisman.Logic.Core.Game.Abstract
{
    /// <summary>
    /// Contains information about the current game.
    /// </summary>
    public class GameData
    {
        /// <summary>
        /// Current game state.
        /// </summary>
        public GameState State { get; set; }

        /// <summary>
        /// Players in the current game.
        /// </summary>
        public IEnumerable<Player> Players { get; set; }
    }
}