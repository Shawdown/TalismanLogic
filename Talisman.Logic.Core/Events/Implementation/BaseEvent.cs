using System.Collections.Generic;
using Talisman.Logic.Core.Events.Abstract;

namespace Talisman.Logic.Core.Events.Implementation;

/// <summary>
/// Base class for all game events.
/// </summary>
public abstract class BaseEvent : IEvent
{
    /// <inheritdoc />
    public abstract EventType EventType { get; }

    /// <inheritdoc />
    public abstract IEnumerable<IEvent> Execute();
}