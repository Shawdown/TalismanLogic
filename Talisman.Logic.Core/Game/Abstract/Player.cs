using System.Collections.Generic;
using Talisman.Logic.Core.Cards.Implementation;

namespace Talisman.Logic.Core.Game.Abstract
{
    /// <summary>
    /// Represents a player.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Player stats.
        /// </summary>
        private PlayerStats Stats { get; } = new PlayerStats();

        /// <summary>
        /// Player name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Cards owned by the player.
        /// </summary>
        public ICollection<BaseCard> OwnedCards { get; set; }
    }
}