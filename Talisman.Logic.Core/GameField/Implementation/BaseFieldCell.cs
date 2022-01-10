using System;
using System.Collections.Generic;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Encounters.Abstract;
using Talisman.Logic.Core.Game.Abstract;
using Talisman.Logic.Core.Game.Implementation;
using Talisman.Logic.Core.GameField.Abstract;
using Talisman.Logic.Core.Players.Abstract;

namespace Talisman.Logic.Core.GameField.Implementation;

/// <summary>
/// Represents a generic game field cell.
/// </summary>
public abstract class BaseFieldCell : IFieldCell
{
    /// <inheritdoc />
    public int Id { get; }

    /// <inheritdoc />
    public string Name { get; set; }

    /// <inheritdoc />
    public string Description { get; set; }

    /// <inheritdoc/>
    public IFieldRegion Region { get; }

    /// <inheritdoc/>
    public IList<IFieldCell> RelatedCells { get; set; }

    /// <inheritdoc />
    public IList<ICard> Cards { get; set; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// 
    /// <param name="id">Cell's ID unique to its region.</param>
    /// <param name="region">Region this cell belongs to.</param>
    protected BaseFieldCell(int id, IFieldRegion region)
    {
        Id = id;
        Region = region ?? throw new ArgumentNullException(nameof(region));
    }

    /// <inheritdoc />
    public abstract IEncounterResult Encounter(GameData gameData, IPlayer player);
}