using System;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Events.Abstract;
using Talisman.Logic.Core.Players.Abstract;
using Talisman.Logic.Core.Players.Implementation;

namespace Talisman.Logic.Core.Events.Implementation;

/// <summary>
/// Represents a character transform event.
/// </summary>
public class TransformEvent : BaseEvent, IPlayerEvent
{
    /// <inheritdoc />
    public override EventType EventType => EventType.Transform;

    /// <inheritdoc />
    public IPlayer TargetPlayer { get; }

    /// <summary>
    /// A character card to transform the player into.
    /// </summary>
    public ICharacterCard TransformedCharacter { get; }

    /// <summary>
    /// Number of turns need to pass until the transformation effect wears off.
    /// </summary>
    public int TransformTurns { get; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// 
    /// <param name="targetPlayer">Player this events targets.</param>
    /// <param name="transformCharacterCard">A character card to transform the player into.</param>
    /// <param name="transformTurns">Number of turns need to pass until the transformation effect wears off.</param>
    /// 
    /// <exception cref="ArgumentNullException"></exception>
    public TransformEvent(Player targetPlayer, ICharacterCard transformCharacterCard, int transformTurns)
    {
        TargetPlayer = targetPlayer ?? throw new ArgumentNullException(nameof(targetPlayer));
        TransformedCharacter = transformCharacterCard ?? throw new ArgumentNullException(nameof(transformCharacterCard));
        TransformTurns = transformTurns;
    }

    /// <summary>
    /// Changes TargetPlayer's <see cref="AdditionalPlayerState.TransformedCharacter"/> to <see cref="TransformedCharacter"/>
    /// and sets <see cref="AdditionalPlayerState.TransformTurnsLeft"/> to <see cref="TransformTurns"/>.
    /// </summary>
    public override void Execute()
    {
        if (TransformTurns < 1)
        {
            return;
        }

        TargetPlayer.AdditionalPlayerState.TransformedCharacter = TransformedCharacter;
        TargetPlayer.AdditionalPlayerState.TransformTurnsLeft = TransformTurns;
    }
}