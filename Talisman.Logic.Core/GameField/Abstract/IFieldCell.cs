using System.Collections.Generic;
using Talisman.Logic.Core.Cards.Abstract;
using Talisman.Logic.Core.Encounters.Abstract;
using Talisman.Logic.Core.Global.Abstract;

namespace Talisman.Logic.Core.GameField.Abstract;

/// <summary>
/// Defines properties and methods used by the game field cell classes.
/// </summary>
public interface IFieldCell : IWithId, IEncounterable
{
    /// <summary>
    /// Name of the game field cell.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Description of the game field cell.
    /// </summary>
    string Description { get; }

    /// <summary>
    /// Region this cell belongs to.
    /// </summary>
    IFieldRegion Region { get; }

    /// <summary>
    /// Other game cells that can be accessed from this cell.
    /// </summary>
    IList<IFieldCell> RelatedCells { get; }

    /// <summary>
    /// Game cards placed on this cell.
    /// </summary>
    IList<ICard> Cards { get; }
}