using Talisman.Logic.Core.Cards.Abstract;

namespace Talisman.Logic.Core.Players.Implementation;

/// <summary>
/// DTO with additional properties describing player's state.
/// </summary>
public class AdditionalPlayerState
{
    /// <summary>
    /// Character the player is currently transformed into.
    /// </summary>
    public ICharacterCard TransformedCharacter { get; set; }

    /// <summary>
    /// Specifies how many turns need to pass until the transformation effect wears off.
    /// </summary>
    public int TransformTurnsLeft { get; set; }

    /// <summary>
    /// Specifies whether the player can respawn after dying or not.
    /// </summary>
    public bool CanRespawn { get; set; }

    /// <summary>
    /// Specifies whether the player has won the game.
    /// </summary>
    public bool Won { get; set; }
}