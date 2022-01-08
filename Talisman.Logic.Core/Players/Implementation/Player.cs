using System;
using System.Collections.Generic;
using System.Linq;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Combat.Implementation;
using Talisman.Logic.Core.Events.Abstract;
using Talisman.Logic.Core.GameField.Abstract;
using Talisman.Logic.Core.Gameplay.Abstract;
using Talisman.Logic.Core.Gameplay.Implementation;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Players.Implementation;

/// <summary>
/// Represents a player.
/// </summary>
public class Player : IPlayer
{
    /// <inheritdoc/>
    public IEnumerable<PlayerStatData> PlayerStats { get; set; }

    /// <inheritdoc/>
    public string Name { get; set; }

    /// <inheritdoc/>
    public ICharacterCard Character { get; set; }

    /// <inheritdoc />
    public AdditionalPlayerState AdditionalPlayerState { get; } = new();

    /// <inheritdoc />
    public PlayerInventory Inventory { get; } = new();

    /// <inheritdoc />
    public IFieldCell FieldCell { get; set; }

    /// <inheritdoc />
    public virtual bool AskYesOrNo(string question = null) => throw new NotImplementedException();

    /// <inheritdoc />
    public virtual int[] GetDiceRolls(int numberOfDice = 1, int diceSidesCount = 6) => DiceUtils.RollMultipleDice(numberOfDice, diceSidesCount);

    /// <inheritdoc />
    public ICollection<StatType> CombatStatTypes { get; } = new List<StatType> { StatType.Strength };

    /// <inheritdoc />
    public int CombatStrengthModifier { get; set; }

    /// <inheritdoc />
    public int GetBaseCombatPower(CombatInfo combatInfo)
    {
        if (combatInfo == null) throw new ArgumentNullException(nameof(combatInfo));

        var currentStatValue = PlayerStats.FirstOrDefault(stat => stat.StatType == combatInfo.CombatStatType)?.CurrentValue;

        if (currentStatValue is null)
        {
            throw new InvalidOperationException($"This Player has no stat specified with type {combatInfo.CombatStatType}.");
        }

        return (int)currentStatValue;
    }

    /// <inheritdoc />
    public bool CanRollCombatDice(CombatInfo combatInfo) => throw new NotImplementedException();

    /// <inheritdoc />
    public int[] GetCombatDiceRolls(CombatInfo combatInfo) => throw new NotImplementedException();

    /// <inheritdoc />
    public IEnumerable<IEvent> GetPreCombatEvents(CombatInfo combatInfo) => throw new NotImplementedException();

    /// <inheritdoc />
    public IEnumerable<IEvent> GetPostCombatEvents(CombatInfo combatInfo) => throw new NotImplementedException();
}