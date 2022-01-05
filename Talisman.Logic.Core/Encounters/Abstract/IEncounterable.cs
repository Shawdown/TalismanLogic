using Talisman.Logic.Core.Game.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Encounters.Abstract;

/// <summary>
/// Defines methods to use by players when encountering various game objects, such as adventure cards, dragon scales, etc.
/// </summary>
public interface IEncounterable
{
    /// <summary>
    /// Executes encounter logic.
    /// </summary>
    /// 
    /// <param name="gameData">Current game's data.</param>
    /// <param name="player">Player encountering the object.</param>
    ///
    /// <returns>Encounter result.</returns>
    IEncounterResult Encounter(IGameData gameData, IPlayer player);
}