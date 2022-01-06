using Talisman.Logic.Core.Decks.Abstract;
using Talisman.Logic.Core.Encounters.Abstract;
using Talisman.Logic.Core.Game.Abstract;
using Talisman.Logic.Core.GameField.Abstract;
using Talisman.Logic.Core.Global.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Cards.Abstract;

/// <summary>
/// Defines properties and methods of all game cards.
/// </summary>
public interface ICard : IWithId, IEncounterable
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
    /// Current owner of this Card.
    /// </summary>
    IPlayer Owner { get; set; }

    /// <summary>
    /// Game field cell this card placed on.
    /// </summary>
    IFieldCell FieldCell { get; set; }

    /// <summary>
    /// Specifies whether the card is burnt or not.
    /// </summary>
    bool Burnt { get; set; }

    /// <summary>
    /// Checks whether the player can own this Card.
    /// </summary>
    ///
    /// <remarks>This method should always return false for non-ownable cards.</remarks>
    /// 
    /// <param name="gameData">Current game's data.</param>
    /// <param name="player">Player to be checked.</param>
    /// 
    /// <returns>true if the player <paramref name="player"/> can own this Card; false otherwise.</returns>
    bool CanBeOwnedByPlayer(IGameData gameData, IPlayer player);

    /// <summary>
    /// Checks whether the player can discard this Card.
    /// </summary>
    ///
    /// <remarks>This method should always return false for non-ownable cards.</remarks>
    /// 
    /// <param name="gameData">Current game's data.</param>
    /// <param name="player">Player to be checked.</param>
    /// 
    /// <returns>true if the player <paramref name="player"/> can discard this Card; false otherwise.</returns>
    bool CanBeDiscardedByPlayer(IGameData gameData, IPlayer player);
}