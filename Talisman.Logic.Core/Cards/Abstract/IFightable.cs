using System.Collections.Generic;
using Talisman.Logic.Core.Combat.Implementation;
using Talisman.Logic.Core.Events.Abstract;
using Talisman.Logic.Core.Gameplay.Abstract;

namespace Talisman.Logic.Core.Cards.Abstract;

/// <summary>
/// Defines properties and methods for classes representing entities that can be initiated combat with.
/// </summary>
public interface IFightable
{
    /// <summary>
    /// Stat types this card can use to initiate combat.
    /// </summary>
    ICollection<StatType> CombatStatTypes { get; }

    /// <summary>
    /// Combat strength modifier.
    /// </summary>
    int CombatStrengthModifier { get; set; }

    /// <summary>
    /// Gets fighter's base combat power.
    /// </summary>
    /// 
    /// <param name="combatInfo">Combat data.</param>
    /// 
    /// <returns>Card's base combat power.</returns>
    int GetBaseCombatPower(CombatInfo combatInfo);

    /// <summary>
    /// Gets fighter's combat dice roll results.
    /// </summary>
    /// 
    /// <param name="combatInfo">Combat data.</param>
    /// 
    /// <returns>An array of the fighter's combat dice roll results.</returns>
    int[] GetCombatDiceRolls(CombatInfo combatInfo);

    /// <summary>
    /// Gets combat stat type to be used in combat.
    /// </summary>
    ///
    /// <remarks>This method should be used to obtain the desired combat stat type from the attacker.</remarks>
    /// 
    /// <param name="combatInfo">Combat data.</param>
    /// 
    /// <returns>Stat type to be used in combat.</returns>
    StatType GetCombatStatTypeForBattle(CombatInfo combatInfo);

    /// <summary>
    /// Gets pre-combat events need to be executed before the start of combat.
    /// </summary>
    /// 
    /// <param name="combatInfo">Combat data.</param>
    /// 
    /// <returns>Collection of events to be executed in the provided order before the start of combat.</returns>
    IEnumerable<IEvent> GetPreCombatEvents(CombatInfo combatInfo);

    /// <summary>
    /// Gets post-combat events need to be executed after the end of combat.
    /// </summary>
    /// 
    /// <param name="combatInfo">Combat data.</param>
    /// 
    /// <returns>Collection of events to be executed in the provided order before the start of combat.</returns>
    IEnumerable<IEvent> GetPostCombatEvents(CombatInfo combatInfo);

    /// <summary>
    /// Gets events need to be executed after the opponent has rolled the combat dice.
    /// </summary>
    /// 
    /// <param name="combatInfo">Combat data.</param>
    /// <param name="opponentCombatDiceRolls">Opponent combat dice roll results.</param>
    /// 
    /// <returns>Collection of events to be executed in the provided order after the opponent has rolled the combat dice.</returns>
    IEnumerable<IEvent> GetOpponentCombatDiceRollEvents(CombatInfo combatInfo, int[] opponentCombatDiceRolls);

    /// <summary>
    /// Gets events need to be executed after this entity has rolled the combat dice.
    /// </summary>
    /// 
    /// <param name="combatInfo">Combat data.</param>
    /// <param name="combatDiceRolls">Combat dice roll results.</param>
    /// 
    /// <returns>Collection of events to be executed in the provided order after this entity has rolled the combat dice.</returns>
    IEnumerable<IEvent> GetCombatDiceRollEvents(CombatInfo combatInfo, int[] combatDiceRolls);
}