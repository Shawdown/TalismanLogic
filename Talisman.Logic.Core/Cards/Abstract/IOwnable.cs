using Talisman.Logic.Core.Game.Abstract;

namespace Talisman.Logic.Core.Cards.Abstract
{
    /// <summary>
    /// Defines methods to be used with cards that players can own.
    /// </summary>
    public interface IOwnable
    {
        /// <summary>
        /// Checks whether the player can own this card.
        /// </summary>
        /// 
        /// <param name="gameData">Current game's data.</param>
        /// <param name="player">Player to be checked.</param>
        /// 
        /// <returns>true if the player <paramref name="player"/> can own this card; false otherwise.</returns>
        bool CanBeOwnedByPlayer(GameData gameData, Player player);

        /// <summary>
        /// Sets the player as the owner of this card.
        /// </summary>
        /// 
        /// <param name="gameData">Current game's data.</param>
        /// <param name="player">Player to be set as an owner.</param>
        void SetOwner(GameData gameData, Player player);
    }
}