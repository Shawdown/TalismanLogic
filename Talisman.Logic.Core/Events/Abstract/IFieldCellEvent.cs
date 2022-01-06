using Talisman.Logic.Core.GameField.Abstract;

namespace Talisman.Logic.Core.Events.Abstract;

/// <summary>
/// Defines properties to be used by classes representing events targeting game field cells.
/// </summary>
public interface IFieldCellEvent : IEvent
{
    /// <summary>
    /// Game field cell this event targets.
    /// </summary>
    IFieldCell TargetGameFieldCell { get; }
}