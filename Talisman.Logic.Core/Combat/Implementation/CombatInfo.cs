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

}