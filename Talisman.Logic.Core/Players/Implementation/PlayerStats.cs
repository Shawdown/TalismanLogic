using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Players.Implementation;

/// <summary>
/// Player stats.
/// </summary>
public class PlayerStats : IPlayerStats
{
    /// <inheritdoc />
    public Alignment Alignment { get; set; }

    /// <inheritdoc />
    public uint Health { get; set; }

    /// <inheritdoc />
    public uint MinStrength { get; set; }

    /// <inheritdoc />
    public uint Strength { get; set; }

    /// <inheritdoc />
    public uint MinCraft { get; set; }

    /// <inheritdoc />
    public uint Craft { get; set; }

    /// <inheritdoc />
    public uint Fate { get; set; }

    /// <inheritdoc />
    public uint DarkFate { get; set; }

    /// <inheritdoc />
    public uint LightFate { get; set; }

    /// <inheritdoc />
    public uint Gold { get; set; }

    /// <inheritdoc />
    public uint MaxItems { get; set; }

    /// <inheritdoc />
    public uint MaxMagicalItems { get; set; }

    /// <inheritdoc />
    public uint MaxFollowers { get; set; }

    /// <inheritdoc />
    public uint MaxSpells { get; set; }
}