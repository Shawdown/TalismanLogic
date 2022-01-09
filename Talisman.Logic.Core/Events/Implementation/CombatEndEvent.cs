using System;
using System.Collections.Generic;
using System.Linq;
using Talisman.Logic.Core.Combat.Implementation;
using Talisman.Logic.Core.Events.Abstract;

namespace Talisman.Logic.Core.Events.Implementation;

/// <summary>
/// Represents an end of combat event.
/// </summary>
public class CombatEndEvent : BaseEvent, ICombatEvent
{
    /// <inheritdoc />
    public override EventType EventType => EventType.CombatEnd;

    /// <inheritdoc />
    public CombatInfo CombatInfo { get; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// 
    /// <param name="combatInfo">Combat data.</param>
    public CombatEndEvent(CombatInfo combatInfo)
    {
        CombatInfo = combatInfo ?? throw new ArgumentNullException(nameof(combatInfo));
    }

    /// <inheritdoc />
    public override IEnumerable<IEvent> Execute() => Enumerable.Empty<IEvent>();
}