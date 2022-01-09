using System.Collections.Generic;
using Talisman.Logic.Core.Combat.Abstract;
using Talisman.Logic.Core.GameField.Abstract;
using Talisman.Logic.Core.Gameplay.Abstract;

namespace Talisman.Logic.Core.Combat.Implementation;

/// <summary>
/// DTO with combat data.
/// </summary>
public class CombatInfo
{
    /// <summary>
    /// Stat type used in the combat.
    /// </summary>
    public StatType CombatStatType { get; set; }

    /// <summary>
    /// Combat result.
    /// </summary>
    public CombatResult CombatResult { get; set; }

    /// <summary>
    /// Attackers.
    /// </summary>
    public IList<FighterData> Attackers { get; set; } = new List<FighterData>();

    /// <summary>
    /// Defenders.
    /// </summary>
    public IList<FighterData> Defenders { get; set; } = new List<FighterData>();

    /// <summary>
    /// Game field cell on which the combat has been initiated.
    /// </summary>
    public IFieldCell FieldCell { get; set; }

    /// <summary>
    /// Calculates the combat result and updates the related property <see cref="CombatResult"/>.
    /// </summary>
    public void CalculateCombatResult()
    {
        int attackersPower = CalculateFinalPower(Attackers);
        int defendersPower = CalculateFinalPower(Defenders);

        CombatResult = attackersPower > defendersPower ? CombatResult.AttackersWon :
                       defendersPower > attackersPower ? CombatResult.DefendersWon :
                       CombatResult.Draw;
    }

    /// <summary>
    /// Calculates the final power value of all fighters in the specified set.
    /// </summary>
    /// 
    /// <param name="fighterDatas">Fighters which sum power needs to be calculated.</param>
    /// 
    /// <returns>Total power of fighters in <paramref name="fighterDatas"/></returns>
    private int CalculateFinalPower(IEnumerable<FighterData> fighterDatas)
    {
        int powerTotal = 0;

        foreach (var fd in fighterDatas)
        {
            // Getting base combat power.
            powerTotal += fd.Fighter.GetBaseCombatPower(this);

            // Applying power modifiers.
            foreach (var modifier in fd.CombatPowerModifiers)
            {
                powerTotal += modifier;
            }

            // Adding combat dice roll results.
            foreach (int combatDiceRoll in fd.CombatDiceRollResults)
            {
                powerTotal += combatDiceRoll;
            }
        }

        return powerTotal;
    }
}