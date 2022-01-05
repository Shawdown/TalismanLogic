using Talisman.Logic.Core.Game.Implementation;

namespace Talisman.Game.Logic.Implementation
{
    /// <summary>
    /// Global application context.
    /// </summary>
    public static class GlobalContext
    {
        /// <summary>
        /// Current game's data.
        /// </summary>
        public static GameData Game { get; set; }
    }
}