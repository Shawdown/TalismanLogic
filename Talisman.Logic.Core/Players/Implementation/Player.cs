using System;
using System.Collections.Generic;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.GameField.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Players.Implementation;

/// <summary>
/// Represents a player.
/// </summary>
public class Player : IPlayer
{
    /// <inheritdoc/>
    public PlayerStats Stats { get; } = new ();

    /// <inheritdoc/>
    public string Name { get; set; }

    /// <inheritdoc/>
    public ICharacterCard Character { get; set; }

    /// <inheritdoc />
    public AdditionalPlayerState AdditionalPlayerState { get; } = new ();

    /// <inheritdoc/>
    public IList<ICard> OwnedCards { get; } = new List<ICard>();

    /// <inheritdoc />
    public IFieldCell FieldCell { get; set; }

    /// <inheritdoc />
    public bool AskYesOrNo(string question = null) => throw new NotImplementedException();
}