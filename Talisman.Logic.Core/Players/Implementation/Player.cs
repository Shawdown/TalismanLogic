using System;
using System.Collections.Generic;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Cards.Implementation;
using Talisman.Logic.Core.GameField.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.Players.Implementation;

/// <summary>
/// Represents a player.
/// </summary>
public class Player : IPlayer
{
    /// <inheritdoc/>
    public IPlayerStats Stats { get; } = new PlayerStats();

    /// <inheritdoc/>
    public string Name { get; set; }

    /// <inheritdoc/>
    public CharacterCard Character { get; set; }

    /// <inheritdoc/>
    public IList<ICard> OwnedCards { get; } = new List<ICard>();

    /// <inheritdoc />
    public IFieldCell FieldCell { get; set; }

    /// <inheritdoc />
    public bool AskYesOrNo(string question = null) => throw new NotImplementedException();
}