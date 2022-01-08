using System;
using System.Collections.Generic;
using System.Linq;
using Talisman.Logic.Core.Events.Abstract;
using Talisman.Logic.Core.Players.Abstract;
using Talisman.Logic.Core.Players.Implementation;

namespace Talisman.Logic.Core.Events.Implementation;

/// <summary>
/// Represents an event modifying the player's stat data.
/// </summary>
public class PlayerStatEvent : BaseEvent, IPlayerStatEvent
{
    /// <inheritdoc />
    public override EventType EventType { get; }

    /// <inheritdoc />
    public IPlayer TargetPlayer { get; }

    /// <inheritdoc />
    public PlayerStatValueType StatValueType { get; }

    /// <inheritdoc />
    public PlayerStatData TargetStatData { get; }

    /// <inheritdoc />
    public int Value { get; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// 
    /// <param name="eventType">Event type.</param>
    /// <param name="statValueType">Target player's stat data value type to modify.</param>
    /// <param name="targetPlayer">Player this event targets.</param>
    /// <param name="targetStatData">Target player's stat data to modify.</param>
    /// <param name="value">Value to use for stat modification.</param>
    public PlayerStatEvent(EventType eventType, PlayerStatValueType statValueType, Player targetPlayer, PlayerStatData targetStatData, int value)
    {
        ValidateEventTypeValue(eventType, value);

        EventType = eventType;
        TargetPlayer = targetPlayer ?? throw new ArgumentNullException(nameof(targetPlayer));
        TargetStatData = targetStatData ?? throw new ArgumentNullException(nameof(targetStatData));
        Value = value;
        StatValueType = statValueType;
    }

    /// <summary>
    /// Modifies the relevant player stat value based on the event's data.
    /// </summary>
    public override IEnumerable<IEvent> Execute()
    {
        switch (EventType)
        {
            case EventType.RestoreStatValue:
                TargetStatData.RestoreCurrentValue((uint)Value);
                break;
            case EventType.AddStatValue:
                TargetStatData.UpdateValue(StatValueType, Value);
                break;
            case EventType.RemoveStatValue:
                TargetStatData.UpdateValue(StatValueType, -Value);
                break;
            case EventType.SetStatValue:
                TargetStatData.SetValue(StatValueType, (uint)Value);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(EventType), EventType, null);
        }

        return Enumerable.Empty<IEvent>();
    }

    /// <summary>
    /// Validates whether the provided <paramref name="value"/> is valid for the specified <see cref="Abstract.EventType"/>.
    /// </summary>
    /// 
    /// <param name="eventType">Event type.</param>
    /// <param name="value">Value to validate.</param>
    /// 
    /// <exception cref="ArgumentException"></exception>
    private void ValidateEventTypeValue(EventType eventType, int value)
    {
        if (eventType is EventType.RestoreStatValue or EventType.SetStatValue && value < 0)
        {
            throw new ArgumentException($"{nameof(value)} cannot be negative for eventType={eventType}", nameof(value));
        }
    }
}