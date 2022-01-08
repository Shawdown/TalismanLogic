using System;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Decks.Abstract;
using Talisman.Logic.Core.Encounters.Abstract;
using Talisman.Logic.Core.Game.Abstract;
using Talisman.Logic.Core.GameField.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Cards.Implementation;

/// <summary>
/// Base class for game cards.
/// </summary>
public abstract class BaseCard : ICard
{
    /// <inheritdoc />
    public int Id { get; }

    /// <inheritdoc/>
    public string Name { get; set; }

    /// <inheritdoc/>
    public string Description { get; set; }

    /// <inheritdoc/>
    public abstract CardType Type { get; }

    /// <inheritdoc/>
    public IDeck OriginalDeck { get; }

    /// <inheritdoc />
    public IDeck CurrentDeck { get; set; }

    /// <inheritdoc/>
    public IDeck DiscardDeck { get; }

    /// <inheritdoc />
    public IFieldCell FieldCell { get; set; }

    /// <inheritdoc />
    public bool Burnable { get; set; } = true;

    /// <inheritdoc />
    public bool Burnt { get; set; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="id">Card's ID.</param>
    /// <param name="deck">OriginalDeck this Card belongs to.</param>
    /// <param name="discardDeck">Discard deck this Card belongs to (null for non-discardable cards).</param>
    /// 
    /// <exception cref="ArgumentNullException"></exception>
    protected BaseCard(int id, IDeck deck, IDeck discardDeck = null)
    {
        Id = id;
        OriginalDeck = deck ?? throw new ArgumentNullException(nameof(deck));
        DiscardDeck = discardDeck;
    }
}