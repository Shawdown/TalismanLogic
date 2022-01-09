namespace Talisman.Logic.Core.Events.Abstract;

/// <summary>
/// Game event types.
/// </summary>
public enum EventType
{
    /// <summary>
    /// Teleport a player to another cell.
    /// </summary>
    Teleport,

    /// <summary>
    /// Add a specific number of player's stats value.
    /// </summary>
    AddStatValue,

    /// <summary>
    /// Restore a specific number of player's stats value.
    /// </summary>
    RestoreStatValue,

    /// <summary>
    /// Remove a specific number of player's stat value.
    /// </summary>
    RemoveStatValue,

    /// <summary>
    /// Updates player's stat value.
    /// </summary>
    SetStatValue,

    /// <summary>
    /// Give a card to a player.
    /// </summary>
    AddCard,

    /// <summary>
    /// Make a player drop a card.
    /// </summary>
    DropCard,

    /// <summary>
    /// Discard a card either from the game cell field or from a player.
    /// </summary>
    DiscardCard,

    /// <summary>
    /// Change the player's character.
    /// </summary>
    Transform,

    /// <summary>
    /// Make a player win the game.
    /// </summary>
    WinGame,

    /// <summary>
    /// Kill a player.
    /// </summary>
    KillPlayer,

    /// <summary>
    /// Make a player fight a set of enemies.
    /// </summary>
    FightEnemyCards,

    /// <summary>
    /// Make a player fight another player.
    /// </summary>
    FightPlayer,

    /// <summary>
    /// End the combat.
    /// </summary>
    CombatEnd,

    /// <summary>
    /// Burn a card.
    /// </summary>
    BurnCard,

    /// <summary>
    /// Place a card on a game field cell.
    /// </summary>
    PlaceCard
}