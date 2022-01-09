namespace Talisman.Logic.Core.Players.Abstract;

/// <summary>
/// Player turn states.
/// </summary>
public enum PlayerTurnState
{
    Null,
    WaitingForTurn,
    CharacterSelect,
    DragonScaleDraw,
    DragonWrathEncounter,
    PreMovementRoll,
    PostMovementRolll,
    PreFieldCellEncounter,
    FieldCellEncounter,
    PreCombatRoll,
    PostCombatRoll,
    End
}