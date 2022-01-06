using Talisman.Logic.Core.Players.Abstract;
using Talisman.Logic.Core.Players.Implementation;

namespace Talisman.Logic.Core.Events.Abstract;

/// <summary>
/// Defines properties to be used by classes representing events targeting player stats.
/// </summary>
public interface IPlayerStatEvent : IPlayerEvent
{
    /// <summary>
    /// Target player's stat data value type to modify.
    /// </summary>
    public PlayerStatValueType StatValueType { get; }

    /// <summary>
    /// Target player's stat data to modify.
    /// </summary>
    public PlayerStatData TargetStatData { get; }

    /// <summary>
    /// Value to use for stat modification.
    /// </summary>
    public int Value { get; }
}