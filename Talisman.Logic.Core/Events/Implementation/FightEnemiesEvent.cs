using System;
using System.Collections.Generic;
using System.Linq;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Combat.Implementation;
using Talisman.Logic.Core.Events.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Events.Implementation;

/// <summary>
/// Represents an event that makes a player fight a set of enemies.
/// </summary>
public class FightEnemiesEvent : IFightEvent
{
    /// <inheritdoc />
    public EventType EventType => EventType.FightEnemies;

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
    public FightEnemiesEvent(IPlayer targetPlayer, IList<IFightable> fightables, bool playerDefends = false)
    {
        TargetPlayer = targetPlayer ?? throw new ArgumentNullException(nameof(targetPlayer));
        Fightables = fightables ?? throw new ArgumentNullException(nameof(fightables));
        PlayerDefends = playerDefends;
    }

    /// <inheritdoc />
    public IEnumerable<IEvent> Execute()
    {
        FighterData playerFighterData = new FighterData(TargetPlayer);

        CombatInfo combatInfo = new CombatInfo()
        {
            FieldCell = TargetPlayer.FieldCell,
            Attackers = new List<FighterData>()
        }

        return Enumerable.Empty<IEvent>();
    }
}