using Talisman.Logic.Core.Encounters.Abstract;

namespace Talisman.Logic.Core.Encounters.Implementation;

/// <summary>
/// Represent an encounter result.
/// </summary>
public class EncounterResult : IEncounterResult
{
    /// <inheritdoc />
    public bool IsSuccess { get; set; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// 
    /// <param name="isSuccess">Specifies whether the encounter was successful in a sense that the player can proceed with their turn (including encountering other cards).</param>
    public EncounterResult(bool isSuccess)
    {
        IsSuccess = isSuccess;
    }
}