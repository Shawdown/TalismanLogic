using System.Collections.Generic;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.GameField.Abstract;
using Talisman.Logic.Core.Players.Implementation;

namespace Talisman.Logic.Core.Players.Abstract;

/// <summary>
/// Defines properties and methods to be used by classes representing a player.
/// </summary>
public interface IPlayer
{
    /// <summary>
    /// Player stats.
    /// </summary>
    PlayerStats Stats { get; }

    /// <summary>
    /// Player name.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Player's selected character.
    /// </summary>
    ICharacterCard Character { get; set; }

    /// <summary>
    /// Additional player state data.
    /// </summary>
    AdditionalPlayerState AdditionalPlayerState { get; }

    /// <summary>
    /// Cards owned by the player.
    /// </summary>
    IList<ICard> OwnedCards { get; }

    /// <summary>
    /// Game field cell the player stays on.
    /// </summary>
    IFieldCell FieldCell { get; set; }

    /// <summary>
    /// Get a yes/no answer for the specified question.
    /// </summary>
    ///
    /// <param name="question">Question that the player needs to give a yes/no answer to.</param>
    /// 
    /// <returns>true if the player answered yes, false otherwise.</returns>
    bool AskYesOrNo(string question = null);
}