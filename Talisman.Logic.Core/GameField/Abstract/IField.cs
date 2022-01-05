using System.Collections.Generic;

namespace Talisman.Logic.Core.GameField.Abstract;

/// <summary>
/// Defines properties and methods used by the game field classes.
/// </summary>
public interface IField
{
    /// <summary>
    /// Game field regions.
    /// </summary>
    IEnumerable<IFieldRegion> Regions { get; }
}