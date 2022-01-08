using Talisman.Logic.Core.Cards.Abstract;

namespace Talisman.Logic.Core.Events.Abstract;

/// <summary>
/// Defines properties to be used by classes representing events targeting game cards.
/// </summary>
///
/// <typeparam name="T">Game card type this event target.</typeparam>
public interface ICardEvent<T> : IEvent
{
    /// <summary>
    /// Game card this event targets.
    /// </summary>
    T TargetCard { get; }
}