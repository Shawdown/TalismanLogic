namespace Talisman.Logic.Core.Encounters.Abstract;

/// <summary>
/// Defines properties and methods to be used by classes representing encounter results.
/// </summary>
public interface IEncounterResult
{
    /// <summary>
    /// Specifies whether the encounter was successful in a sense that the player can proceed with their turn (=encounter other cards).
    /// </summary>
    bool IsSuccess { get; set; }

    
}