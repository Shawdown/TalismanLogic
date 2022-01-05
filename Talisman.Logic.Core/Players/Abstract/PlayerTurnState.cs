namespace Talisman.Logic.Core.Players.Abstract;

/// <summary>
/// Player turn states.
/// </summary>
public enum PlayerTurnState
{
    Null,
    CharacterSelect,
    DragonScaleDraw,
    MovementRoll,
    Movement,
    SpaceEncounter,
    DragonScaleEncounter,
    End
}