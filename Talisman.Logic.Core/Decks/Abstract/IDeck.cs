using System.Collections.Generic;
using Talisman.Logic.Core.Cards.Abstract;

namespace Talisman.Logic.Core.Decks.Abstract;

/// <summary>
/// Defines properties and methods to be used by deck classes.
/// </summary>
public interface IDeck
{
    /// <summary>
    /// Deck cards.
    /// </summary>
    IList<ICard> Cards { get; }
}