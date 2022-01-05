namespace Talisman.Logic.Core.Encounters.Abstract;

/// <summary>
/// Game effect types.
/// </summary>
public enum EventType
{
    /// <summary>
    /// Teleport a player to another cell.
    /// </summary>
    Teleport,

    /// <summary>
    /// Add a specific number of player's stats.
    /// </summary>
    AddStats,

    /// <summary>
    /// Restore a specific number of player's stats.
    /// </summary>
    RestoreStats,

    /// <summary>
    /// Remove a specific number of player's stats.
    /// </summary>
    RemoveStats,

    /// <summary>
    /// Give a card to a player.
    /// </summary>
    AddCard,

    /// <summary>
    /// Make a player drop a card.
    /// </summary>
    DropCard,

    /// <summary>
    /// Make a player discard a card.
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
    /// Make a player lose the game.
    /// </summary>
    LoseGame,

    /// <summary>
    /// Make a player fight a set of enemies.
    /// </summary>
    FightEnemies
}