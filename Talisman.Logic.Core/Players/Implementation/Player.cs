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
    /// <inheritdoc />
    public PlayerTurnState TurnState { get; set; }

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
            throw new InvalidOperationException($"This Player has no stat specified with type [{combatInfo.CombatStatType}].");
        }

        return (int)currentStatValue;
    }

    /// <inheritdoc />
    public int[] GetCombatDiceRolls(CombatInfo combatInfo) => throw new NotImplementedException();

    /// <inheritdoc />
    public StatType GetCombatStatTypeForBattle(CombatInfo combatInfo)
    {
        if (!combatInfo.Attackers.Any(fd => fd.Fighter == this))
        {
            throw new InvalidOperationException("This method should only be called for the attackers.");
        }

        // Picking the first available combat stat.
        foreach (var enemyStatType in combatInfo.Defenders.First().Fighter.CombatStatTypes)
        {
            if (CombatStatTypes.Contains(enemyStatType))
            {
                return enemyStatType;
            }
        }

        throw new InvalidOperationException("Not a single common combat stat found for this combat.");
    }

    /// <inheritdoc />
    public IEnumerable<IEvent> GetPreCombatEvents(CombatInfo combatInfo) => Enumerable.Empty<IEvent>();

    /// <inheritdoc />
    public IEnumerable<IEvent> GetPostCombatEvents(CombatInfo combatInfo) => Enumerable.Empty<IEvent>();

    /// <inheritdoc />
    public IEnumerable<IEvent> GetOpponentCombatDiceRollEvents(CombatInfo combatInfo, int[] opponentCombatDiceRolls) => Enumerable.Empty<IEvent>();

    /// <inheritdoc />
    public IEnumerable<IEvent> GetCombatDiceRollEvents(CombatInfo combatInfo, int[] combatDiceRolls) => Enumerable.Empty<IEvent>();
}