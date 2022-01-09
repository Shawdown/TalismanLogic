using System;
using System.Collections.Generic;
using System.Dynamic;
using Talisman.Logic.Core.Cards.Abstract;

namespace Talisman.Logic.Core.Combat.Implementation;

/// <summary>
/// DTO with a single combat participant data.
/// </summary>
public class FighterData
{
    /// <summary>
    /// Combat participant.
    /// </summary>
    public IFightable Fighter { get; }

    /// <summary>
    /// Specifies whether this object can roll combat dice or not.
    /// </summary>
    public bool CanRollCombatDice { get; set; }

    /// <summary>
    /// Combat roll results.
    /// </summary>
    public int[] CombatDiceRollResults { get; set; }

    /// <summary>
    /// Combat power modifiers affecting <see cref="Fighter"/>.
    /// </summary>
    public ICollection<int> CombatPowerModifiers { get; } = new List<int>();

    /// <summary>
    /// Constructor.
    /// </summary>
    /// 
    /// <param name="fighter">Combat participant.</param>
    public FighterData(IFightable fighter)
    {
        Fighter = fighter ?? throw new ArgumentNullException(nameof(fighter));
    }
}