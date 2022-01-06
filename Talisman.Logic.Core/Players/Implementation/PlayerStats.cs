using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Players.Implementation;

/// <summary>
/// DTO with properties for the player's stats.
/// </summary>
public class PlayerStats
{
    /// <summary>
    /// Player's alignment.
    /// </summary>
    public Alignment Alignment { get; set; }

    /// <summary>
    /// Player's health.
    /// </summary>
    public PlayerStatData Health { get; set; }

    /// <summary>
    /// Player's strength.
    /// </summary>
    public PlayerStatData Strength { get; set; }

    /// <summary>
    /// Player's craft.
    /// </summary>
    public PlayerStatData Craft { get; set; }

    /// <summary>
    /// Player's generic fate (when there is no dark/light fate specified in the rules).
    /// </summary>
    public PlayerStatData Fate { get; set; }

    /// <summary>
    /// Player's dark fate.
    /// </summary>
    public PlayerStatData DarkFate { get; set; }

    /// <summary>
    /// Player's light fate.
    /// </summary>
    public PlayerStatData LightFate { get; set; }

    /// <summary>
    /// Player's gold.
    /// </summary>
    public PlayerStatData Gold { get; set; }

    /// <summary>
    /// Player's objects.
    /// </summary>
    public PlayerStatData Objects { get; set; }

    /// <summary>
    /// Player's followers.
    /// </summary>
    public PlayerStatData Followers { get; set; }

    /// <summary>
    /// Player's spells.
    /// </summary>
    public PlayerStatData Spells { get; set; }
}