namespace Talisman.Logic.Core.Events.Abstract;

/// <summary>
/// Defines properties to be used by classes representing game events.
/// </summary>
public interface IEvent
{
    /// <summary>
    /// Game event type.
    /// </summary>
    EventType EventType { get; }

    /// <summary>
    /// Event execution logic.
    /// </summary>
    void Execute();
}