using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Events.Abstract;

/// <summary>
/// Defines properties to be used by classes representing events targeting players.
/// </summary>
public interface IPlayerEvent : IEvent
{
    /// <summary>
    /// Player this event targets.
    /// </summary>
    IPlayer TargetPlayer { get; }
}