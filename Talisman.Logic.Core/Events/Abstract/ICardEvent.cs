using Talisman.Logic.Core.Cards.Abstract;

namespace Talisman.Logic.Core.Events.Abstract;

/// <summary>
/// Defines properties to be used by classes representing events targeting game cards.
/// </summary>
public interface ICardEvent : IEvent
{
    /// <summary>
    /// Game card this event targets.
    /// </summary>
    ICard TargetCard { get; }
}