using System.Collections.Generic;
using Talisman.Logic.Core.Cards.Abstract;

namespace Talisman.Logic.Core.Events.Abstract;

/// <summary>
/// Defines properties to be used by classes representing events targeting a player and a set of <see cref="IFightable"/> instances that the player must fight.
/// </summary>
public interface IFightEnemyCardsEvent : IPlayerEvent
{
    /// <summary>
    /// A collection of enemies for the player to fight.
    /// </summary>
    IList<IFightable> Fightables { get; }

    /// <summary>
    /// Specifies whether the player should play the role of the defendant in this combat.
    /// </summary>
    bool PlayerDefends { get; }
}