using System.Collections.Generic;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Decks.Abstract;

namespace Talisman.Logic.Core.Decks.Implementation;

/// <summary>
/// Represents a Card deck.
/// </summary>
public class Deck : IDeck
{
    /// <inheritdoc/>
    public IList<ICard> Cards { get; set; } = new List<ICard>();
}