using System.Collections.Generic;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.GameField.Abstract;
using Talisman.Logic.Core.Players.Implementation;

namespace Talisman.Logic.Core.Players.Abstract;

/// <summary>
/// Defines properties and methods to be used by classes representing a player.
/// </summary>
public interface IPlayer : IFightable
{
    /// <summary>
    /// Player turn state.
    /// </summary>
    PlayerTurnState TurnState { get; set; }

    /// <summary>
    /// Player stats.
    /// </summary>
    IEnumerable<PlayerStatData> PlayerStats { get; }

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
    /// Player's inventory.
    /// </summary>
    PlayerInventory Inventory { get; }

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

    /// <summary>
    /// Gets a set of dice roll results from the player.
    /// </summary>
    /// 
    /// <param name="numberOfDice">Number of dice to roll.</param>
    /// <param name="diceSidesCount">Number of sides on each dice.</param>
    /// 
    /// <returns>Array of dice roll results for each dice rolled.</returns>
    int[] GetDiceRolls(int numberOfDice = 1, int diceSidesCount = 6);


}