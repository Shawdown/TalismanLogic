using System.Collections;
using System.Collections.Generic;
using Talisman.Logic.Core.Decks.Abstract;
using Talisman.Logic.Core.Encounters.Abstract;
using Talisman.Logic.Core.Events.Abstract;
using Talisman.Logic.Core.Game.Abstract;
using Talisman.Logic.Core.GameField.Abstract;
using Talisman.Logic.Core.Global.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Cards.Abstract;

/// <summary>
/// Defines properties and methods of all game cards.
/// </summary>
public interface ICard : IWithId
{
    /// <summary>
    /// Card's name.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Card's description.
    /// </summary>
    string Description { get; }

    /// <summary>
    /// Card's type.
    /// </summary>
    CardType Type { get; }

    /// <summary>
    /// Original Deck this Card belongs to.
    /// </summary>
    IDeck OriginalDeck { get; }

    /// <summary>
    /// Current deck this Card belongs to.
    /// </summary>
    IDeck CurrentDeck { get; set; }

    /// <summary>
    /// Discard deck this Card belongs to.
    /// </summary>
    IDeck DiscardDeck { get; }

    /// <summary>
    /// Game field cell this card placed on.
    /// </summary>
    IFieldCell FieldCell { get; set; }

    /// <summary>
    /// Specified whether the card can be burnt or not.
    /// </summary>
    bool Burnable { get; set; }

    /// <summary>
    /// Specifies whether the card is burnt or not.
    /// </summary>
    bool Burnt { get; set; }
}