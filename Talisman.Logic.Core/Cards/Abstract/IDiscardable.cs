using Talisman.Logic.Core.Game.Abstract;

namespace Talisman.Logic.Core.Cards.Abstract
{
    /// <summary>
    /// Defines methods to use with cards that can be discarded.
    /// </summary>
    public interface IDiscardable
    {
        /// <summary>
        /// Discards this card.
        /// </summary>
        /// 
        /// <param name="gameData">Current game's data.</param>
        /// <param name="player">Player that discarded this card (for the cards implementing <see cref="IOwnable"/>).</param>
        void Discard(GameData gameData, Player player = null);
    }
}