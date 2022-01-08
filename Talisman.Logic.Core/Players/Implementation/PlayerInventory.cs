using System.Collections.Generic;
using Talisman.Logic.Core.Cards.Abstract;

namespace Talisman.Logic.Core.Players.Implementation;

/// <summary>
/// Represent a player's inventory.
/// </summary>
public class PlayerInventory
{
    /// <summary>
    /// Player's trophies.
    /// </summary>
    public IList<IEnemyCard> Trophies { get; } = new List<IEnemyCard>();

    /// <summary>
    /// Cards the player has picked up.
    /// </summary>
    public IList<IPickableCard> PickableCards { get; } = new List<IPickableCard>();

    // TODO: add destiny cards, quest cards, etc.
}