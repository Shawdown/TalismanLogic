using Talisman.Logic.Core.Decks.Abstract;

namespace Talisman.Logic.Core.Events.Abstract;

/// <summary>
/// Defines properties to be used by classes representing events targeting game card decks.
/// </summary>
public interface IDeckEvent : IEvent
{
    /// <summary>
    /// Game card deck this event targets.
    /// </summary>
    IDeck TargetDeck { get; }
}