using System.Collections.Generic;
using Talisman.Logic.Core.Global.Abstract;

namespace Talisman.Logic.Core.GameField.Abstract;

/// <summary>
/// Defines properties and methods used by the game field region classes.
/// </summary>
public interface IFieldRegion : IWithId
{
    /// <summary>
    /// Name of the game field region.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Region's game field cells.
    /// </summary>
    IList<IFieldCell> Cells { get; }
}