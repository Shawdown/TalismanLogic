using System.Collections;
using System.Collections.Generic;

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
    ///
    /// <returns>Optional collection of events to be executed after this event.</returns>
    IEnumerable<IEvent> Execute();
}