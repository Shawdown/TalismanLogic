namespace Talisman.Logic.Core.Cards.Abstract
{
    /// <summary>
    /// Game card types.
    /// </summary>
    public enum CardType
    {
        NotSet = 0,

        // Can be found in adventure decks; can be obtained by the player.
        Object,
        MagicObject,
        Follower,

        // Can be found in adventure decks; cannot be obtained by the player.
        Event,
        Place,
        Stranger,
        Denizen,

        // Cannot be found in adventure decks; can be obtained by the player.
        Path,
        Spell,
        Material,
        Destiny,
        BeastReward,
        QuestReward,

        // Cannot be found in adventure decks; attach to the game field cells.
        Terrain,
        AncientBeast,
        Npc,
        Character,

        // Cannot be found in adventure decks nor appear on the game field; change the game state.
        Prophecy,
        DragonLord,
        Ending
    }
}