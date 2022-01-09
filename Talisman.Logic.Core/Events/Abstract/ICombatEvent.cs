using Talisman.Logic.Core.Combat.Implementation;

namespace Talisman.Logic.Core.Events.Abstract;

/// <summary>
/// Defines properties to be used by classes representing events targeting combat data.
/// </summary>
public interface ICombatEvent : IEvent
{
    /// <summary>
    /// Combat data.
    /// </summary>
    CombatInfo CombatInfo { get; }
}