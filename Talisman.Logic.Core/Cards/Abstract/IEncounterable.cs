using Talisman.Logic.Core.Game.Abstract;

namespace Talisman.Logic.Core.Cards.Abstract
{
    /// <summary>
    /// Defines methods to use by players when encountering various game objects, such as adventure cards, dragon scales, etc.
    /// </summary>
    public interface IEncounterable
    {
        /// <summary>
        /// Executes encounter logic.
        /// </summary>
        /// 
        /// <param name="player">Player encountering the object.</param>
        void Encounter(Player player);
    }
}