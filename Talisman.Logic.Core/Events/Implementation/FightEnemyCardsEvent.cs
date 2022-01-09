using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Combat.Abstract;
using Talisman.Logic.Core.Combat.Implementation;
using Talisman.Logic.Core.Events.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Events.Implementation;

/// <summary>
/// Represents an event that makes a player fight a set of enemies.
/// </summary>
public class FightEnemyCardsEvent : BaseEvent, IFightEnemyCardsEvent
{
    /// <inheritdoc />
    public override EventType EventType => EventType.FightEnemyCards;

    /// <inheritdoc />
    public IPlayer TargetPlayer { get; }

    /// <inheritdoc />
    public IList<IFightable> Fightables { get; }

    /// <inheritdoc />
    public bool PlayerDefends { get; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// 
    /// <param name="targetPlayer">Player this event target.</param>
    /// <param name="fightables">A collection of enemies this event targets.</param>
    /// <param name="playerDefends">Specifies whether the player should play the role of the defendant in this combat.</param>
    /// 
    /// <exception cref="ArgumentNullException"></exception>
    public FightEnemyCardsEvent(IPlayer targetPlayer, IList<IFightable> fightables, bool playerDefends = false)
    {
        TargetPlayer = targetPlayer ?? throw new ArgumentNullException(nameof(targetPlayer));
        Fightables = fightables ?? throw new ArgumentNullException(nameof(fightables));
        PlayerDefends = playerDefends;
    }

    /// <inheritdoc />
    public override IEnumerable<IEvent> Execute()
    {
        // 1. Creating CombatInfo describing this combat.
        IList<FighterData> playerFighterDatas = new List<FighterData> { new(TargetPlayer) };
        IList<FighterData> enemiesFigherDatas = new List<FighterData>(Fightables.Count);
        IFightable firstEnemy = Fightables.First();

        foreach (var fightable in Fightables)
        {
            enemiesFigherDatas.Add(new FighterData(fightable));
        }

        CombatInfo combatInfo = new CombatInfo
        {
            FieldCell = TargetPlayer.FieldCell,
            Attackers = PlayerDefends ? enemiesFigherDatas : playerFighterDatas,
            Defenders = PlayerDefends ? playerFighterDatas : enemiesFigherDatas,
            CombatResult = CombatResult.Null
        };
        combatInfo.CombatStatType = combatInfo.Attackers.First().Fighter.GetCombatStatTypeForBattle(combatInfo);

        // 3. Executing pre-combat events.
        EventUtils.ExecuteAllPreCombatEvents(combatInfo, playerFighterDatas.Select(item => item.Fighter));
        EventUtils.ExecuteAllPreCombatEvents(combatInfo, enemiesFigherDatas.Select(item => item.Fighter));

        // 4. Rolling player's combat dice.
        if (playerFighterDatas.First().CanRollCombatDice)
        {
            var playerRolls = TargetPlayer.GetCombatDiceRolls(combatInfo);
            playerFighterDatas.First().CombatDiceRollResults = playerRolls;

            // 5. Executing player's combat dice roll events.
            EventUtils.ExecuteAllCombatDiceRollEvents(combatInfo, playerFighterDatas.Select(item => item.Fighter), playerRolls);

            // 6. Executing enemies' opponent combat dice roll events.
            EventUtils.ExecuteAllOpponentCombatDiceRollEvents(combatInfo, enemiesFigherDatas.Select(item => item.Fighter), playerRolls);
        }

        // 7. Rolling enemies' combat dice.
        if (enemiesFigherDatas.First().CanRollCombatDice)
        {
            var enemyRolls = firstEnemy.GetCombatDiceRolls(combatInfo);
            enemiesFigherDatas.First().CombatDiceRollResults = enemyRolls;

            // 8. Executing enemies's combat dice roll events.
            EventUtils.ExecuteAllCombatDiceRollEvents(combatInfo, enemiesFigherDatas.Select(item => item.Fighter), enemyRolls);

            // 9. Executing player's opponent combat dice roll events.
            EventUtils.ExecuteAllOpponentCombatDiceRollEvents(combatInfo, playerFighterDatas.Select(item => item.Fighter), enemyRolls);
        }

        // 10. Calculating the combat result.
        combatInfo.CalculateCombatResult();

        // 11. Returning post-combat events.
        var postCombatEvents = new List<IEvent> { new CombatEndEvent(combatInfo) };

        foreach (var pfd in playerFighterDatas)
        {
            postCombatEvents.AddRange(pfd.Fighter.GetPostCombatEvents(combatInfo));
        }
        foreach (var efd in enemiesFigherDatas)
        {
            postCombatEvents.AddRange(efd.Fighter.GetPostCombatEvents(combatInfo));
        }

        return postCombatEvents;
    }
}