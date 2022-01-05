namespace Talisman.Logic.Core.Players.Abstract;

/// <summary>
/// Defines properties representing players' stats.
/// </summary>
public interface IPlayerStats
{
    /// <summary>
    /// Player's alignment.
    /// </summary>
    Alignment Alignment { get; set; }

    /// <summary>
    /// Player's health points.
    /// </summary>
    uint Health { get; set; }

    /// <summary>
    /// Player's minimal strength.
    /// </summary>
    uint MinStrength { get; set; }

    /// <summary>
    /// Player's strength.
    /// </summary>
    uint Strength { get; set; }

    /// <summary>
    /// Player's minimal craft.
    /// </summary>
    uint MinCraft { get; set; }

    /// <summary>
    /// Player's craft.
    /// </summary>
    uint Craft { get; set; }

    /// <summary>
    /// Player's generic fate (when there is no dark/light fate specified in the rules).
    /// </summary>
    uint Fate { get; set; }

    /// <summary>
    /// Player's dark fate.
    /// </summary>
    uint DarkFate { get; set; }

    /// <summary>
    /// Player's light fate.
    /// </summary>
    uint LightFate { get; set; }

    /// <summary>
    /// Player's gold.
    /// </summary>
    uint Gold { get; set; }

    /// <summary>
    /// Maximum number of items the player is allowed to carry.
    /// </summary>
    uint MaxItems { get; set; }

    /// <summary>
    /// Maximum number of magical items the player is allowed to carry.
    /// </summary>
    uint MaxMagicalItems { get; set; }

    /// <summary>
    /// Maximum number of followers the player is allowed to have.
    /// </summary>
    uint MaxFollowers { get; set; }

    /// <summary>
    /// Maximum number of spells the player is allowed to have.
    /// </summary>
    uint MaxSpells { get; set; }
}